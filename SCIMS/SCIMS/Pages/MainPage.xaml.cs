using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using SCIMS.Models;

namespace SCIMS.Pages
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SidePage_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as OptionMenuItem;

            var page = Activator.CreateInstance(item.Page) as Page;
            Detail = new NavigationPage(page);
            
            IsPresented = false;
        }
    }
}
