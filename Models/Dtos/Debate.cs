public record Debate(
  string id,
  string date,
  string time,
  DebateStyle style,
  DebateVenue venue,
  string motionType,
  MotionTheme motionTheme,
  string motion,
  string[]? infoSlides,
  Member[]? debaters,
  int[]? points,
  int[]? sps,
  Member chair,
  Member[]? wings,
  string? tournament
);
