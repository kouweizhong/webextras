﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Core/_LineGraph.cshtml")]
    public partial class _Views_Core__LineGraph_cshtml : System.Web.Mvc.WebViewPage<WebExtras.JQFlot.FlotChart>
    {
        public _Views_Core__LineGraph_cshtml()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n<div class=\"well ui-well\">\r\n  <h4>Creating the Flot options</h4>\r\n  Flot graph " +
"options are created by instantiating the <strong>WebExtras.JQFlot.FlotOptions</s" +
"trong> class.\r\n  <pre><code>\r\n  FlotOptions options = new FlotOptions\r\n  {\r\n    " +
"xaxis = new AxisOptions(),                  <span class=\"comment\">// Initialise " +
"X axis</span>\r\n    yaxis = new AxisOptions(),                  <span class=\"comm" +
"ent\">// Initialise Y axis</span>\r\n    grid = new GridOptions { borderWidth = 1 }" +
"  <span class=\"comment\">// Initialise grid. By default no grid is shown</span>\r\n" +
"  };\r\n  </code></pre>\r\n</div>\r\n\r\n<div class=\"well ui-well\">\r\n  <h4>Creating the " +
"graph data</h4>\r\n  Flot uses a 2 dimensional numeric array for data. This can be" +
" of any numeric type <strong>int, decimal, float or\r\n  double</strong>. In order" +
" to compensate for numerals WebExtras uses the biggest of the numeral types prov" +
"ided by .NET - \r\n  <strong>double</strong>\r\n  <pre><code>\r\n  List&lt;double[]&gt" +
"; graphData = new List&lt;double[]&gt;();\r\n  \r\n  <span class=\"comment\">// Notice" +
" that each individual array added to the \'graphData\' variable has 2 columns</spa" +
"n>\r\n  <span class=\"comment\">// The first column is your X co-ordinate and the se" +
"cond is your Y co-ordinate</span>\r\n\r\n  graphData.Add(new double[] { 1, 5 });    " +
"                        \r\n  graphData.Add(new double[] { 2, 10 });\r\n\r\n  <span cl" +
"ass=\"comment\">// ... and so on</span>\r\n  </code></pre>\r\n</div>\r\n\r\n<div class=\"we" +
"ll ui-well\">\r\n  <h4>Creating the Flot series to be plotted</h4>\r\n  A Flot series" +
" is created by instantiating the <strong>WebExtras.JQFlot.FlotSeries</strong> cl" +
"ass\r\n  <pre><code>\r\n  FlotSeries linegraph = new FlotSeries\r\n  {\r\n    label = \"S" +
"ample Line Graph\",\r\n    data = graphData,\r\n    lines = new LineGraph { show = tr" +
"ue }                 <span class=\"comment\">// This will denote that you want a L" +
"ine graph</span>\r\n  };\r\n  </code></pre>\r\n</div>\r\n\r\n<div class=\"well ui-well\">\r\n " +
" <h4>Creating the Flot Chart</h4>\r\n  All the things we have done so far now get " +
"bundled into a Flot chart by instantiating the <strong>WebExtras.JQFlot.FlotChar" +
"t</strong> object.\r\n  <pre><code>\r\n  <span class=\"comment\">// Notice that the \'c" +
"hartSeries\' property is an array, giving the flexibility of rendering multiple s" +
"eries in the same graph</span>\r\n  FlotChart chart = new FlotChart\r\n  {\r\n    char" +
"tOptions = options,\r\n    chartSeries = new FlotSeries[] { linegraph }          \r" +
"\n  };\r\n  </code></pre>\r\n</div>\r\n\r\n<div class=\"well ui-well\">\r\n  <h4>Now in your " +
"HTML</h4>\r\n  Now that all C# bindings are done, it is time to render our graph. " +
"This can be done with a little bit of Javascript.\r\n  <pre><code>\r\n  ");


WriteLiteral("@model WebExtras.JQFlot.FlotChart\r\n  ....\r\n    ....\r\n    ....\r\n  <span class=\"com" +
"ment\">// Don\'t forget the square brackets when adding the graph serie</span>  \r\n" +
"  $.plot($(\'#line-graph\'), <strong class=\"highlight\">[</strong>");


WriteLiteral("@Html.Raw(Model.chartSeries[0].ToString())<strong class=\"highlight\">]</strong>, ");


WriteLiteral(@"@Html.Raw(Model.chartOptions.ToString()));
  </code></pre>
</div>

<div class=""well ui-well"">
  <h4>And finally the output...</h4>
  <div class=""content"">    
    <div id=""line-graph"" class=""graph"">
    </div>
  </div>
  <script type=""text/javascript"">
    $(document).ready(function () {
      $.plot($('#line-graph'), [");


            
            #line 81 "..\..\Views\Core\_LineGraph.cshtml"
                           Write(Html.Raw(Model.chartSeries[0].ToString()));

            
            #line default
            #line hidden
WriteLiteral("], ");


            
            #line 81 "..\..\Views\Core\_LineGraph.cshtml"
                                                                        Write(Html.Raw(Model.chartOptions.ToString()));

            
            #line default
            #line hidden
WriteLiteral(");    \r\n    });\r\n  </script>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
