using System;
using System.Collections.Generic;
using System.Linq;

namespace JeffSite.Models
{
    public class Usuario
    {
        public string usuario { get; set; }
        public string senha { get; set; }

        public Usuario()
        {
        }

        public List<Usuario> ListUserRegistered()
        {
            List<Usuario> usuarios = new List<Usuario>();

            usuarios.Add( new Usuario { usuario = "jeff", senha = "123" });
            usuarios.Add( new Usuario { usuario = "admin", senha = "123" });

            return usuarios;

        }

        public bool VerificaUsuario(Usuario usuario)
        {
            bool resultado = ListUserRegistered().Any(u => u.usuario == usuario.usuario && u.senha == usuario.senha);
            return resultado;
        }

    }
}
