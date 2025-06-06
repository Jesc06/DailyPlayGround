using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Asp.NetCore_MVC_Practice.Models
{
    public class DbTable
    {
        [Key]
        public int Id { get; set; }
        [Required]


        [MaxLength(20, ErrorMessage = "Name must be 20 characters only")]
        [DisplayName("Name")]
        public string Name { get; set; } 


        [MaxLength(20,ErrorMessage = "Lastname must be 20 characters only")]
        [DisplayName("Lastname")]
        public string Lastname { get; set; }



        [Range(1,100,ErrorMessage = "To old must be not required")]
        [DisplayName("Age")]
        public int age { get; set; } 

    }
}
