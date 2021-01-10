using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace JeffSite.InfoContato{

    public class Contato{

        // Realizar a administração das informações do contato.
        public string Email{get; set; }
        public string Email2{get; set; }

        public Dictionary<string, string> retornajson(){

            // Arquivo em formato Json
            string json = @"{
                'Email': 'rika_alves@hotmail.com',
                'Email2': 'ricardo.alvesgoncalves@gmail.com'
            }";

            // Cria uma instancia para poder utilizar os dados do Json
            Contato infos = JsonConvert.DeserializeObject<Contato>(json);


            // Variaveis que contém os valores json
            string email1 = infos.Email;
            string email2 = infos.Email2;

            // Criação de um dicionario 
            var dic1 = new Dictionary<string, string>();
            dic1.Add("email", email1);
            dic1.Add("email2", email2);

            // Retorna o dicionario pelo metodo.
            return dic1;
        }

    }
}
    
