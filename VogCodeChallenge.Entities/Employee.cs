using System.ComponentModel.DataAnnotations;


namespace VogCodeChallenge.Entities
{

    public class Employee
        {
            [Required]
            public int Id { get; set; }
            [Required] [MaxLength(50)] public string FirstName { get; set; }

            [Required] [MaxLength(50)] public string LastName { get; set; }

            [Required] [MaxLength(50)] public string JobTitle { get; set; }

            [MaxLength(100)] public string Address { get; set; }

            [Required] public Department Department { get; set; }
        }
    }

