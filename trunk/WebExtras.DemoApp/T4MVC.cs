﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static class MVC
{
    static readonly BootstrapClass s_Bootstrap = new BootstrapClass();
    public static BootstrapClass Bootstrap { get { return s_Bootstrap; } }
    static readonly Bootstrap3Class s_Bootstrap3 = new Bootstrap3Class();
    public static Bootstrap3Class Bootstrap3 { get { return s_Bootstrap3; } }
    static readonly GumbyClass s_Gumby = new GumbyClass();
    public static GumbyClass Gumby { get { return s_Gumby; } }
    static readonly JQueryUIClass s_JQueryUI = new JQueryUIClass();
    public static JQueryUIClass JQueryUI { get { return s_JQueryUI; } }
    public static WebExtras.DemoApp.Controllers.AssetsController Assets = new WebExtras.DemoApp.Controllers.T4MVC_AssetsController();
    public static WebExtras.DemoApp.Controllers.FlavourController Flavour = new WebExtras.DemoApp.Controllers.T4MVC_FlavourController();
    public static T4MVC.CoreController Core = new T4MVC.CoreController();
    public static T4MVC.HomeController Home = new T4MVC.HomeController();
    public static T4MVC.MvcController Mvc = new T4MVC.MvcController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class BootstrapClass
    {
        public readonly string Name = "bootstrap";
        public WebExtras.DemoApp.Areas.Bootstrap.Controllers.CoreController Core = new WebExtras.DemoApp.Areas.Bootstrap.Controllers.T4MVC_CoreController();
        public WebExtras.DemoApp.Areas.Bootstrap.Controllers.HomeController Home = new WebExtras.DemoApp.Areas.Bootstrap.Controllers.T4MVC_HomeController();
        public WebExtras.DemoApp.Areas.Bootstrap.Controllers.MvcController Mvc = new WebExtras.DemoApp.Areas.Bootstrap.Controllers.T4MVC_MvcController();
        public T4MVC.Bootstrap.SharedController Shared = new T4MVC.Bootstrap.SharedController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Bootstrap3Class
    {
        public readonly string Name = "bootstrap3";
        public WebExtras.DemoApp.Areas.Bootstrap3.Controllers.CoreController Core = new WebExtras.DemoApp.Areas.Bootstrap3.Controllers.T4MVC_CoreController();
        public WebExtras.DemoApp.Areas.Bootstrap3.Controllers.HomeController Home = new WebExtras.DemoApp.Areas.Bootstrap3.Controllers.T4MVC_HomeController();
        public WebExtras.DemoApp.Areas.Bootstrap3.Controllers.MvcController Mvc = new WebExtras.DemoApp.Areas.Bootstrap3.Controllers.T4MVC_MvcController();
        public T4MVC.Bootstrap3.SharedController Shared = new T4MVC.Bootstrap3.SharedController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class GumbyClass
    {
        public readonly string Name = "gumby";
        public WebExtras.DemoApp.Areas.Gumby.Controllers.CoreController Core = new WebExtras.DemoApp.Areas.Gumby.Controllers.T4MVC_CoreController();
        public WebExtras.DemoApp.Areas.Gumby.Controllers.HomeController Home = new WebExtras.DemoApp.Areas.Gumby.Controllers.T4MVC_HomeController();
        public WebExtras.DemoApp.Areas.Gumby.Controllers.MvcController Mvc = new WebExtras.DemoApp.Areas.Gumby.Controllers.T4MVC_MvcController();
        public T4MVC.Gumby.SharedController Shared = new T4MVC.Gumby.SharedController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class JQueryUIClass
    {
        public readonly string Name = "jqueryui";
        public WebExtras.DemoApp.Areas.JQueryUI.Controllers.CoreController Core = new WebExtras.DemoApp.Areas.JQueryUI.Controllers.T4MVC_CoreController();
        public WebExtras.DemoApp.Areas.JQueryUI.Controllers.HomeController Home = new WebExtras.DemoApp.Areas.JQueryUI.Controllers.T4MVC_HomeController();
        public WebExtras.DemoApp.Areas.JQueryUI.Controllers.MvcController Mvc = new WebExtras.DemoApp.Areas.JQueryUI.Controllers.T4MVC_MvcController();
        public T4MVC.JQueryUI.SharedController Shared = new T4MVC.JQueryUI.SharedController();
    }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_System_Web_Mvc_ContentResult : System.Web.Mvc.ContentResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ContentResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_System_Web_Mvc_JsonResult : System.Web.Mvc.JsonResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_JsonResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_2_3_1_min_js = Url("bootstrap-2.3.1.min.js");
        public static readonly string bootstrap_3_0_0_min_js = Url("bootstrap-3.0.0.min.js");
        public static readonly string excanvas_min_js = Url("excanvas.min.js");
        public static readonly string gumby_2_5_6_min_js = Url("gumby-2.5.6.min.js");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class JQPlot {
            private const string URLPATH = "~/Scripts/JQPlot";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string jqplot_barRenderer_min_js = Url("jqplot.barRenderer.min.js");
            public static readonly string jqplot_canvasAxisLabelRenderer_min_js = Url("jqplot.canvasAxisLabelRenderer.min.js");
            public static readonly string jqplot_canvasAxisTickRenderer_min_js = Url("jqplot.canvasAxisTickRenderer.min.js");
            public static readonly string jqplot_canvasTextRenderer_min_js = Url("jqplot.canvasTextRenderer.min.js");
            public static readonly string jqplot_categoryAxisRenderer_min_js = Url("jqplot.categoryAxisRenderer.min.js");
            public static readonly string jqplot_cursor_min_js = Url("jqplot.cursor.min.js");
            public static readonly string jqplot_dateAxisRenderer_min_js = Url("jqplot.dateAxisRenderer.min.js");
            public static readonly string jqplot_highlighter_min_js = Url("jqplot.highlighter.min.js");
            public static readonly string jqplot_json2_min_js = Url("jqplot.json2.min.js");
            public static readonly string jqplot_min_js = Url("jqplot.min.js");
        }
    
        public static readonly string jquery_1_9_1_min_js = Url("jquery-1.9.1.min.js");
        public static readonly string jquery_ui_1_10_3_custom_min_js = Url("jquery-ui-1.10.3.custom.min.js");
        public static readonly string jquery_bootstrap_datetimepicker_min_js = Url("jquery.bootstrap.datetimepicker.min.js");
        public static readonly string jquery_bootstrap_hover_dropdown_min_js = Url("jquery.bootstrap.hover.dropdown.min.js");
        public static readonly string jquery_datatables_bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.datatables.bootstrap.min.js") ? Url("jquery.datatables.bootstrap.min.js") : Url("jquery.datatables.bootstrap.js");
                      
        public static readonly string jquery_datatables_bootstrap3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.datatables.bootstrap3.min.js") ? Url("jquery.datatables.bootstrap3.min.js") : Url("jquery.datatables.bootstrap3.js");
                      
        public static readonly string jquery_datatables_min_js = Url("jquery.datatables.min.js");
        public static readonly string jquery_flot_axislabels_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.flot.axislabels.min.js") ? Url("jquery.flot.axislabels.min.js") : Url("jquery.flot.axislabels.js");
                      
        public static readonly string jquery_flot_curvedlines_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.flot.curvedlines.min.js") ? Url("jquery.flot.curvedlines.min.js") : Url("jquery.flot.curvedlines.js");
                      
        public static readonly string jquery_flot_dashes_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.flot.dashes.min.js") ? Url("jquery.flot.dashes.min.js") : Url("jquery.flot.dashes.js");
                      
        public static readonly string jquery_flot_min_js = Url("jquery.flot.min.js");
        public static readonly string jquery_flot_pie_min_js = Url("jquery.flot.pie.min.js");
        public static readonly string jquery_flot_time_min_js = Url("jquery.flot.time.min.js");
        public static readonly string jquery_jScrollPane_2_0_0beta12_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.jScrollPane-2.0.0beta12.min.js") ? Url("jquery.jScrollPane-2.0.0beta12.min.js") : Url("jquery.jScrollPane-2.0.0beta12.js");
                      
        public static readonly string jquery_migrate_1_1_1_min_js = Url("jquery.migrate-1.1.1.min.js");
        public static readonly string jquery_mousewheel_3_0_6_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.mousewheel-3.0.6.min.js") ? Url("jquery.mousewheel-3.0.6.min.js") : Url("jquery.mousewheel-3.0.6.js");
                      
        public static readonly string jquery_mwheelIntent_1_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.mwheelIntent-1.2.min.js") ? Url("jquery.mwheelIntent-1.2.min.js") : Url("jquery.mwheelIntent-1.2.js");
                      
        public static readonly string jquery_ui_datetimepicker_1_4_4_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.datetimepicker-1.4.4.min.js") ? Url("jquery.ui.datetimepicker-1.4.4.min.js") : Url("jquery.ui.datetimepicker-1.4.4.js");
                      
        public static readonly string jquery_ui_menubar_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.menubar.min.js") ? Url("jquery.ui.menubar.min.js") : Url("jquery.ui.menubar.js");
                      
        public static readonly string modernizr_2_6_2_min_js = Url("modernizr-2.6.2.min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_2_3_1_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap-2.3.1.min.css") ? Url("bootstrap-2.3.1.min.css") : Url("bootstrap-2.3.1.css");
             
        public static readonly string bootstrap_3_0_0_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap-3.0.0.min.css") ? Url("bootstrap-3.0.0.min.css") : Url("bootstrap-3.0.0.css");
             
        public static readonly string bootstrap_theme_3_0_0_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap-theme-3.0.0.min.css") ? Url("bootstrap-theme-3.0.0.min.css") : Url("bootstrap-theme-3.0.0.css");
             
        public static readonly string favicon_ico = Url("favicon.ico");
        public static readonly string favicon_png = Url("favicon.png");
        public static readonly string fluidable_min_css = Url("fluidable.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class font {
            private const string URLPATH = "~/Content/font";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string entypo_eot = Url("entypo.eot");
            public static readonly string entypo_ttf = Url("entypo.ttf");
            public static readonly string entypo_woff = Url("entypo.woff");
            public static readonly string fontawesome_webfont_eot = Url("fontawesome-webfont.eot");
            public static readonly string fontawesome_webfont_svg = Url("fontawesome-webfont.svg");
            public static readonly string fontawesome_webfont_ttf = Url("fontawesome-webfont.ttf");
            public static readonly string fontawesome_webfont_woff = Url("fontawesome-webfont.woff");
            public static readonly string FontAwesome_otf = Url("FontAwesome.otf");
            public static readonly string glyphicons_halflings_regular_eot = Url("glyphicons-halflings-regular.eot");
            public static readonly string glyphicons_halflings_regular_svg = Url("glyphicons-halflings-regular.svg");
            public static readonly string glyphicons_halflings_regular_ttf = Url("glyphicons-halflings-regular.ttf");
            public static readonly string glyphicons_halflings_regular_woff = Url("glyphicons-halflings-regular.woff");
        }
    
        public static readonly string font_awesome_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/font-awesome.min.css") ? Url("font-awesome.min.css") : Url("font-awesome.css");
             
        public static readonly string gumby_2_5_6_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/gumby-2.5.6.min.css") ? Url("gumby-2.5.6.min.css") : Url("gumby-2.5.6.css");
             
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class img {
            private const string URLPATH = "~/Content/img";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class bootstrap {
                private const string URLPATH = "~/Content/img/bootstrap";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string glyphicons_halflings_white_png = Url("glyphicons-halflings-white.png");
                public static readonly string glyphicons_halflings_png = Url("glyphicons-halflings.png");
            }
        
            public static readonly string calendar_gif = Url("calendar.gif");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class datatables {
                private const string URLPATH = "~/Content/img/datatables";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string back_disabled_png = Url("back_disabled.png");
                public static readonly string back_enabled_png = Url("back_enabled.png");
                public static readonly string back_enabled_hover_png = Url("back_enabled_hover.png");
                public static readonly string forward_disabled_png = Url("forward_disabled.png");
                public static readonly string forward_enabled_png = Url("forward_enabled.png");
                public static readonly string forward_enabled_hover_png = Url("forward_enabled_hover.png");
                public static readonly string sort_asc_png = Url("sort_asc.png");
                public static readonly string sort_asc_disabled_png = Url("sort_asc_disabled.png");
                public static readonly string sort_both_png = Url("sort_both.png");
                public static readonly string sort_desc_png = Url("sort_desc.png");
                public static readonly string sort_desc_disabled_png = Url("sort_desc_disabled.png");
                public static readonly string Sorting_icons_psd = Url("Sorting icons.psd");
            }
        
            public static readonly string draft_png = Url("draft.png");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class jqueryui {
                private const string URLPATH = "~/Content/img/jqueryui";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string animated_overlay_gif = Url("animated-overlay.gif");
                public static readonly string ui_bg_flat_30_cccccc_40x100_png = Url("ui-bg_flat_30_cccccc_40x100.png");
                public static readonly string ui_bg_flat_50_5c5c5c_40x100_png = Url("ui-bg_flat_50_5c5c5c_40x100.png");
                public static readonly string ui_bg_glass_20_555555_1x400_png = Url("ui-bg_glass_20_555555_1x400.png");
                public static readonly string ui_bg_glass_40_0078a3_1x400_png = Url("ui-bg_glass_40_0078a3_1x400.png");
                public static readonly string ui_bg_glass_40_ffc73d_1x400_png = Url("ui-bg_glass_40_ffc73d_1x400.png");
                public static readonly string ui_bg_gloss_wave_25_333333_500x100_png = Url("ui-bg_gloss-wave_25_333333_500x100.png");
                public static readonly string ui_bg_highlight_soft_80_eeeeee_1x100_png = Url("ui-bg_highlight-soft_80_eeeeee_1x100.png");
                public static readonly string ui_bg_inset_soft_25_000000_1x100_png = Url("ui-bg_inset-soft_25_000000_1x100.png");
                public static readonly string ui_bg_inset_soft_30_f58400_1x100_png = Url("ui-bg_inset-soft_30_f58400_1x100.png");
                public static readonly string ui_icons_222222_256x240_png = Url("ui-icons_222222_256x240.png");
                public static readonly string ui_icons_4b8e0b_256x240_png = Url("ui-icons_4b8e0b_256x240.png");
                public static readonly string ui_icons_a83300_256x240_png = Url("ui-icons_a83300_256x240.png");
                public static readonly string ui_icons_cccccc_256x240_png = Url("ui-icons_cccccc_256x240.png");
                public static readonly string ui_icons_ffffff_256x240_png = Url("ui-icons_ffffff_256x240.png");
            }
        
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class inline {
            private const string URLPATH = "~/Content/inline";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string build_txt = Url("build.txt");
            public static readonly string changelog_html = Url("changelog.html");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class jpg {
            private const string URLPATH = "~/Content/jpg";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string wallpaper1_jpg = Url("wallpaper1.jpg");
        }
    
        public static readonly string jquery_ui_1_10_3_custom_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.10.3.custom.min.css") ? Url("jquery-ui-1.10.3.custom.min.css") : Url("jquery-ui-1.10.3.custom.css");
             
        public static readonly string jquery_bootstrap_datetimepicker_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.bootstrap.datetimepicker.min.css") ? Url("jquery.bootstrap.datetimepicker.min.css") : Url("jquery.bootstrap.datetimepicker.css");
             
        public static readonly string jquery_datatables_bootstrap3_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.datatables.bootstrap3.min.css") ? Url("jquery.datatables.bootstrap3.min.css") : Url("jquery.datatables.bootstrap3.css");
             
        public static readonly string jquery_dataTables_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.dataTables.min.css") ? Url("jquery.dataTables.min.css") : Url("jquery.dataTables.css");
             
        public static readonly string jquery_dataTables_jui_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.dataTables.jui.min.css") ? Url("jquery.dataTables.jui.min.css") : Url("jquery.dataTables.jui.css");
             
        public static readonly string jquery_jqplot_min_css = Url("jquery.jqplot.min.css");
        public static readonly string jquery_jScrollPane_2_0_0beta12_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.jScrollPane-2.0.0beta12.min.css") ? Url("jquery.jScrollPane-2.0.0beta12.min.css") : Url("jquery.jScrollPane-2.0.0beta12.css");
             
        public static readonly string jquery_ui_datetimepicker_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.datetimepicker.min.css") ? Url("jquery.ui.datetimepicker.min.css") : Url("jquery.ui.datetimepicker.css");
             
        public static readonly string jquery_ui_menubar_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.menubar.min.css") ? Url("jquery.ui.menubar.min.css") : Url("jquery.ui.menubar.css");
             
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class png {
            private const string URLPATH = "~/Content/png";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string bk_png = Url("bk.png");
            public static readonly string youtube_logo_png = Url("youtube-logo.png");
        }
    
        public static readonly string style_bootstrap_less = Url("style-bootstrap.less");
        public static readonly string style_bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/style-bootstrap.min.css") ? Url("style-bootstrap.min.css") : Url("style-bootstrap.css");
             
        public static readonly string style_bootstrap_min_css = Url("style-bootstrap.min.css");
        public static readonly string style_bootstrap3_less = Url("style-bootstrap3.less");
        public static readonly string style_bootstrap3_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/style-bootstrap3.min.css") ? Url("style-bootstrap3.min.css") : Url("style-bootstrap3.css");
             
        public static readonly string style_bootstrap3_min_css = Url("style-bootstrap3.min.css");
        public static readonly string style_gumby_less = Url("style-gumby.less");
        public static readonly string style_gumby_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/style-gumby.min.css") ? Url("style-gumby.min.css") : Url("style-gumby.css");
             
        public static readonly string style_gumby_min_css = Url("style-gumby.min.css");
        public static readonly string style_jqueryui_less = Url("style-jqueryui.less");
        public static readonly string style_jqueryui_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/style-jqueryui.min.css") ? Url("style-jqueryui.min.css") : Url("style-jqueryui.css");
             
        public static readonly string style_jqueryui_min_css = Url("style-jqueryui.min.css");
        public static readonly string style_less = Url("style.less");
        public static readonly string style_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/style.min.css") ? Url("style.min.css") : Url("style.css");
             
        public static readonly string style_min_css = Url("style.min.css");
        public static readonly string webextras_bootstrap_less = Url("webextras.bootstrap.less");
        public static readonly string webextras_bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/webextras.bootstrap.min.css") ? Url("webextras.bootstrap.min.css") : Url("webextras.bootstrap.css");
             
        public static readonly string webextras_bootstrap_min_css = Url("webextras.bootstrap.min.css");
        public static readonly string webextras_bootstrap3_less = Url("webextras.bootstrap3.less");
        public static readonly string webextras_bootstrap3_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/webextras.bootstrap3.min.css") ? Url("webextras.bootstrap3.min.css") : Url("webextras.bootstrap3.css");
             
        public static readonly string webextras_bootstrap3_min_css = Url("webextras.bootstrap3.min.css");
        public static readonly string webextras_common_less = Url("webextras.common.less");
        public static readonly string webextras_common_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/webextras.common.min.css") ? Url("webextras.common.min.css") : Url("webextras.common.css");
             
        public static readonly string webextras_common_min_css = Url("webextras.common.min.css");
        public static readonly string webextras_gumby_less = Url("webextras.gumby.less");
        public static readonly string webextras_gumby_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/webextras.gumby.min.css") ? Url("webextras.gumby.min.css") : Url("webextras.gumby.css");
             
        public static readonly string webextras_gumby_min_css = Url("webextras.gumby.min.css");
        public static readonly string webextras_jqueryui_less = Url("webextras.jqueryui.less");
        public static readonly string webextras_jqueryui_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/webextras.jqueryui.min.css") ? Url("webextras.jqueryui.min.css") : Url("webextras.jqueryui.css");
             
        public static readonly string webextras_jqueryui_min_css = Url("webextras.jqueryui.min.css");
        public static readonly string webextras_less = Url("webextras.less");
        public static readonly string webextras_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/webextras.min.css") ? Url("webextras.min.css") : Url("webextras.css");
             
        public static readonly string webextras_min_css = Url("webextras.min.css");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;


    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591


