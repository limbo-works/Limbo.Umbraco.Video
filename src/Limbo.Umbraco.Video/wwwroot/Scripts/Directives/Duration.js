angular.module("umbraco").directive("limboVideoDuration", function (localizationService) {

    // Initialize labels in English
    const labels = {
        and: "and",
        minute: "minute",
        minutes: "minutes",
        second: "second",
        seconds: "seconds",
        hour: "hour",
        hours: "hours"
    };

    function xmlDurationToSeconds(value) {

        const p = "(([0-9]+)(H|M|S|D)|)";

        const m = value.match(`^P${p}${p}${p}T${p}${p}${p}$`);
        if (!m) return 0;

        // Depending on whether "M" comes before or after "T", it may mean either months or minutes. Since it's very
        // unlikely that we'll encounter videos that last for months, this implementation currently doesn't check for
        // the position of the "M".

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
        restrict: "E",
        template: "<span class=\"limbo-video-duration\"><span ng-repeat=\"dur in duration\">{{dur.value}} <small>{{dur.text}}</small></span><em ng-show=\"vm.duration.length == 0\">N/A</em></span>",
        scope: {
            value: "="
        },
        link: function (scope) {

            function update() {

                const keys1 = Object.keys(labels);
                const keys2 = Object.keys(labels).map(x => `limboVideo_${x}`);

                localizationService.localizeMany(keys2).then(function (values) {

                    let seconds;

                    // Handle various formats
                    if (typeof scope.value === "object" && scope.value.duration) {
                        seconds = value.duration;
                    } else if (typeof scope.value === "number") {
                        seconds = scope.value;
                    } else if (typeof (scope.value) === "string") {
                        if (scope.value.length === 0) {
                            scope.duration = [];
                            return;
                        }
                        if (scope.value[0] === "P") {
                            seconds = xmlDurationToSeconds(scope.value);
                        } else {
                            seconds = parseFloat(scope.value);
                            if (isNaN(seconds)) {
                                scope.duration = [];
                                return;
                            }
                        }
                    } else {
                        scope.duration = [];
                        return;
                    }

                    seconds = Math.floor(seconds);

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
                            duration[i].text += ", ";
                            duration[i].suffix += ", ";
                        }

                    }

                    scope.duration = duration;

                });

            }

            scope.$watch("value", function () {
                update();
            });

        }
    };

});