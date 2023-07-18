using Porto.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto.BLL
{
    public class Database
    {
        private static PortoDbContext? _context;

        public static PortoDbContext Context
        {
            get
            {
                if (_context == null)
                    _context = new PortoDbContext();
                return _context;
            }
        }

        public static int Save()
        {
            if (_context != null)
                return _context.SaveChanges();
            return 0;
        }
    }
}
