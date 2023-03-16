using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Exams.Models
{
    public class GenreData
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; } 
        [JsonPropertyName("name")]
        public string? Name { get; set; } = "";

        
    }
    
}
