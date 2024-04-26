using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Models
{
    public class EnderecoModel
    {
        [JsonPropertyName("cep")]
        public string Cep;

        [JsonPropertyName("state")]
        public string Estado;

        [JsonPropertyName("city")]
        public string Cidade;

        [JsonPropertyName("neighborhood")]
        public string Região;

        [JsonPropertyName("street")]
        public string Rua;

        [JsonPropertyName("service")]
        public string Servico;
    }
}