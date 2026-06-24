using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApi.Models;

public class MovieDetails
{
    public int MovieDetailsId {get; set;}
    public string? Synopsis {get; set;}
    public string? Language {get;set;}
    public ulong? Budget {get;set;}

    [ForeignKey("MovieId")]
    public Movie? movie {get; set;}
    public int MovieId {get; set;}
}