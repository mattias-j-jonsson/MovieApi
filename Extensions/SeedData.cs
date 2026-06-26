using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using MovieApi.Contexts;
using MovieApi.Controllers;
using MovieApi.Models;
using NuGet.Protocol;

namespace MovieApi.Extensions;

internal static class MovieApiExtensions
{
    internal static void SeedData(this WebApplication webApplication, MovieApiContext context)
    {
        
    
        using var _context = context;

        if (_context == null)
        {
            throw new Exception("_context is null in SeedData extension method.");
        }

        var movies = GetMovies();
        _context.Movies.AddRange(movies);

        _context.SaveChanges();
    }

    private static IEnumerable<Movie> GetMovies()
    {
        var movies = new Movie[]
        {
            new Movie
            {
                Title = "Fucking Åmål",
                Year = new DateOnly(1998, 1, 1),
                Genre = "Drama",
                Duration = TimeSpan.FromMinutes(89),
                movieDetails = new MovieDetails
                {
                    Synopsis = "Two seemingly disparate teenage girls struggle with finding identity and love in a Swedish small town.",
                    Language = "Swedish",
                    Budget = 900000
                },
                reviews = new List<Review>()
                {
                    new Review
                    {
                        ReviewerName = "Klas Olsson",
                        Comment = "Cool film!",
                        Rating = 9
                    },
                    new Review
                    {
                        ReviewerName = "Gant Ladysman",
                        Comment = "Excellent!",
                        Rating = 9
                    }
                },
                actors = new List<Actor>()
                {
                    new Actor
                    {
                        Name = "Rebecka Liljeberg",
                        BirthYear = new DateOnly(1981, 1 ,1)
                    },
                    new Actor
                    {
                        Name = "Alexandra Dahlström",
                        BirthYear = new DateOnly(1984, 1 ,1)
                    }
                }
            },
            new Movie
            {
                Title = "My Neighbor Totoro",
                Year = new DateOnly(1988, 1, 1),
                Genre = "Animation",
                Duration = TimeSpan.FromMinutes(86),
                movieDetails = new MovieDetails
                {
                    Synopsis = "Two young sisters, after moving with their father to the countryside, experience interactions with friendly wood spirits in postwar Japan.",
                    Language = "Japanese",
                    Budget = 10000000
                },
                reviews = new List<Review>()
                {
                    new Review
                    {
                        ReviewerName = "Fran Holodeck",
                        Comment = "Gorgeous",
                        Rating = 10
                    },
                    new Review
                    {
                        ReviewerName = "Gant Ladysman",
                        Comment = "Best naturalstic depiction of small children of all time.",
                        Rating = 10
                    }
                },
                actors = new List<Actor>()
                {
                    new Actor
                    {
                        Name = "Noriko Hidaka",
                        BirthYear = new DateOnly(1962, 1 ,1)
                    },
                    new Actor
                    {
                        Name = "Chika Sakamoto",
                        BirthYear = new DateOnly(1959, 1 ,1)
                    }
                }
            },
            new Movie
            {
                Title = "Heat",
                Year = new DateOnly(1995, 1, 1),
                Genre = "Action",
                Duration = TimeSpan.FromMinutes(170),
                movieDetails = new MovieDetails
                {
                    Synopsis = "LAPD detective Vincent Hanna attempts to apprehend career thief Neil McCauley.",
                    Language = "English",
                    Budget = 60000000
                },
                reviews = new List<Review>()
                {
                    new Review
                    {
                        ReviewerName = "Fran Holodeck",
                        Comment = "Intense, thoughtful and beautifully shot.",
                        Rating = 9
                    },
                    new Review
                    {
                        ReviewerName = "Wrilko Maskitaritz",
                        Comment = "Strong performances, but just slightly too long and indulgent.",
                        Rating = 7
                    }
                },
                actors = new List<Actor>()
                {
                    new Actor
                    {
                        Name = "Al Pacino",
                        BirthYear = new DateOnly(1940, 1 ,1)
                    },
                    new Actor
                    {
                        Name = "Robert De Niro",
                        BirthYear = new DateOnly(1943, 1, 1)
                    }
                }
            }
        };

        return movies;
    }
}