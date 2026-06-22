function meh(count, singular, plural) {
	count = parseInt(count);
	if (count === 1) return `${count} ${singular}`;
	if (count > 1 || count === 0) return `${count} ${plural}`;
	return plural;
}

export default {
	limboVideo: {
		videoId: "ID",
		title: "Title",
		duration: "Duration",
		and: "and",
		day: "day",
		days: (c) => meh(c, "day", "days"),
		minute: "minute",
		minutes: (c) => meh(c, "minute", "minutes"),
		hour: "hour",
		hours: (c) => meh(c, "hour", "hours"),
		second: "second",
		seconds: (c) => meh(c, "second", "seconds"),
		urlPlaceholder: "Enter the URL of the video here...",
		urlEmbedPlaceholder: "Enter the URL or embed code of the video here..."
	}
}