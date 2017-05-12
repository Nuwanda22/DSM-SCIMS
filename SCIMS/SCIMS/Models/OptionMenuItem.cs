using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SCIMS.Models
{
    public class OptionMenuItem
    {
        public string Name { get; set; }

        public ImageSource Source { get; set; }

        public Type Page { get; set; }
    }
}
