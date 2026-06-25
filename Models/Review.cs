using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApi.Models;

public class Review
{
    public int ReviewId {get;set;}
    
    [Required]
    [MaxLength(50)]
    public string ReviewerName {get;set;}

    [MaxLength(200)]
    public string Comment {get;set;}

    [Range(1, 10, MaximumIsExclusive = true, MinimumIsExclusive = true)]
    public int Rating {get; set;}

    [ForeignKey("MovieId")]
    public Movie movie {get; set;}
    public int MovieId {get; set;}
}