using System.ComponentModel.DataAnnotations;

namespace JeffSite.Models
{
    public class SocialMidia
    {
        [Key]
        [Required (ErrorMessage = "Por favor, inserir {0}!")]
        [Display(Name = "Nome rede social")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Por favor, inserir {0}!")]
        //[StringLength(200, MinimumLength = 3, ErrorMessage = "{0} requer entre {2} e {1} caracteres!")]
        [Display(Name = "Endereço da rede social")]
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
