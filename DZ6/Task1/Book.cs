using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task1
{
    class Book
    {
        //[JsonPropertyName("PublishingHouseId ")]
        //[JsonIgnore]
        public int publishingHouseId { get; set; }
        //[JsonPropertyName("Title")]
        //[JsonPropertyName("Name")]
        public string title { get; set; }
        //public List<PublishingHouse> PublishingHouse { get; set; }
        public PublishingHouse PublishingHouse { get; set; }
    }
}
