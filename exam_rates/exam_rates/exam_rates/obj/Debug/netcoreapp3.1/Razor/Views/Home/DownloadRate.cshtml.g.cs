#pragma checksum "C:\Users\Anjo\Desktop\exam_wesource\exam_rates\exam_rates\Views\Home\DownloadRate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c54b8c575d728cbc551194d3d41d2fd6865ea4f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DownloadRate), @"mvc.1.0.view", @"/Views/Home/DownloadRate.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Anjo\Desktop\exam_wesource\exam_rates\exam_rates\Views\_ViewImports.cshtml"
using exam_rates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anjo\Desktop\exam_wesource\exam_rates\exam_rates\Views\_ViewImports.cshtml"
using exam_rates.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c54b8c575d728cbc551194d3d41d2fd6865ea4f3", @"/Views/Home/DownloadRate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2340b97de8cd1f6c31aeebe45fe2e3e9aac85e4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DownloadRate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Anjo\Desktop\exam_wesource\exam_rates\exam_rates\Views\Home\DownloadRate.cshtml"
  
    ViewData["Title"] = "Download Rates Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>

    var date_day = 0;
    var concat_rate_values = """";
    var date_val = """";

    function downloadRates() {

        var access_key = ""3585214882123cda7f850a179d7efa41"";
        var base = ""EUR"";
        date_day = 1;
        concat_rate_values = """";
        $('#tbl_eur_rates tbody').empty();
        while (date_day < 32)
        {
            if (date_day < 10)
            {
                date_val = ""2019-10-0"" + date_day;
            }
            else
            {
                date_val = ""2019-10-"" + date_day;
            }
            var url_rates = ""http://data.fixer.io/api/"" + date_val + ""?access_key="" + access_key + ""&base="" + base + ""&symbols=USD,AUD,CAD,GBP,EUR"";
            $.ajax(
                {
                    url: url_rates,
                    success: function (data) {
                        setRates(data);
                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        conso");
            WriteLiteral(@"le.log(XMLHttpRequest);
                        console.log(textStatus);
                        console.log(errorThrown);

                    }
                }
            );
            
            date_day = date_day + 1;
        }
        
        
    }

    function setRates(data, date_rate)
    {
        var date_reponse = """";
        $.each(data, function (key, element) {

            if (key === ""date"")
            {
                date_reponse = element;
            }
            if (key == ""rates"")
            {
                $.each(element, function (key2, element2) {
                    $('#tbl_eur_rates tbody').append(
                        '<tr><td>' + date_reponse +
                        '</td><td>EUR</td><td>' + key2 +
                        '</td><td>' + element2 +
                        '</td></tr>'
                    );
                    if (concat_rate_values == """")
                    {
                        concat_rate_values = '{""rate");
            WriteLiteral(@"_date"": ""' + date_reponse + '"",""currency"":""' + key2 + '"", ""rate"":' + element2+'}';
                    }
                    else
                    {
                        concat_rate_values = concat_rate_values + ',{""rate_date"": ""' + date_reponse + '"",""currency"":""' + key2 + '"", ""rate"":' + element2 + '}';
                    }
                });
                $(""#download_rates"").val('[' + concat_rate_values + ']');
            }
        });
    }
</script>
<input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 2604, "\"", 2612, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""download_rates"" />
<div class=""text-left"">
    <div class=""form-row"">
        <div class=""col-4"">
            <div class=""buttons"">
                <div class=""download-button"">
                    <input type=""button"" id=""btn_submit"" class=""btn btn-info"" value=""Download Rates"" onclick=""downloadRates();"" />
                </div>
            </div>
        </div>
    </div>
    <table class=""table"" id=""tbl_eur_rates"">
        <thead>
            <tr>
                <th scope=""col"">Date</th>
                <th scope=""col"">Base</th>
                <th scope=""col"">Country</th>
                <th scope=""col"">Rate</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
