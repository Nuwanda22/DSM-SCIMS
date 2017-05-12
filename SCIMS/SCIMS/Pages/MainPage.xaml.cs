using SCIMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
            Detail = new NavigationPage((Page)Activator.CreateInstance(item.Page));
            IsPresented = false;
        }
    }
}
