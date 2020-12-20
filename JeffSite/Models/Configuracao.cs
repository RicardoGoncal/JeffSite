using System.ComponentModel.DataAnnotations;

namespace JeffSite.Models
{
    public class Configuracao
    {
        [Key]
        public int Cod { get; set; }
        
        //[Required (ErrorMessage = "Por favor, inserir {0}!")]
        //[Display(Name = "Nome rede social")]
        public string ContactEmail { get; set; }
        //[StringLength(30, MinimumLength = 3, ErrorMessage = "{0} requer entre {2} e {1} caracteres!")]
        //[Required (ErrorMessage = "Por favor, inserir {0}!")]
        //[Display(Name = "Endereço da rede social")]
        public string ImgProfile { get; set; }
        public string ImgLogo { get; set; }
        public string UrlMercadoLivre { get; set; }

        public Configuracao()
        {
        }

        public Configuracao(string contactEmail, string imgProfile, string imgLogo, string urlMercadoLivre)
        {
            ContactEmail = contactEmail;
            ImgProfile = imgLogo;
            ImgLogo = imgLogo;
            UrlMercadoLivre = urlMercadoLivre;
        }
        
    }
}
