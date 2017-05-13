using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace SCIMS.Models
{
    public class Issue
    {
        public string Url { get; set; }

        [JsonProperty(PropertyName = "comments_url")]
        public string CommentsUrl { get; set; }

        [JsonProperty(PropertyName = "html_url")]
        public string HtmlUrl { get; set; }

        public int Id { get; set; }

        public int Number { get; set; }

        public string Title { get; set; }

        public User User { get; set; }

        public List<IssueLabel> Labels { get; set; }

        public string State { get; set; }

        //public bool Locked { get; set; }

        public int Comments { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "closed_at")]
        public DateTime? ClosedAt { get; set; }

        public string Body { get; set; }

        public string Description { get { return $"#{Number} {Title}"; } }
    }
}
