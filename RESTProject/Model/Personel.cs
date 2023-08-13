using System.Text.Json.Serialization;

namespace RESTProject.Model
{
    public class Personel
    {
        [JsonPropertyName("Adi")]
        public string Adi { get; set; }
        [JsonPropertyName("Soyadi")]
        public string Soyadi { get; set; }
        [JsonPropertyName("Yas")]
        public int Yas { get; set; }
    }
}
