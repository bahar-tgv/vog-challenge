using System.ComponentModel.DataAnnotations;

namespace VogCodeChallenge.Entities
{
    public class Department
    {
        [Required] public int Id { get; set; }

        [Required] [MaxLength(100)] public string Name { get; set; }

        [Required] [MaxLength(100)] public string Address { get; set; }
    }
}