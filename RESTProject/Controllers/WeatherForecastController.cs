using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RESTProject.Model;
using System.Text.Json.Serialization;

namespace RESTProject.Controllers
{
    [ApiController]
    [Authorize]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        [Route("api/Test/Topla")]
        public IActionResult Topla(int x, int y)
        {
            return Ok(x + y);
        }

        [HttpGet]
        [Route("api/Test/PersonelGetir")]
        public Personel PersonelGetir()
        {
            var personel = new Personel
            {
                Adi = "Cem",
                Soyadi = "DOS",
                Yas = 32
            };
            return personel;
        }

        [HttpGet]
        [Route("api/Test/PersonelListesiGetir")]
        public List<Personel> PersonelListesiGetir()
        {
            var personelListesi = new List<Personel>();
            for (int i = 0; i < 30; i++)
            {
                personelListesi.Add(new Personel
                {
                    Adi = "Cem",
                    Soyadi = "DOS",
                    Yas = 32
                });
            }

            return personelListesi;
        }
    }
}