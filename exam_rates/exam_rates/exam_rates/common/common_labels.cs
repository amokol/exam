using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam_rates.common
{
    public static class common_labels
    {
        public static string country_map_eu = "EU";
        public static string country_map_row = "ROW";
        public static List<country_map> country_map_list = new List<country_map> { new country_map { country = "Austria", map_code = country_map_eu},
                                                                                   new country_map { country = "Italy", map_code = country_map_eu},
                                                                                   new country_map { country = "Belgium", map_code = country_map_eu},
                                                                                   new country_map { country = "Latvia", map_code = country_map_eu},
                                                                                   new country_map { country = "Chile", map_code = country_map_row},
                                                                                   new country_map { country = "Qatar", map_code = country_map_row},
                                                                                   new country_map { country = "United Arab Emirates", map_code = country_map_row},
                                                                                   new country_map { country = "United States of America ", map_code = country_map_row},
                                                                                   new country_map { country = "United Kingdom", map_code = "United Kingdom"},
                                                                                   new country_map { country = "Australia", map_code = "Australia"},
                                                                                   new country_map { country = "South Africa", map_code = "South Africa"}
                                                                                 };

    }

    public class country_map
    {
        public string country { get; set; }
        public string map_code { get; set; }
    }
}
