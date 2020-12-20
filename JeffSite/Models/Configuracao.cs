using System.ComponentModel.DataAnnotations;

namespace JeffSite.Models
{
    public class Configuracao
    {
        [Key]
        public int Cod { get; set; }
        
        [Required (ErrorMessage = "Por favor, inserir {0}!")]
        [Display(Name = "E-mail para contato")]
        public string ContactEmail { get; set; }
        //[StringLength(30, MinimumLength = 3, ErrorMessage = "{0} requer entre {2} e {1} caracteres!")]
        [Required (ErrorMessage = "Por favor, inserir {0}!")]
        [Display(Name = "Foto logotipo")]
        public string ImgProfile { get; set; }
        
        [Required (ErrorMessage = "Por favor, inserir {0}!")]
        [Display(Name = "Imagem do perfil")]
        public string ImgLogo { get; set; }

        [Display(Name = "Endereco da loja do Mercado Livre")]
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
