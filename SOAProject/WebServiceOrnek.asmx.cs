using SOAProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;

namespace SOAProject
{
    /// <summary>
    /// Summary description for WebServiceOrnek
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebServiceOrnek : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Topla(int x, int y)
        {
            return x + y;
        }
        [WebMethod]
        public List<Personel> PersonelGetir()
        {
            var personeller = new List<Personel>();
            personeller.Add(new Personel
            {
                Adi = "Cem",
                Soyad = "DOS",
                DTarih = new DateTime(1991, 8, 9),
                Maas = 5000,
                ID = Guid.NewGuid().ToString()
            });
            personeller.Add(new Personel
            {
                Adi = "Burcu",
                Soyad = "Yener",
                DTarih = new DateTime(1991, 8, 9),
                Maas = 5000,
                ID = Guid.NewGuid().ToString()
            });
            return personeller;

        }

        [WebMethod]
        public List<ParaBirimi> KurGetir()
        {
            var kurlar = new List<ParaBirimi>();
            XDocument x = XDocument.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
            var nodes = x.Element("Tarih_Date").Elements("Currency").ToList();
            foreach (var node in nodes)
            {
                var kur = new ParaBirimi();
                kur.Isim = node.Element("Isim").Value;
                kur.CurrencyName = node.Element("CurrencyName").Value;
                //kur.ForexBuying = decimal.Parse(node.Element("ForexBuying").Value,CultureInfo.GetCultureInfo("en-US"));
                kur.ForexBuying = node.Element("ForexBuying").Value;
                //kur.ForexSelling = decimal.Parse(node.Element("ForexSelling").Value, CultureInfo.GetCultureInfo("en-US"));
                kur.ForexSelling = node.Element("ForexSelling").Value;
                kurlar.Add(kur);
            }
            return kurlar;
        }

        [WebMethod]
        public void DataGetir(ParaBirimi paraBirimi)
        {
    
        }
    }
}
