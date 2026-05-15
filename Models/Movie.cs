namespace MovieHub.Models;

public sealed record Movie(
    int Id,
    string Title,
    int Year,
    string Genre,
    string Director,
    int RuntimeMinutes,
    decimal Rating,
    string Notes
);
