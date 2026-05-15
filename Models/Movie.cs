namespace MovieHub.Models;

public sealed record Movie(
    string Title,
    int Year,
    string Genre,
    string Director,
    int RuntimeMinutes,
    decimal Rating,
    string Notes
);
