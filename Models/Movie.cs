namespace MovieApi.Models;

public class Movie
{
    int Id {get;set;}
    string Title {get;set;}
    DateOnly Year {get;set;}
    string Genre  {get;set;}
    TimeSpan Duration {get;set;}
    MovieDetails movieDetails {get;set;}
    IEnumerable<Review> reviews {get; set;} = new List<Review>();
    IEnumerable<Actor> actors {get; set;} = new List<Actor>();
}