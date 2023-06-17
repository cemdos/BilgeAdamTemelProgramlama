using StokTakip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BLL.Interfaces
{
    public interface IKullaniciRepository:IBaseRepository<Kullanici>
    {
        Kullanici Login(string username, string password);
    }
}
