using System.ComponentModel.DataAnnotations;

namespace JeffSite.Models
{
    public class SocialMidia
    {
        [Key]
        [Required]
        //[MinLength(3,ErrorMessage = "{1} requer no minimo {2}")]
        [Display(Name = "Nome rede social")]
        public string Name { get; set; }

        [Required]
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
