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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Core/_JQPlotAjaxData.cshtml")]
    public partial class _Views_Core__JQPlotAjaxData_cshtml : System.Web.Mvc.WebViewPage<WebExtras.JQPlot.JQPlotChartBase>
    {
        public _Views_Core__JQPlotAjaxData_cshtml()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n<div class=\"well ui-well\">\r\n  <h4>Specifying the URL</h4>\r\n  <p>JQPlot provides" +
" you a shorthand to specify the URL to fetch data from by simply setting the cha" +
"rt data to the URL</p>\r\n  <pre><code>\r\n    JQPlotChartBase chart = new JQPlotCha" +
"rtBase\r\n    {\r\n      chartData = \"/url_to_fetch_from\",\r\n      chartOptions = opt" +
"ions\r\n    };\r\n  </code></pre>\r\n</div>\r\n\r\n<div class=\"well ui-well\">\r\n  <h4>Your " +
"AJAX data returning controller action</h4>\r\n  <pre><code>\r\n    public virtual Ac" +
"tionResult GetJQPlotData()\r\n    {\r\n      List&lt;double[][]&gt; data = new List&" +
"lt;double[][]&gt; { m_graphSampleData };\r\n\r\n      return new JsonNetResult(data," +
" JsonRequestBehavior.AllowGet);\r\n    }\r\n  </code></pre>\r\n</div>\r\n\r\n<div class=\"w" +
"ell ui-well\">\r\n  <h4>Then in your HTML...</h4>\r\n  <p>Unfortunately, since AJAX r" +
"endering is normally done via a JavaScript function, WebExtras can not provide a" +
" simple\r\n    way of creating this in C# since you may not know the function name" +
" beforehand.\r\n  </p>\r\n  <p>Therefore, you must configure it in your HTML page. T" +
"he graph below uses the following JavaScript snippet to render</p>\r\n  <pre><code" +
">\r\n    $(document).ready(function () {\r\n\r\n      var ajaxDataRenderer = function(" +
"url, plot, rendererOptions)\r\n      {\r\n        var retVal = null;\r\n\r\n        $.aj" +
"ax({\r\n          <span class=\"comment\">// have to use synchronous here, else the " +
"function </span>\r\n          <span class=\"comment\">// will return before the data" +
" is fetched</span>\r\n          async: false,\r\n          url: url,\r\n          data" +
"Type:\"json\",\r\n          success: function(data) {\r\n            retVal = data;\r\n " +
"         }\r\n        });\r\n        return retVal;\r\n      };\r\n\r\n      var options =" +
" ");


WriteLiteral("@Html.Raw(Model.chartOptions.ToString());\r\n      options.dataRenderer = ajaxDataR" +
"enderer;\r\n\r\n      $.jqplot(\'ajax-graph\', \'");


WriteLiteral(@"@Model.chartData.ToString()', options);    <span class=""comment"">// Notice how chart data is rendered as a string</span>
    });
  </code></pre>
</div>

<div class=""well ui-well"">
  <h4>AJAX powered output...</h4>
  <div class=""content"">
    <div id=""ajax-graph"" class=""graph graph-large"">
    </div>
    <br />
    Required Plugins:<br />
    <ul>
      <li>jqplot.json2.min.js</li>
      <li>jqplot.canvasTextRenderer.min.js</li>
      <li>jqplot.canvasAxisTickRenderer.min.js</li>
      <li>jqplot.categoryAxisRenderer.min.js</li>
      <li>jqplot.barRenderer.min.js</li>
    </ul>
  </div>
  <script type=""text/javascript"">
    $(document).ready(function () {

      var ajaxDataRenderer = function(url, plot, rendererOptions)
      {
        var retVal = null;

        $.ajax({
          // have to use synchronous here, else the function 
          // will return before the data is fetched
          async: false,
          url: url,
          dataType:""json"",
          success: function(data) {
            retVal = data;
          }
        });
        return retVal;
      };

      var options = ");


            
            #line 96 "..\..\Views\Core\_JQPlotAjaxData.cshtml"
               Write(Html.Raw(Model.chartOptions.ToString()));

            
            #line default
            #line hidden
WriteLiteral(";\r\n      options.dataRenderer = ajaxDataRenderer;\r\n\r\n      $.jqplot(\'ajax-graph\'," +
" \'");


            
            #line 99 "..\..\Views\Core\_JQPlotAjaxData.cshtml"
                         Write(Model.chartData.ToString());

            
            #line default
            #line hidden
WriteLiteral("\', options);\r\n    });\r\n  </script>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
