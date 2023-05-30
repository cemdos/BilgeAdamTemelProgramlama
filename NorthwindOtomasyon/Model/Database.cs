using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindOtomasyon.Model
{
    public class Database
    {
		private static NORTHWNDEntities db;

		public static NORTHWNDEntities DB
		{
			get {
				if(db == null)
					db=new NORTHWNDEntities();
				return db; 
			}
		}

		public int Save()
		{
			return db.SaveChanges();
		}

	}
}
