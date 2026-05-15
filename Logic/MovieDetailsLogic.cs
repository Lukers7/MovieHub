using MovieHub.Models;

namespace MovieHub.Logic;

public static class MovieDetailsLogic
{
    public static string GetTitleLine(Movie movie)
    {
        var title = (movie.Title ?? "").Trim();
        if (title.Length == 0)
        {
            title = "Unbenannter Film";
        }

        return $"{title} ({movie.Year})";
    }
}

