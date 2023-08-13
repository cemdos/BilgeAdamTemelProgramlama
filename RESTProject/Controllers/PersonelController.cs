using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTProject.Model;

namespace RESTProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        private static List<Personel>? personelListesi;

        public List<Personel> PersonelListesi
        {
            get
            {
                if (personelListesi == null)
                    personelListesi = new List<Personel>();
                return personelListesi;
            }
        }

        [HttpGet]
        public List<Personel> GetPersonelList()
        {
            return PersonelListesi;
        }

        [HttpGet]
        public List<Personel> GetPersonelFilter(string soyad)
        {
            return PersonelListesi.Where(x=>x.Soyadi==soyad).ToList();
        }


        [HttpPost]
        public bool PersonelEkle(Personel model)
        {
            PersonelListesi.Add(model);
            return true;
        }
    }
}
