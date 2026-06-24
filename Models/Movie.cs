using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models;

public class Movie
{
    [Key]
    public int Id {get;set;}
    [Required]
    [MaxLength(100)]
    public string Title {get;set;}
    public DateOnly Year {get;set;}
    public string Genre  {get;set;}
    public TimeSpan Duration {get;set;}
    public MovieDetails movieDetails {get;set;}
    public IEnumerable<Review> reviews {get; set;} = new List<Review>();
    public IEnumerable<Actor> actors {get; set;} = new List<Actor>();
}