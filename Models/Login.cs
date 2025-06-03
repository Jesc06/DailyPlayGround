using System.ComponentModel.DataAnnotations;

namespace Asp.NetCore_MVC_Practice.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string username { get; set; }
        public string password { get; set; }    
    }
}
