using exam_rates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam_rates.common
{
    public static class common_function
    {
        public static List<RateViewModel> setCountryMap(List<RateViewModel> rate_list_items)
        {
            var map_result = rate_list_items.Join(common_labels.country_map_list,
                                                       r => r.country,
                                                       c => c.country,
                                                        (r, c) => new RateViewModel
                                                        {
                                                            rate_date = r.rate_date,
                                                            currency = r.currency,
                                                            amount = r.amount,
                                                            country = r.country,
                                                            amount_eur = r.amount_eur,
                                                            country_group = c.map_code
                                                        });
            return map_result.Cast<RateViewModel>().ToList();
        }

        public static List<RateViewModel> setRateAmountByEuro(List<RateViewModel> rate_list_items, List<EuroRatesModel> euro_rates_lists)
        {
            var map_result = rate_list_items.Join(euro_rates_lists,
                                                       r => new { r.currency, r.rate_date },
                                                       c => new { c.currency, c.rate_date },
                                                        (r, c) => new RateViewModel
                                                        {
                                                            rate_date = r.rate_date,
                                                            currency = r.currency,
                                                            amount = r.amount,
                                                            country = r.country,
                                                            amount_eur = r.amount / c.rate,
                                                            country_group = r.country_group
                                                        });
            return map_result.Cast<RateViewModel>().ToList();
        }

        public static List<RateViewModel> mergeRates(List<RateViewModel> rate_list_items, List<EuroRatesModel> euro_rates_lists)
        {
            List<RateViewModel> merged_rate_lists = new List<RateViewModel>();
            merged_rate_lists = setRateAmountByEuro(rate_list_items, euro_rates_lists);
            merged_rate_lists = setCountryMap(merged_rate_lists);
            return merged_rate_lists;
        }

    }
}
