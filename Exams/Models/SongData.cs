using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Exams.Models
{
    public class SongData
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("artist")]
        public string? Artist { get; set; }

        [JsonPropertyName("genreName")]
        public string? GenreName { get; set; }

        [JsonPropertyName("length")]
        public int? Length { get; set; }

        [JsonPropertyName("releaseDate")]
        public string? ReleaseDate { get; set; }

        [JsonPropertyName("isAvailable")]
        public bool? IsAvailable { get; set; }
        

    }
}
