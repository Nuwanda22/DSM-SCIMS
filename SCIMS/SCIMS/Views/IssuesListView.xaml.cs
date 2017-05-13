using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using SCIMS.API;
using System.ComponentModel;

namespace SCIMS.Views
{
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

            Device.BeginInvokeOnMainThread(async () =>
            {
                ItemsSource = await new GitHubClient().DownloadIssueList(State, Labels);
            });
        }
    }
}
