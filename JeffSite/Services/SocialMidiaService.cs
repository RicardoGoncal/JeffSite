using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JeffSite.Data;
using JeffSite.Models;

namespace JeffSite.Services
{
    public class SocialMidiaService
    {
        private readonly JeffContext _context;

        public SocialMidiaService(JeffContext context)
        {
            _context = context;
        }
        public List<SocialMidia> FindAll(){
            return _context.SocialMidia.ToList();
        }

    }

}
