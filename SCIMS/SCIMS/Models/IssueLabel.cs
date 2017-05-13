using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIMS.Models
{
    public class IssueLabel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        private string Color { get; set; }
    }
}
