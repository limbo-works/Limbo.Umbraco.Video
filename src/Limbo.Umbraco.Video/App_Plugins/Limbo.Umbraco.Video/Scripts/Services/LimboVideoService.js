angular.module("umbraco.services").factory("limboVideoService", function () {

    function xmlDurationToSeconds(value) {

        const p = "(([0-9]+)(H|M|S|D)|)";

        const m = value.match(`^P${p}${p}${p}T${p}${p}${p}$`);
        if (!m) return 0;

        let seconds = 0;

        for (let i = 1; i < m.length; i += 3) {
            if (m[i]) {
                switch (m[i + 2]) {
                case "D":
                    seconds += parseInt(m[i + 1]) * 24 * 60 * 60;
                    break;
                case "H":
                    seconds += parseInt(m[i + 1]) * 60 * 60;
                    break;
                case "M":
                    seconds += parseInt(m[i + 1]) * 60;
                    break;
                case "S":
                    seconds += parseInt(m[i + 1]);
                    break;
                }
            }
        }

        return seconds;

    }
   
    return {
        getDuration: function (value, format) {

            let seconds;
            if (typeof value === "number") {
                seconds = value;
            } else if (format === "xml") {
                seconds = xmlDurationToSeconds(value);
            } else {
                return null;
            }

            const duration = [];

            const hours = Math.floor(seconds / 60 / 60);
            seconds = seconds - (hours * 60 * 60);

            const minutes = Math.floor(seconds / 60);
            seconds = seconds - (minutes * 60);

            if (hours === 1) {
                duration.push({ value: 1, text: "time", suffix: "t" });
            } else if (hours > 1) {
                duration.push({ value: hours, text: "timer", suffix: "t" });
            }

            if (minutes === 1) {
                duration.push({ value: 1, text: "minut", suffix: "m" });
            } else if (minutes > 1) {
                duration.push({ value: minutes, text: "minutter", suffix: "m" });
            }

            if (seconds === 1) {
                duration.push({ value: 1, text: "sekund", suffix: "s" });
            } else if (seconds > 1) {
                duration.push({ value: Math.floor(seconds), text: "sekunder", suffix: "s" });
            }

            for (let i = 0; i < duration.length - 1; i++) {
                if (i === duration.length - 2) {
                    duration[i].text += " og ";
                    duration[i].suffix += " og ";
                } else {
                    duration[i].text += ",";
                    duration[i].suffix += ",";
                }
            }

            return duration;

        }
    }

});