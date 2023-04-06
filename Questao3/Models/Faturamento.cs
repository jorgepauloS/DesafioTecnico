using System.Text.Json.Serialization;

namespace Questao3.Models
{
    internal class Faturamento
    {
        [JsonPropertyName("dia")]
        public byte Dia { get; set; }
        [JsonPropertyName("valor")]
        public double Valor { get; set; }
    }
}
