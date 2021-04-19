using exam_rates.common;
using exam_rates.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace exam_rates.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult UploadFiles()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Uploader(IList<IFormFile> files)
        {
            List<RateViewModel> csv_data = new List<RateViewModel>();
            foreach (IFormFile source in files)
            {
                using (StreamReader csv_reader = new StreamReader(source.OpenReadStream()))
                {
                    csv_reader.ReadLine();
                    while (csv_reader.Peek() != -1)
                    {
                        string csv_data_raw = csv_reader.ReadLine();
                        if (!string.IsNullOrEmpty(csv_data_raw.Trim()))
                        {
                            RateViewModel rate_view = new RateViewModel();
                            string[] csv_arr = csv_data_raw.Split(',');
                            rate_view.rate_date = csv_arr[0];
                            rate_view.country = csv_arr[1];
                            rate_view.currency = csv_arr[2];
                            rate_view.amount = decimal.Parse(csv_arr[3]);
                            csv_data.Add(rate_view);
                        }
                    }
                }
            }
            var json = JsonSerializer.Serialize(csv_data);
            return Json(json);
        }

        [HttpPost]
        public JsonResult MergeData([FromBody] MergeModel merge_data_file)
        {
            var obj_country_rate = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RateViewModel>>(merge_data_file.country_rate);
            var obj_euro_rates = Newtonsoft.Json.JsonConvert.DeserializeObject<List<EuroRatesModel>>(merge_data_file.euro_rates);
            List<RateViewModel> merged_rate_lists = common_function.mergeRates(obj_country_rate, obj_euro_rates);
            return Json(JsonSerializer.Serialize(merged_rate_lists));
        }

    }
}
