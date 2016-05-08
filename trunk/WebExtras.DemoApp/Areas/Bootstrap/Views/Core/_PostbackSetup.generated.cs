﻿
#pragma warning disable 1591
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
    
    #line 3 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"
    using WebExtras.Core;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"
    using WebExtras.Mvc.Bootstrap;
    
    #line default
    #line hidden
    using WebExtras.Mvc.Bootstrap.v2;
    using WebExtras.Mvc.Core;
    
    #line 5 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"
    using WebExtras.Mvc.Html;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Bootstrap/Views/Core/_PostbackSetup.cshtml")]
    public partial class _Areas_Bootstrap_Views_Core__PostbackSetup_cshtml : System.Web.Mvc.WebViewPage<WebExtras.DemoApp.Models.Core.DatatablesViewModel>
    {
        public _Areas_Bootstrap_Views_Core__PostbackSetup_cshtml()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n");




WriteLiteral("\r\n<p>\r\n  Postbacks a way of adding additional filtering to our datatable results." +
" These are especially useful when implementing \r\n  a search functionality.\r\n</p>" +
"\r\n<div class=\"well\">\r\n  <h4>Creating the postbacks</h4>\r\n  Postbacks are created" +
" by instantiating the <strong>WebExtras.JQDataTables.PostBackItem</strong> class" +
". Postbacks are always created in the\r\n  HTTP POST handler of our search method." +
" Let\'s say that our post back handler entity class is as follows:\r\n  <pre><code>" +
"\r\n  <span class=\"comment\">// Note that this needs to be an entity class, i.e it " +
"must only contain .NET base types</span>\r\n  public class PostbacksSearchModel\r\n " +
" {\r\n    public string FirstColumn { get; set; }\r\n    public string SecondColumn " +
"{ get; set; }\r\n  }\r\n  </code></pre>\r\n  <pre><code>\r\n    <span class=\"comment\">//" +
" Let\'s create the postback entity model and populate with user inputs</span>\r\n  " +
"  PostbacksSearchModel postbacks = new PostbacksSearchModel\r\n    {\r\n      FirstC" +
"olumn = <span class=\"comment\">// Set this with form element value</span>\r\n      " +
"SecondColumn = <span class=\"comment\">// Set this with form element value</span>\r" +
"\n    }\r\n\r\n    <span class=\"comment\">// There are two ways of creating postbacks<" +
"/span>\r\n    <span class=\"comment\">// Method 1: Manually adding key value pairs</" +
"span>\r\n    List&lt;PostbackItem&gt; dtPostbacks = new List&lt;PostbackItem&gt;()" +
";\r\n    \r\n    if (!string.IsNullOrEmpty(postbacks.FirstColumn))\r\n      dtPostback" +
"s.Add(new PostbackItem(\"FirstColumn\", postbacks.FirstColumn));\r\n\r\n    if (!strin" +
"g.IsNullOrEmpty(postbacks.SecondColumn))\r\n      dtPostbacks.Add(new PostbackItem" +
"(\"SecondColumn\", postbacks.SecondColumn));\r\n\r\n    <span class=\"comment\">// This " +
"is a little tedious since we only want to add non null values to our postback</s" +
"pan>\r\n    <span class=\"comment\">// Method 2: Have the postbacks created for you " +
"from an object</span>\r\n    IEnumerable&lt;PostbackItem&gt; dtPostbacks = Postbac" +
"kItem.FromObject(postbacks);\r\n  </code></pre>\r\n  Note that the FromObject method" +
" will only look at the public properties of the given model and ignore any type\r" +
"\n  that is not a .NET base type\r\n</div>\r\n\r\n<div class=\"well\">\r\n  <h4>A slightly " +
"updated constructor definition for our datatable</h4>\r\n  Now that we have added " +
"some postbacks, we need to setup our datatable to be able to handle some postbac" +
"ks. So we have\r\n  a slightly modified constructor for our datatable\r\n  <pre><cod" +
"e>\r\n  Datatable dTable = new Datatable(\"postbacks-table\", dtSettings, null, <spa" +
"n class=\"highlight\">dtPostbacks</span>);    \r\n  </code></pre>\r\n  Notice that we " +
"are not passing in any datatable records. We are just leaving them as null.\r\n</d" +
"iv>\r\n\r\n<div class=\"well\">\r\n  <h4>That\'s the HTTP POST handler</h4>\r\n  <pre><code" +
">\r\n  public Datatable PostHandler(PostbacksSearchModel model)\r\n  {    \r\n    IEnu" +
"merable&lt;AOColumn&gt; dtColumns = new AOColumn[]\r\n    {\r\n      new AOColumn(\"F" +
"irst Column\"),\r\n      new AOColumn(\"Second Column\")\r\n    };\r\n\r\n    <span class=\"" +
"highlight\">IEnumerable&lt;PostbackItem&gt; dtPostbacks = PostbackItem.FromObject" +
"(model);</span>\r\n    DatatableSettings dtSettings = new DatatableSettings(\r\n    " +
"  5, \r\n      dtColumns,\r\n      new AASort(0, SortType.Ascending), \r\n      \"~/get" +
"postbackdata\", \r\n      \"searched/filtered records\", \r\n      \"150px\");\r\n    Datat" +
"able dTable = new Datatable(\"postbacks-table\", dtSettings, null, <span class=\"hi" +
"ghlight\">dtPostbacks</span>); \r\n  }\r\n  </code></pre>\r\n  You might wonder where t" +
"he search actually happens since it is not apparent from the code. You are\r\n  ri" +
"ght, the search is not really happening here. This method only creates the skele" +
"ton for the view to be displayed to the user.\r\n</div>\r\n\r\n<div class=\"well\">\r\n  <" +
"h4>An AJAX handler does the grunt work</h4>\r\n  In the HTTP POST handler we have " +
"said that we want the AJAX handling to be done at the URL: <span class=\"highligh" +
"t\">\"~/getpostbackdata\"</span>.\r\n  So let\'s now create this AJAX handler. This is" +
" where the grunt work of actually filtering/searching happens...\r\n  <pre><code>\r" +
"\n  public DatatableRecords GetPostbackData(DatatableFilters filters, PostbacksSe" +
"archModel postbacks)\r\n  {\r\n    string[][] dtData = new string[][]\r\n    {\r\n      " +
"new string[] { \"first column row 1\", \"second column row 1\" },    \r\n      new str" +
"ing[] { \"first column row 2\", \"second column row 2\" },\r\n      new string[] { \"fi" +
"rst column row 3\", \"second column row 3\" },\r\n      new string[] { \"first column " +
"row 4\", \"second column row 4\" }\r\n    };\r\n\r\n    <span class=\"comment\">// Here is " +
"our searcher logic</span>\r\n    <span class=\"comment\">// You can hook in you sear" +
"ch/filter business logic here</span>\r\n    if (!string.IsNullOrEmpty(postbacks.Fi" +
"rstColumn))\r\n      dtData = dtData.Where(f => f[0].ContainsIgnoreCase(postbacks." +
"FirstColumn));\r\n    if (!string.IsNullOrEmpty(postbacks.SecondColumn))\r\n      dt" +
"Data = dtData.Where(f => f[1].ContainsIgnoreCase(postbacks.SecondColumn));\r\n\r\n  " +
"  DatatableRecords dtRecords = new DatatableRecords\r\n    {\r\n      sEcho = filter" +
"s.sEcho,\r\n      iTotalRecords = dtData.Count(),\r\n      iTotalDisplayRecords = dt" +
"Data.Count(),\r\n      aaData = dtData\r\n    };\r\n\r\n    return dtRecords;\r\n  }\r\n  </" +
"code></pre>\r\n</div>\r\n\r\n<div class=\"well\">\r\n  <h4>The default table</h4>\r\n  <p>\r\n" +
"    We will be searching records based on this table\r\n  </p>\r\n  <div class=\"outp" +
"ut\">\r\n    ");


            
            #line 126 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"
Write(Html.Partial(MVC.Shared.Views._Datatable, Model.Table));

            
            #line default
            #line hidden
WriteLiteral("\r\n  </div>\r\n</div>\r\n\r\n<div class=\"well\">\r\n  <h4>Go ahead try it yourself</h4>\r\n");


            
            #line 132 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"
   using (Html.BeginForm(MVC.Bootstrap.Core.Datatables(), FormMethod.Post, new { @class = "form-horizontal" }))
  { 

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"control-group\">\r\n      ");


            
            #line 135 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"
 Write(Html.LabelFor(f => f.PostbackFormFields.FirstColumn, new { @class = "control-label" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n      <div class=\"controls\">\r\n        ");


            
            #line 137 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"
   Write(Html.TextBoxFor(f => f.PostbackFormFields.FirstColumn));

            
            #line default
            #line hidden
WriteLiteral("\r\n      </div>\r\n    </div>\r\n");


            
            #line 140 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div class=\"control-group\">\r\n      ");


            
            #line 142 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"
 Write(Html.LabelFor(f => f.PostbackFormFields.SecondColumn, new { @class = "control-label" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n      <div class=\"controls\">\r\n        ");


            
            #line 144 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"
   Write(Html.TextBoxFor(f => f.PostbackFormFields.SecondColumn));

            
            #line default
            #line hidden
WriteLiteral("\r\n      </div>\r\n    </div>\r\n");


            
            #line 147 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div class=\"control-group\">\r\n      <div class=\"controls\">\r\n        ");


            
            #line 150 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"
   Write(Html.Button(EButton.Submit, "Submit").AsButton(EBootstrapButton.Primary));

            
            #line default
            #line hidden
WriteLiteral("\r\n      </div>\r\n    </div>\r\n");


            
            #line 153 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"
    
    
            
            #line default
            #line hidden
            
            #line 154 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"
Write(Html.HiddenFor(f => f.DisplayMode));

            
            #line default
            #line hidden
            
            #line 154 "..\..\Areas\Bootstrap\Views\Core\_PostbackSetup.cshtml"
                                       
  }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");


        }
    }
}
#pragma warning restore 1591
