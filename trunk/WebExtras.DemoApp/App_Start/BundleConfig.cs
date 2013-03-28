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
* You should have received a copy of the GNU Affero General Public License
* along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Web;
using SquishIt.Framework;
using WebExtras.Core;

namespace WebExtras.DemoApp.App_Start
{
  /// <summary>
  /// Defines all CSS and JS bundles
  /// </summary>
  public class BundleConfig
  {
    /// <summary>
    /// Returns the CSS cache Url based on the given content bundle
    /// </summary>
    /// <param name="bundle">Content bundle</param>
    /// <returns>CSS cache Url</returns>
    public static string ResolveCssPath(ContentBundle bundle)
    {
      return string.Format("~/Assets/Css/{0}", bundle.GetStringValue());
    }

    /// <summary>
    /// Returns the JS cache Url based on the given content bundle
    /// </summary>
    /// <param name="bundle">Content bundle</param>
    /// <returns>JS cache Url</returns>
    public static string ResolveJsPath(ContentBundle bundle)
    {
      return string.Format("~/Assets/Js/{0}", bundle.GetStringValue());
    }

    /// <summary>
    /// Registers all bundles to be used across the website
    /// </summary>
    public static void RegisterBundles()
    {
      // Main CSS bundle
      Bundle.Css()
        .Add(Links.Content.bootstrap_2_3_1_css)
        .Add(Links.Content.jquery_dataTables_css)
        .Add(Links.Content.webextras_css)
        .Add(Links.Content.base_css)
        .AsCached(ContentBundle.CSSMain.GetStringValue(), ResolveCssPath(ContentBundle.CSSMain));

      // Create jQuery third party libraries bundle
      Bundle.JavaScript()        
        .Add(Links.Scripts.jquery_1_9_1_min_js)
        .Add(Links.Scripts.jquery_migrate_1_1_1_min_js)
        .Add(Links.Scripts.bootstrap_2_3_1_min_js)
        .Add(Links.Scripts.jquery_datatables_1_9_4_min_js)
        .Add(Links.Scripts.jquery_datatables_pagination_js)
        .Add(Links.Scripts.jquery_flot_0_7_js)
        .Add(Links.Scripts.jquery_flot_curvedlines_0_2_3_js)
        .Add(Links.Scripts.jquery_flot_dashes_0_1_js)
        .Add(Links.Scripts.jquery_flot_axislabels_1_0_js)
        .AsCached(ContentBundle.JSBase.GetStringValue(), ResolveJsPath(ContentBundle.JSBase));
    }
  }
}