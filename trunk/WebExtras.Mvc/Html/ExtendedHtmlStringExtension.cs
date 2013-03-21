﻿/*
* This file is part of - WebExtras
* Copyright (C) 2013 Mihir Mone
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU Lesser General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebExtras.Mvc.Html
{
  /// <summary>
  /// Generic extension for an extended html string
  /// </summary>
  public static class ExtendedHtmlStringExtension
  {
    /// <summary>
    /// Converts the current HTML element to a javascript hyperlink link if possible
    /// </summary>
    /// <param name="html">HTML element to be converted</param>
    /// <returns>Converted hyperlink</returns>
    public static IExtendedHtmlString AsJavascriptLink(this IExtendedHtmlString html)
    {
      if (html.Tag.Attributes.ContainsKey("href"))
      {
        html.Tag.Attributes["href"] = "javascript:" + html.Tag.Attributes["href"];
      }

      return html;
    }

    /// <summary>
    /// Adds given CSS class(es) to the current HTML element
    /// </summary>
    /// <param name="html">HTML element to add class to</param>
    /// <param name="css">CSS class(es) to be added</param>
    /// <returns>Current HTML element with classes added</returns>
    public static IExtendedHtmlString AddCssClass(this IExtendedHtmlString html, string css)
    {
      html.Tag.AddCssClass(css);

      return html;
    }
  }
}
