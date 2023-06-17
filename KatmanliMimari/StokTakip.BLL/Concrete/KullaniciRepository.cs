using StokTakip.BLL.Interfaces;
using StokTakip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BLL.Concrete
{
    public class KullaniciRepository : BaseRepository<Kullanici>, IKullaniciRepository
    {
        public Kullanici Login(string username, string password)
        {
            var kullanici = GetAll().FirstOrDefault(x => x.KullaniciAdi == username && x.Sifre == password);
            return kullanici;
        }
    }
}
