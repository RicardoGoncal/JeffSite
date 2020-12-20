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
        public void Create(SocialMidia socialMidia){
            _context.SocialMidia.Add(socialMidia);
            _context.SaveChanges();
        }
        public SocialMidia FindByName(string name){
            return _context.SocialMidia.FirstOrDefault(s => s.Name == name);
        }
        public void Delete(SocialMidia socialMidia){
            _context.SocialMidia.Remove(socialMidia);
            _context.SaveChanges();
        }

    }

}
