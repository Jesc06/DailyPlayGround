using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Asp.NetCore_MVC_Practice.Models
{
    public class DbTable
    {
        [Key]
        public int Id { get; set; }
        [Required]

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Lastname")]
        public string Lastname { get; set; }

        [DisplayName("Age")]
        public int age { get; set; } 
    }
}
