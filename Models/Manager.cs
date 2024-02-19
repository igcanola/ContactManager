using System.ComponentModel.DataAnnotations;

namespace ManagerWebApp.Models
{
    public class Manager
    {
        [Key]
        public int idContact { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }   

       public string Category { get; set; }

        public Manager()
        {
            

        }

    }
}
