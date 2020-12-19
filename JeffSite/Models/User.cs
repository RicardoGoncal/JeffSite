using System.ComponentModel.DataAnnotations;

namespace JeffSite.Models
{
    public class User
    {
        [Key]
        [Required (ErrorMessage = "Por favor, inserir seu nome!")]
        public string user { get; set; }

        [Required (ErrorMessage = "Por favor, inserir sua senha!")]
        public string pass { get; set; }

        public User()
        {
        }
        
    }
}
