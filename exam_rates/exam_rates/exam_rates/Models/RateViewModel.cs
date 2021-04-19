using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam_rates.Models
{
    public class RateViewModel
    {
        public string rate_date { get; set; }

        public string currency { get; set; }

        public decimal amount { get; set; }

        public string country { get; set; }

        public decimal amount_eur { get; set; }

        public string country_group { get; set; }
    }
}
