// <auto-generated />
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
namespace WebExtras.DemoApp.Areas.Bootstrap3.Controllers
{
    public partial class MvcController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public MvcController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected MvcController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult BootstrapHtml()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BootstrapHtml);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult ActionMessageDemo()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionMessageDemo);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public MvcController Actions { get { return MVC.Bootstrap3.Mvc; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "bootstrap3";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "mvc";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "mvc";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = ("Index").ToLowerInvariant();
            public readonly string CoreHtml = ("CoreHtml").ToLowerInvariant();
            public readonly string CoreForm = ("CoreForm").ToLowerInvariant();
            public readonly string BootstrapHtml = ("BootstrapHtml").ToLowerInvariant();
            public readonly string BootstrapForm = ("BootstrapForm").ToLowerInvariant();
            public readonly string ActionMessageDemo = ("ActionMessageDemo").ToLowerInvariant();
            public readonly string ActionResults = ("ActionResults").ToLowerInvariant();
        }


        static readonly ActionParamsClass_BootstrapHtml s_params_BootstrapHtml = new ActionParamsClass_BootstrapHtml();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_BootstrapHtml BootstrapHtmlParams { get { return s_params_BootstrapHtml; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_BootstrapHtml
        {
            public readonly string msg = ("msg").ToLowerInvariant();
        }
        static readonly ActionParamsClass_ActionMessageDemo s_params_ActionMessageDemo = new ActionParamsClass_ActionMessageDemo();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActionMessageDemo ActionMessageDemoParams { get { return s_params_ActionMessageDemo; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActionMessageDemo
        {
            public readonly string success = ("success").ToLowerInvariant();
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string ActionResults = "ActionResults";
                public readonly string BootstrapForm = "BootstrapForm";
                public readonly string BootstrapHtml = "BootstrapHtml";
                public readonly string CoreForm = "CoreForm";
                public readonly string CoreHtml = "CoreHtml";
            }
            public readonly string ActionResults = "~/Areas/Bootstrap3/Views/Mvc/ActionResults.cshtml";
            public readonly string BootstrapForm = "~/Areas/Bootstrap3/Views/Mvc/BootstrapForm.cshtml";
            public readonly string BootstrapHtml = "~/Areas/Bootstrap3/Views/Mvc/BootstrapHtml.cshtml";
            public readonly string CoreForm = "~/Areas/Bootstrap3/Views/Mvc/CoreForm.cshtml";
            public readonly string CoreHtml = "~/Areas/Bootstrap3/Views/Mvc/CoreHtml.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_MvcController : WebExtras.DemoApp.Areas.Bootstrap3.Controllers.MvcController
    {
        public T4MVC_MvcController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult CoreHtml()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CoreHtml);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult CoreForm()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CoreForm);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult BootstrapHtml(bool? msg)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BootstrapHtml);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "msg", msg);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult BootstrapForm()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BootstrapForm);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ActionMessageDemo(bool success)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionMessageDemo);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "success", success);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ActionResults()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionResults);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
