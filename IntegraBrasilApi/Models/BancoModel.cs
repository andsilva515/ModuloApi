using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Models
{
    public class BancoModel
    {
        [JsonPropertyName("ispb")]
        public string Ispb;

        [JsonPropertyName("name")]
        public string NomeAbreviado;

        [JsonPropertyName("code")]
        public int Codido;

        [JsonPropertyName("fullName")]
        public string NomeCompleto;
    }
}