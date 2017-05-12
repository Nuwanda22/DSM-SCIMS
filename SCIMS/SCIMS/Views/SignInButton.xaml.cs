using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SCIMS.Views
{
    public partial class SignInButton : Grid
    {
        public event EventHandler Clicked;

        public SignInButton()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Clicked?.Invoke(this, e);
        }
    }
}
