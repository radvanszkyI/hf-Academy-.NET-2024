using System.ComponentModel.DataAnnotations;

namespace Academy_2024.Models
{
    public class Course
    {
        [Required]
        public int? Id { get; set; }

        [StringLength(20)]
        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
