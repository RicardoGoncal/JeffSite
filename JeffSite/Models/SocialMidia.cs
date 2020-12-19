using System.ComponentModel.DataAnnotations;

namespace JeffSite.Models
{
    public class SocialMidia
    {
        [Key]
        [Required (ErrorMessage = "Por favor, inserir o {0}}!")]
        [MinLength(3,ErrorMessage = "{1} requer no minimo {2}")]
        [Display(Name = "Nome Rede Social")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Por favor, inserir a {0}}!")]
        [Display(Name = "Endereco Rede Social")]
        public string Url { get; set; }

        public SocialMidia()
        {
        }

        public SocialMidia(string name, string url)
        {
            Name = name;
            Url = url;
        }
        
    }
}
