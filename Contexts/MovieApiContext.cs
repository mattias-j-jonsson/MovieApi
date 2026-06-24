using Microsoft.EntityFrameworkCore;
using MovieApi.Models;

namespace MovieApi.Contexts;

public class MovieApiContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieDetails> Details { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Actor> Actors { get; set; }


}