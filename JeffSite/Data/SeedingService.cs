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
            if (_context.User.Any()) //data already exists
            {
                return; //bd has been seeded
            }

            User user1 = new User {UserName = "Admin", Pass = "123"};
            User user2 = new User {UserName = "Jeff", Pass = "123"};
            _context.User.AddRange(user1, user2);

            _context.SaveChanges();

        }
    }
}
