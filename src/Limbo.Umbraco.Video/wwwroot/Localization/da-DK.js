function meh(count, singular, plural) {
	count = parseInt(count);
	if (count === 1) return `${count} ${singular}`;
	if (count > 1 || count === 0) return `${count} ${plural}`;
	return plural;
}

export default {
	limboVideo: {
		videoId: "ID",
		title: "Titel",
		duration: "Længde",
		and: "og",
		day: "dag",
		days: (c) => meh(c, "dag", "dage"),
		minute: "minut",
		minutes: (c) => meh(c, "minut", "minutter"),
		hour: "time",
		hours: (c) => meh(c, "time", "timer"),
		second: "sekund",
		seconds: (c) => meh(c, "sekund", "sekunder"),
		urlPlaceholder: "Angiv videoens URL her...",
		urlEmbedPlaceholder: "Angiv videoens URL eller embed-kode her..."
	}
}