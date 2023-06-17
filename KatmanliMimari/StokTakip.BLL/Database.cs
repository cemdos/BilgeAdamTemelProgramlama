using StokTakip.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BLL
{
    public class Database
    {
		private static StokTakipContext _context;

		public static StokTakipContext Context
		{
			get {
				if (_context == null)
					_context = new StokTakipContext();
				return _context; 
			}
		}

		public static int Save()
		{
			return _context.SaveChanges();
		}
	}
}
