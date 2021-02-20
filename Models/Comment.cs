using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_BertoniSolutions.Models
{
    public class Comment : Domain
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email {get; set;}

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("postId")]
        public int PhotoId { get; set; }
    }
}
