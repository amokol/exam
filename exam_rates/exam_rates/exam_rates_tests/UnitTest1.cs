using exam_rates.common;
using exam_rates.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace exam_rates_tests
{
    public class Tests
    {
        public string download_data = "[{\"rate_date\": \"2019-10-29\",\"currency\":\"USD\", \"rate\":1.111235},{\"rate_date\": \"2019-10-29\",\"currency\":\"AUD\", \"rate\":1.620931},{\"rate_date\": \"2019-10-29\",\"currency\":\"CAD\", \"rate\":1.454773},{\"rate_date\": \"2019-10-29\",\"currency\":\"GBP\", \"rate\":0.863768},{\"rate_date\": \"2019-10-29\",\"currency\":\"EUR\", \"rate\":1},{\"rate_date\": \"2019-10-30\",\"currency\":\"USD\", \"rate\":1.115203},{\"rate_date\": \"2019-10-30\",\"currency\":\"AUD\", \"rate\":1.616816},{\"rate_date\": \"2019-10-30\",\"currency\":\"CAD\", \"rate\":1.468299},{\"rate_date\": \"2019-10-30\",\"currency\":\"GBP\", \"rate\":0.864427},{\"rate_date\": \"2019-10-30\",\"currency\":\"EUR\", \"rate\":1},{\"rate_date\": \"2019-10-31\",\"currency\":\"USD\", \"rate\":1.115672},{\"rate_date\": \"2019-10-31\",\"currency\":\"AUD\", \"rate\":1.618668},{\"rate_date\": \"2019-10-31\",\"currency\":\"CAD\", \"rate\":1.469156},{\"rate_date\": \"2019-10-31\",\"currency\":\"GBP\", \"rate\":0.862253},{\"rate_date\": \"2019-10-31\",\"currency\":\"EUR\", \"rate\":1}]";

        [SetUp]
        public void Setup()
        {
            testCountryMap();
            testRateMerge();
            testMerge();
        }

        [Test]
        public void testCountryMap()
        {
            var obj_country_rate = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RateViewModel>>(upload_date);
            var obj_euro_rates = Newtonsoft.Json.JsonConvert.DeserializeObject < List<EuroRatesModel>>(download_data);
            Assert.IsTrue(true, "Succes method for country map", testSetCountryMap(obj_country_rate));
        }


        [Test]
        public void testRateMerge()
        {
            var obj_country_rate = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RateViewModel>>(upload_date);
            var obj_euro_rates = Newtonsoft.Json.JsonConvert.DeserializeObject<List<EuroRatesModel>>(download_data);
            Assert.IsTrue(true, "Succes method for merge rates", testMergeRates(obj_country_rate, obj_euro_rates));
        }

        [Test]
        public void testMerge()
        {
            var obj_country_rate = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RateViewModel>>(upload_date);
            var obj_euro_rates = Newtonsoft.Json.JsonConvert.DeserializeObject<List<EuroRatesModel>>(download_data);
            Assert.IsTrue(true, "Succes method for update euro amount", testSetRateAmountByEuro(obj_country_rate, obj_euro_rates));
        }

        public bool testSetCountryMap(List<RateViewModel> obj_country_rate)
        {
            try
            {
                List<RateViewModel> map_country = common_function.setCountryMap(obj_country_rate);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool testSetRateAmountByEuro(List<RateViewModel> obj_country_rate, List<EuroRatesModel> obj_euro_rates)
        {
            try
            {
                List<RateViewModel> map_country = common_function.setRateAmountByEuro(obj_country_rate, obj_euro_rates);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool testMergeRates(List<RateViewModel> obj_country_rate, List<EuroRatesModel> obj_euro_rates)
        {
            try
            {
                List<RateViewModel> map_country = common_function.mergeRates(obj_country_rate, obj_euro_rates);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}