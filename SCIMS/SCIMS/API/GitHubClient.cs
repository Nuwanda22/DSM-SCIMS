using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

using SCIMS.Models;

namespace SCIMS.API
{
    public enum IssueState
    {
        Open, Closed, All
    }

    public class GitHubClient
    {
        private async Task<T> Download<T>(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "DSM-SCIMS-App");

                var jsonString = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<T>(jsonString);
            }
        }

        private string GetParameter(IssueState state, string labels)
        {
            var builder = new StringBuilder("?");

            builder.Append("state=" + state.ToString().ToLower());
            builder.Append(labels != null ? "&labels=" + labels : "");

            return builder.ToString();
        }

        public async Task<List<Issue>> DownloadIssueList(IssueState state, string labels)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "DSM-SCIMS-App");

                var jsonString = await client.GetStringAsync("https://api.github.com/repos/DSM-HS/StudentCouncil/issues" + GetParameter(state, labels));
                return JsonConvert.DeserializeObject<List<Issue>>(jsonString);
            }
        }
    }
}
