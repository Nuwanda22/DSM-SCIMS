using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SCIMS.Views
{
    public enum IssueState
    {
        Open, Closed, All
    }

    public partial class IssuesListView : ListView
    {
        public static readonly BindableProperty StateProperty = BindableProperty.Create("State", typeof(IssueState), typeof(IssuesListView), default(IssueState));
        public static readonly BindableProperty LabelsProperty = BindableProperty.Create("Labels", typeof(string), typeof(IssuesListView), default(string));

        public IssueState State
        {
            get { return (IssueState)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }

        public string Labels
        {
            get { return (string)GetValue(LabelsProperty); }
            set { SetValue(LabelsProperty, value); }
        }

        public IssuesListView()
        {
            InitializeComponent();
        }

        private async Task Download()
        {
            using(HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "GitHub-Blog-App");

                await client.GetStringAsync(""); // TODO: 해라
            }
        }
    }
}
