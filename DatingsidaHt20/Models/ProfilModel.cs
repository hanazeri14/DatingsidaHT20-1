using System;

public class ProfilModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public int Age { get; set; }
    [Required]
    public string Gender { get; set; }
    [Required]
    public string Sexuality { get; set; }
    [Required]
    public string ImageFilepath { get; set; }
    [Required]
    public string Presentation { get; set; }
    public bool IsActive { get; set; }

    public ProfilModel()
	{
	}
}
