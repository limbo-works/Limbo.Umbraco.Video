angular.module("umbraco.services").factory("limboVideoService", function ($q, localizationService) {

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

    function hest(value, singular, plural) {

        const key = value === 1 ? singular : plural;

        const t = {
            value: value,
            text: key,
            suffix: key.substr(0, 1)
        };

        return t;

    }
   
    return {
        getDuration: function (value, format, callback) {

            // As "localizationService" is asynchronous, a "callback" parameter is required

            // Second parameter may be the callback if the format is omitted
            if (!callback && typeof format === "function") {
                callback = format;
                format = null;
            }

            // Initialize labels in English
            const labels = {
                and: "and",
                minute: "minute",
                minutes: "minutes",
                second: "second",
                seconds: "seconds",
                hours: "hour",
                hours: "hours"
            };

            const keys1 = Object.keys(labels);
            const keys2 = Object.keys(labels).map(x => "limboVideo_" + x);

            localizationService.localizeMany(keys2).then(function (values) {

                let seconds;

                // Handle various formats
                if (typeof value === "object" && value.duration) {
                    seconds = value.duration;
                } else if (typeof value === "number") {
                    seconds = value;
                } else if (format === "xml") {
                    seconds = xmlDurationToSeconds(value);
                } else {
                    callback(null);
                    return;
                }

                values.forEach(function (v, i) {
                    labels[keys1[i]] = v;
                });

                const duration = [];

                const hours = Math.floor(seconds / 60 / 60);
                seconds = seconds - (hours * 60 * 60);

                const minutes = Math.floor(seconds / 60);
                seconds = seconds - (minutes * 60);

                if (hours > 0) duration.push(hest(hours, labels.hour, labels.hours));
                if (minutes > 0) duration.push(hest(minutes, labels.minute, labels.minutes));
                if (seconds > 0) duration.push(hest(seconds, labels.second, labels.seconds));

                if (duration.length > 1) {

                    // Append "and" as a filler between the last and second last items
                    duration.splice(duration.length - 1, 0, {
                        text: ` ${labels.and} `,
                        suffix: ` ${labels.and} `
                    });

                    // Append ", " as filler between remaining items
                    for (let i = 0; i < duration.length - 3; i++) {
                        duration[i].text += ",";
                        duration[i].suffix += ",";
                    }

                }

                callback(duration);

            });

        }
    }

});