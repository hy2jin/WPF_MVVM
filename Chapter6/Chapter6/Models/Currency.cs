using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.Models
{
    public class Currency
    {
        public string Title { get; set; }
        public decimal Rate { get; set; }

        public Currency(string title, decimal rate)
        {
            Title = title;
            Rate = rate;
        }
    }
}
