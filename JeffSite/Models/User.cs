using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace JeffSite.Models
{
    public class User
    {
        [Key]
        public string user { get; set; }
        public string pass { get; set; }

        public User()
        {
        }


        public List<User> ListUserRegistered()
        {
            List<User> users = new List<User>();

            users.Add( new User { user = "jeff", pass = "123" });
            users.Add( new User { user = "admin", pass = "123" });

            return users;

        }

    }
}
