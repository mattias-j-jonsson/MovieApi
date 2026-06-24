using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApi.Models;

public class Review
{
    public int ReviewId {get;set;}
    public string ReviewerName {get;set;}
    public string Comment {get;set;}
    public int Rating {get; set;}

    [ForeignKey("MovieId")]
    public Movie movie {get; set;}
    public int MovieId {get; set;}
}