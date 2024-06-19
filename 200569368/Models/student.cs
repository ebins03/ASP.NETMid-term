using System.ComponentModel.DataAnnotations;

namespace _200569368.Models;

public class Student
{
    [Key]
    public int StudentId { get; set; }

    [Required]
    [StringLength(50)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(50)]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    public string EmailAddress { get; set; }
}
