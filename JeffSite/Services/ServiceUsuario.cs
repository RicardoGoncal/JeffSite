using JeffSite.Data;

namespace JeffSite.Services
{

    public class ServiceUsuario
    {
        private readonly JeffContext _context;

        public ServiceUsuario(JeffContext context)
        {
            _context = context;
        }

    }

}
