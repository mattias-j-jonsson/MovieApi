namespace MovieApi.Models;

public class Movie
{
    int Id {get;set;}
    string Title {get;set;}
    DateOnly Year {get;set;}
    string Genre  {get;set;}
    TimeSpan Duration {get;set;}
    MovieDetails movieDetails;
    IEnumerable<Review> reviews;
    IEnumerable<Actor> actors;
}