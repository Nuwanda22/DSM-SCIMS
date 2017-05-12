using SCIMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCIMS.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SidePage : ContentPage
    {
        public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

        public static OptionMenuItem[] ListViewItems =
        {
            new OptionMenuItem { Name = "Home", Source = ImageSource.FromFile("ic_home.png"), Page = typeof(HomePage) },
            new OptionMenuItem { Name = "Issues", Source = ImageSource.FromFile("ic_error.png"), Page = typeof(IssuesPage) },
            new OptionMenuItem { Name = "Bug Report", Source = ImageSource.FromFile("ic_bug_report.png"), Page = typeof(BugReportPage) }
        };

        public SidePage()
        {
            InitializeComponent();
        }
        
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;

            if(e.SelectedItem != null)
            {
                ItemSelected?.Invoke(this, e);
            }
        }
    }
}
