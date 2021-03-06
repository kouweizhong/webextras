﻿/*
* This file is part of - WebExtras Demo application
* Copyright (C) 2014 Mihir Mone
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

using System.Web.Mvc;

namespace WebExtras.DemoApp.Areas.JQueryUI
{
  public class JQueryUIAreaRegistration : AreaRegistration
  {
    public override string AreaName
    {
      get
      {
        return "JQueryUI";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      context.MapRoute(
          "jqueryui_default",
          "JQueryUI/{controller}/{action}/{id}",
          new { area = "JQueryUI",  controller = "Home", action = "Index", id = UrlParameter.Optional }
      );
    }
  }
}
