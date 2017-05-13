using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SCIMS.Models
{
    public class User
    {
        [JsonProperty(PropertyName = "login")]
        public string Username { get; set; }

        public int Id { get; set; }

        [JsonProperty(PropertyName = "avatar_url")]
        public string AvatarUrl { get; set; }

        public Uri AvatarImageUri { get { return new Uri(AvatarUrl); } }
       
        public string Url { get; set; }

        [JsonProperty(PropertyName = "html_url")]
        public string HtmlUrl { get; set; }
    }
}
