using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters"),MinLength(3)]
        public string Name { get; set; }
    }
}
