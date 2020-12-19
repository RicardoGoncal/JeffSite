using System.ComponentModel.DataAnnotations;

namespace JeffSite.Models
{
    public class User
    {
        [Key]
        [Required (ErrorMessage = "Por favor, inserir seu nome!")]
        public string UserName { get; set; }

        [Required (ErrorMessage = "Por favor, inserir sua senha!")]
        [MinLength(6, ErrorMessage = "Senha requer no minimo {1} caracteres!")]
        public string Pass { get; set; }

        public User()
        {
        }

        public User(string user, string pass)
        {
            UserName = user;
            Pass = pass;
        }
        
    }
}
