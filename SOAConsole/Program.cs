using ServiceReferenceOrnek;
using static ServiceReferenceOrnek.WebServiceOrnekSoapClient;

WebServiceOrnekSoapClient client = new WebServiceOrnekSoapClient(EndpointConfiguration.WebServiceOrnekSoap12);
//var data = client.ToplaAsync(50, 70).Result;


//var personeller = client.PersonelGetirAsync().Result.Body.PersonelGetirResult;
//foreach (var item in personeller)
//{
//    Console.WriteLine($"Adı: {item.Adi}\t Soyadı:{item.Soyad}");
//}

var kurlar = client.KurGetirAsync().Result.Body.KurGetirResult;
foreach (var item in kurlar)
{
    Console.WriteLine($"Para Birimi: {item.Isim}\t Satış Değeri:{item.ForexSelling}");
}