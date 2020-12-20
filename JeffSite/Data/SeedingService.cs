using System.Linq;
using JeffSite.Models;

namespace JeffSite.Data
{
    public class SeedingService
    {
        private readonly JeffContext _context;

        public SeedingService(JeffContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.User.Any())
            {
                return;
            }

            User user1 = new User {UserName = "Admin", Pass = "123"};
            User user2 = new User {UserName = "Jeff", Pass = "123"};
            _context.User.AddRange(user1, user2);

            if (_context.Configuracao.Any())
            {
                return;
            }

            Configuracao c1 = new Configuracao {Cod = 1, ImgLogo = "imgLogo.png", ImgProfile = "imgProfile.png", ContactEmail = "test@test.com"};
            _context.Configuracao.Add(c1);

            _context.SaveChanges();

        }
    }
}
