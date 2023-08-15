using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RESTProject.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RESTProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
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

        [HttpGet]
        [AllowAnonymous]
        public string GetToken(string username, string password)
        {
            if (!(username == "admin" && password == "admin"))
                return "Kullanıcı yada Sifre hatalı";

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenSecretKey = "BilgeAdamSecretKey";
            var tokenExpireMinutes = 20;

            var key = Encoding.ASCII.GetBytes(tokenSecretKey);
            var tokendecriptır = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("UserName", username),
                    new Claim("Role","Admin")
                }),
                Expires = DateTime.UtcNow.AddMinutes(tokenExpireMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokendecriptır);
            string TokenString = tokenHandler.WriteToken(token);
            return TokenString;
        }
    }
}
