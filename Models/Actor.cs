using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models;

public class Actor
{
    [Key]
    public int ActorId {get; set;}
    [Required]
    [MaxLength(50)]
    public string Name {get; set;}
    public DateOnly BirthYear {get; set;}
}