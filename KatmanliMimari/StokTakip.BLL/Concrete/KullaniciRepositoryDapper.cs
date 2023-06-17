using StokTakip.BLL.Interfaces;
using StokTakip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BLL.Concrete
{
    public class KullaniciRepositoryDapper : BaseRepository<Kullanici>, IKullaniciRepository
    {
        public Kullanici Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
