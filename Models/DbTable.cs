using System.ComponentModel.DataAnnotations;

namespace Asp.NetCore_MVC_Practice.Models
{
    public class DbTable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int age { get; set; } 
    }
}
