﻿/*
* This file is part of - WebExtras Demo application
* Copyright (C) 2013 Mihir Mone
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU Lesser General Public License as published by
* the Free Software Foundation, either version 2 of the License, or
* (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU Lesser General Public License for more details.
*
* You should have received a copy of the GNU Lesser General Public License
* along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Web.Mvc;
using WebExtras.DemoApp.Areas.Bootstrap.Models.Mvc;
using WebExtras.Mvc.Bootstrap;

namespace WebExtras.DemoApp.Areas.Bootstrap.Controllers
{
  public partial class MvcController : Controller
  {
    //
    // GET: /Bootstrap/Mvc
    public virtual ActionResult Index()
    {
      return RedirectToAction(Actions.CoreHtml());
    }

    //
    // GET: /Bootstrap/Mvc/CoreHtml
    public virtual ActionResult CoreHtml()
    {
      return View();
    }

    //
    // GET: /Bootstrap/Mvc/CoreForm
    public virtual ActionResult CoreForm()
    {
      return View();
    }

    //
    // GET: /Bootstrap/Mvc/BootstrapHtml
    public virtual ActionResult BootstrapHtml(bool? msg)
    {
      BootstrapHtmlViewModel model = new BootstrapHtmlViewModel
      {
        SomeProperty = "Blah blah",
        ShowMessage = msg.HasValue
      };

      return View(model);
    }

    //
    // GET: /Bootstrap/Mvc/BootstrapForm
    public virtual ActionResult BootstrapForm()
    {
      BootstrapFormViewModel model = new BootstrapFormViewModel
      {
        DateTextBox = DateTime.Now,
        DateTimeTextBox = DateTime.Now,
        TimeTextBox = DateTime.Now
      };

      return View(model);
    }

    //
    // GET: /Bootstrap/Mvc/ActionMessageDemo
    public virtual ActionResult ActionMessageDemo()
    {
      return this.RedirectToAction(Actions.BootstrapHtml(true), "This is an action message demo");
    }

    //
    // GET: /Bootstrap/Mvc/ActionResults
    public virtual ActionResult ActionResults()
    {
      return View();
    }
  }
}