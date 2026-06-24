using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models;

public class Actor
{
    int ActorId {get; set;}
    [Required]
    [MaxLength(50)]
    string Name {get; set;}
    DateOnly BirthYear {get; set;}
}