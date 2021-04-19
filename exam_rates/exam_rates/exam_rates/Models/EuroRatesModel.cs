using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam_rates.Models
{
    public class EuroRatesModel
    {
        public string rate_date { get; set; }
        public string currency { get; set; }
        public decimal rate { get; set; }
    }
}
