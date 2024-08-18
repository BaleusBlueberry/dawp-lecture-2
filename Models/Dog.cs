using System.ComponentModel.DataAnnotations;

namespace dawp_lecture_2.Models;

public class Dog
{
    [Key]
    public required int Id { get; set; }

    [Required, MinLength(2, ErrorMessage = "Minimum of 2 characters")] 
    [MaxLength(20, ErrorMessage = "Maximum 20 characters")]
    
    public required string Breed { get; set; }

    [Required, MinLength(2, ErrorMessage = "Minimum of 2 characters")]
    [MaxLength(40, ErrorMessage = "Maximum 40 characters")]
    public required string Name { get; set; }
}

