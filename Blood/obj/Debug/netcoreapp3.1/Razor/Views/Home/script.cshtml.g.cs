#pragma checksum "C:\Users\RTAYONG\source\repos\Blood\Blood\Views\Home\script.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08a7b43388d3bcbd576d48917495fe218d158967"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_script), @"mvc.1.0.view", @"/Views/Home/script.cshtml")]
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
#line 1 "C:\Users\RTAYONG\source\repos\Blood\Blood\Views\_ViewImports.cshtml"
using Blood;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RTAYONG\source\repos\Blood\Blood\Views\_ViewImports.cshtml"
using Blood.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08a7b43388d3bcbd576d48917495fe218d158967", @"/Views/Home/script.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6ed02ef33b6964c3db1e0d36eef1922df6fdd0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_script : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
        window.onload = function () {

            var chart = new CanvasJS.Chart(""chartContainer"", {
                exportEnabled: true,
                animationEnabled: true,
                title: {
                    text: """"
                },
                legend: {
                    cursor: ""pointer"",
                    itemclick: explodePie
                },
                data: [{
                    type: ""pie"",
                    showInLegend: true,
                    toolTipContent: ""{name}: <strong>{y}%</strong>"",
                    indexLabel: ""{name} - {y}%"",
                    dataPoints: [
                        { y: 26, name: ""Inventory"", exploded: true },
                        { y: 20, name: ""Released"" },
                        { y: 5, name: ""Expired"" },
                        { y: 3, name: ""Transfused"" }
                    ]
                }]
            });
            chart.render();
        }

        function explodePie(e) {
 ");
            WriteLiteral(@"           if (typeof (e.dataSeries.dataPoints[e.dataPointIndex].exploded) === ""undefined"" || !e.dataSeries.dataPoints[e.dataPointIndex].exploded) {
                e.dataSeries.dataPoints[e.dataPointIndex].exploded = true;
            } else {
                e.dataSeries.dataPoints[e.dataPointIndex].exploded = false;
            }
            e.chart.render();

        }
</script>");
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