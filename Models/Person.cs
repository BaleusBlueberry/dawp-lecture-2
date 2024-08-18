using System.ComponentModel.DataAnnotations;

namespace dawp_lecture_2.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(2), MaxLength(20)]
        public string Name { get; set; }

    }
}
