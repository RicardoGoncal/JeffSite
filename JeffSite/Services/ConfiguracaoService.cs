using System.Linq;
using System.Threading.Tasks;
using JeffSite.Data;
using JeffSite.Models;

namespace JeffSite.Services
{
    public class ConfiguracaoService
    {
        private readonly JeffContext _context;

        public ConfiguracaoService(JeffContext context)
        {
            _context = context;
        }

    }

}
