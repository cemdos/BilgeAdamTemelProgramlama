using StokTakip.BLL.Concrete;
using StokTakip.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BLL
{
    public class UnitOfWork
    {
        private static UnitOfWork instance;

        public static UnitOfWork Intance
        {
            get
            {
                if (instance == null)
                    instance = new UnitOfWork();
                return instance;
            }
        }

        public IKullaniciRepository Kullanici
        {
            get
            {
                return new KullaniciRepository();
            }
        }

        public IMusteriRepository Musteri
        {
            get
            {
                return new MusteriRepository();
            }
        }

    }
}
