﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TesteAntecipa
{
    public class Pet
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("category")]
        public Category Category { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("photoUrls")]
        public List<string> PhotoUrls { get; set; }

        [JsonPropertyName("tags")]
        public List<Tag> Tags { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }

    public class Category
    {
        [JsonPropertyName("id")]
        public Int64 Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Tag
    {
        [JsonPropertyName("id")]
        public Int64 Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
