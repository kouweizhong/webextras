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
    using WebExtras.Core;
    using WebExtras.Mvc.Bootstrap;
    using WebExtras.Mvc.Bootstrap.v3;
    using WebExtras.Mvc.Core;
    using WebExtras.Mvc.Html;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Bootstrap3/Views/Mvc/CoreForm.cshtml")]
    public partial class _Areas_Bootstrap3_Views_Mvc_CoreForm_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Bootstrap3_Views_Mvc_CoreForm_cshtml()
        {
        }
        public override void Execute()
        {

            
            #line 1 "..\..\Areas\Bootstrap3\Views\Mvc\CoreForm.cshtml"
  
  ViewBag.Title = "Mvc Form Helper Extensions";


            
            #line default
            #line hidden
WriteLiteral(@"
<h3 class=""keep-center"">Mvc Form Helper Extensions</h3>

<div class=""row"">
  <div class=""col-md-6"">
    <div class=""row"">
      <div class=""col-md-3"">
        <strong>Assembly</strong>
      </div>
      <div class=""col-md-4"">
        WebExtras.Mvc.dll
      </div>
    </div>
    <div class=""row"">
      <div class=""col-md-3"">
        <strong>Namespace</strong>
      </div>
      <div class=""col-md-4"">
        WebExtras.Mvc.Core
      </div>
    </div>
  </div>
  <div class=""col-md-6"">
    <div class=""col-md-3"">
      <strong>Dependancies</strong>
    </div>
    <div class=""col-md-7"">
      <ul class=""dependancies"">
        <li>Appropriate third party libraries</li>
        <li>webextras.bootstrap3.css</li>
      </ul>
    </div>
  </div>
</div>

<div class=""well"">
  <h4>Buttons</h4>
  <p>Markup</p>
  <pre><code>
  ");


WriteLiteral("@Html.Button(EButton.Regular, \"Regular button\")\r\n  </code></pre>\r\n  <p>Output</p>" +
"\r\n  <div class=\"content\">\r\n    ");


            
            #line 47 "..\..\Areas\Bootstrap3\Views\Mvc\CoreForm.cshtml"
Write(Html.Button(EButton.Regular, "Regular Button"));

            
            #line default
            #line hidden
WriteLiteral("\r\n  </div>\r\n  <p>All available extensions</p>\r\n  <pre><code>\r\n  ");


WriteLiteral("@Html.Button(type, text, htmlAttributes)                     <span class=\"comment" +
"\">// type - can be Regular, Submit or Reset</span>\r\n  ");


WriteLiteral("@Html.Button(type, text, onclick, htmlAttributes)            <span class=\"comment" +
"\">// onclick - javascript onclick event</span>\r\n  </code></pre>\r\n</div>\r\n\r\n<div " +
"class=\"well\">\r\n  <h4>Checkbox Group</h4>\r\n  <p>Markup</p>\r\n  <pre><code>\r\n  ");


WriteLiteral(@"@Html.CheckBoxGroup(""my checkbox group"", new CheckBox[] {
    new CheckBox(""checkbox 1"", ""1""),
    new CheckBox(""checkbox 2"", ""2""),
    new CheckBox(""checkbox 3"", ""3""),
    new CheckBox(""checkbox 4"", ""4""),
    new CheckBox(""checkbox 5"", ""5""),                  <span class=""comment"">// Note that by default 5 checkboxes will be shown per line</span>
    new CheckBox(""checkbox 6"", ""6""),
    new CheckBox(""checkbox 7"", ""7""),
    new CheckBox(""checkbox 8"", ""8""),
    new CheckBox(""checkbox 9"", ""9""),
    new CheckBox(""checkbox 10"", ""10""),
  })
  </code></pre>
  <p>Output</p>
  <div class=""content"">
    <span class=""comment"">// The rendered table will have a CSS class <span class=""highlight"">.checkbox-group</span> applied 
      which you can use to control styling</span>
    <br />
    <br />
    ");


            
            #line 79 "..\..\Areas\Bootstrap3\Views\Mvc\CoreForm.cshtml"
Write(Html.CheckBoxGroup("my checkbox group", new CheckBox[] {
      new CheckBox("checkbox 1", "1"),
      new CheckBox("checkbox 2", "2"),
      new CheckBox("checkbox 3", "3"),
      new CheckBox("checkbox 4", "4"),
      new CheckBox("checkbox 5", "5"),
      new CheckBox("checkbox 6", "6"),
      new CheckBox("checkbox 7", "7"),
      new CheckBox("checkbox 8", "8"),
      new CheckBox("checkbox 9", "9"),
      new CheckBox("checkbox 10", "10"),
    }));

            
            #line default
            #line hidden
WriteLiteral("\r\n  </div>\r\n  <p>All available extensions</p>\r\n  <pre><code>\r\n  ");


WriteLiteral("@Html.CheckBoxGroup(groupname, checkboxes, htmlAttributes)\r\n  ");


WriteLiteral("@Html.CheckBoxGroup(groupname, checkboxes, boxesPerLine, htmlAttributes)\r\n  </cod" +
"e></pre>\r\n</div>\r\n\r\n<div class=\"well\">\r\n  <h4>RadioButton Group</h4>\r\n  <p>Marku" +
"p</p>\r\n  <pre><code>\r\n  ");


WriteLiteral(@"@Html.RadioButtonGroup(""my radio group"", new RadioButton[] {
    new RadioButton(""radiobutton 1"", ""1""),
    new RadioButton(""radiobutton 2"", ""2""),
    new RadioButton(""radiobutton 3"", ""3""),
    new RadioButton(""radiobutton 4"", ""4""),
    new RadioButton(""radiobutton 5"", ""5""),                  <span class=""comment"">// Note that by default 5 radio buttons will be shown per line</span>
    new RadioButton(""radiobutton 6"", ""6""),
    new RadioButton(""radiobutton 7"", ""7""),
    new RadioButton(""radiobutton 8"", ""8""),
    new RadioButton(""radiobutton 9"", ""9""),
    new RadioButton(""radiobutton 10"", ""10""),
  })
  </code></pre>
  <p>Output</p>
  <div class=""content"">
    <span class=""comment"">// The rendered table will have a CSS class <span class=""highlight"">.radiobutton-group</span> applied 
      which you can use to control styling</span>
    <br />
    <br />
    ");


            
            #line 122 "..\..\Areas\Bootstrap3\Views\Mvc\CoreForm.cshtml"
Write(Html.RadioButtonGroup("my radio group", new RadioButton[] {
      new RadioButton("radiobutton 1", "1"),
      new RadioButton("radiobutton 2", "2"),
      new RadioButton("radiobutton 3", "3"),
      new RadioButton("radiobutton 4", "4"),
      new RadioButton("radiobutton 5", "5"),
      new RadioButton("radiobutton 6", "6"),
      new RadioButton("radiobutton 7", "7"),
      new RadioButton("radiobutton 8", "8"),
      new RadioButton("radiobutton 9", "9"),
      new RadioButton("radiobutton 10", "10"),
    }));

            
            #line default
            #line hidden
WriteLiteral("\r\n  </div>\r\n  <p>All available extensions</p>\r\n  <pre><code>\r\n  ");


WriteLiteral("@Html.RadioButtonGroup(groupname, radiobuttons, htmlAttributes)\r\n  ");


WriteLiteral("@Html.RadioButtonGroup(groupname, radiobuttons, buttonsPerLine, htmlAttributes)\r\n" +
"  </code></pre>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
