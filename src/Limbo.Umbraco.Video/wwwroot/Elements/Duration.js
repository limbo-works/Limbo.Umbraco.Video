import { UmbElementMixin } from "@umbraco-cms/backoffice/element-api";
import { LitElement, html, css, repeat, when } from "@umbraco-cms/backoffice/external/lit";
import { UmbChangeEvent } from "@umbraco-cms/backoffice/event";

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

export class LimboVideoDurationElement extends UmbElementMixin(LitElement) {

    static properties = {
        value: { type: String }
    };

    static styles = css`
        :host {
            display: inline;
        }
    `;

    constructor() {
        super();
        this.value = "";
    }

    get totalSeconds() {
        if (!this.value) return 0;
        const numericValue = Number(this.value);
        if (!Number.isNaN(numericValue)) return numericValue;
        return xmlDurationToSeconds(this.value);
    }

    render() {

        const totalSeconds = Math.max(0, Math.floor(this.totalSeconds));

        const days = Math.floor(totalSeconds / 86400);
        const hours = Math.floor((totalSeconds % 86400) / 3600);
        const minutes = Math.floor((totalSeconds % 3600) / 60);
        const seconds = totalSeconds % 60;

        const parts = [];
        if (days) parts.push(this.localize.term("limboVideo_days", days));
        if (hours) parts.push(this.localize.term("limboVideo_hours", hours));
        if (minutes) parts.push(this.localize.term("limboVideo_minutes", minutes));
        if (seconds || parts.length === 0) parts.push(this.localize.term("limboVideo_seconds", seconds));

        let text;
        switch (parts.length) {
            case 1:  return parts[0];
            case 2: return parts.join(` ${this.localize.term("limboVideo_and")} `);
            default: return `${parts.slice(0, -1).join(", ")} ${this.localize.term("limboVideo_and")} ${parts.at(-1)}`;
        }

    }

}

customElements.define("limbo-video-duration", LimboVideoDurationElement);

export default LimboVideoDurationElement;