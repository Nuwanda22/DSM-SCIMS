using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIMS.Models
{
    public class User
    {
        [JsonProperty(PropertyName = "login")]
        public string Username { get; set; }

        public int Id { get; set; }

        [JsonProperty(PropertyName = "avatar_url")]
        public string AvatarUrl { get; set; }
        
        public string Url { get; set; }

        [JsonProperty(PropertyName = "html_url")]
        public string HtmlUrl { get; set; }
    }
}
