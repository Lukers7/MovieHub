using MovieHub.Logic;
using MovieHub.Models;

namespace MovieHub.Tests;

public sealed class MovieDetailsLogicTests
{
    [Fact]
    public void GetTitleLine_ReturnsTitleAndYear()
    {
        var movie = new Movie(
            Id: 1,
            Title: "The Matrix",
            Year: 1999,
            Genre: "Sci‑Fi/Action",
            Director: "Lana & Lilly Wachowski",
            RuntimeMinutes: 136,
            Rating: 8.7m,
            Notes: ""
        );

        var result = MovieDetailsLogic.GetTitleLine(movie);

        Assert.Equal("The Matrix (1999)", result);
    }

    [Fact]
    public void GetTitleLine_TrimsTitle()
    {
        var movie = new Movie(
            Id: 1,
            Title: "  Inception  ",
            Year: 2010,
            Genre: "",
            Director: "",
            RuntimeMinutes: 0,
            Rating: 0m,
            Notes: ""
        );

        var result = MovieDetailsLogic.GetTitleLine(movie);

        Assert.Equal("Inception (2010)", result);
    }

    [Fact]
    public void GetTitleLine_EmptyTitle_UsesFallback()
    {
        var movie = new Movie(
            Id: 1,
            Title: "   ",
            Year: 2019,
            Genre: "",
            Director: "",
            RuntimeMinutes: 0,
            Rating: 0m,
            Notes: ""
        );

        var result = MovieDetailsLogic.GetTitleLine(movie);

        Assert.Equal("Unbenannter Film (2019)", result);
    }
}

