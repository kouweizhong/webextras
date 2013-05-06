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
using System.Web.Mvc;
using System.Web.Routing;
using WebExtras.Mvc.Html;

namespace WebExtras.Mvc.Core
{
  /// <summary>
  /// Form helper extension methods
  /// </summary>
  public static class FormHelperExtension
  {
    #region Button extensions

    /// <summary>
    /// Create a HTML button
    /// </summary>
    /// <param name="html">Current HTML helper object</param>
    /// <param name="type">Button type</param>
    /// <param name="text">Button text</param>
    /// <param name="htmlAttributes">[Optional] Extra HTML attributes</param>
    /// <returns>A HTML Button</returns>
    public static Button Button(
      this HtmlHelper html,
      ButtonOfType type,
      string text,
      object htmlAttributes = null)
    {
      return new Button(type, text, string.Empty, htmlAttributes);
    }

    /// <summary>
    /// Create a HTML button
    /// </summary>
    /// <param name="html">Current HTML helper object</param>
    /// <param name="type">Button type</param>
    /// <param name="text">Button text</param>
    /// <param name="onclick">Button javascript onclick event</param>
    /// <param name="htmlAttributes">[Optional] Extra HTML attributes</param>
    /// <returns>A HTML Button</returns>
    public static Button Button(
      this HtmlHelper html,
      ButtonOfType type,
      string text,
      string onclick,
      object htmlAttributes = null)
    {
      return new Button(type, text, onclick, htmlAttributes);
    }

    #endregion Button extensions

    #region CheckBoxGroup extensions

    /// <summary>
    /// Creates a HTML TABLE with given checkboxes
    /// </summary>
    /// <param name="html">Current HTML helper object</param>
    /// <param name="name">Name of the checkbox group</param>
    /// <param name="checkboxes">A collection of checkboxes</param>
    /// <param name="htmlAttributes">[Optional] Extra HTML attributes</param>
    /// <returns>A HTML checkbox list</returns>
    public static MvcHtmlString CheckBoxGroup(
      this HtmlHelper html,
      string name,
      IEnumerable<CheckBox> checkboxes,
      object htmlAttributes = null)
    {
      return CheckBoxGroup(html, name, checkboxes, 5, htmlAttributes);
    }

    /// <summary>
    /// Creates a HTML TABLE with given checkboxes
    /// </summary>
    /// <param name="html">Current HTML helper object</param>
    /// <param name="name">Name of the checkbox group</param>
    /// <param name="checkboxes">A collection of checkboxes</param>
    /// <param name="boxesPerLine">No. of checkboxes to display per line</param>
    /// <param name="htmlAttributes">[Optional] Extra HTML attributes</param>
    /// <returns>A HTML checkbox list</returns>
    public static MvcHtmlString CheckBoxGroup(
      this HtmlHelper html,
      string name,
      IEnumerable<CheckBox> checkboxes,
      int boxesPerLine,
      object htmlAttributes = null)
    {
      foreach (CheckBox c in checkboxes)
        c["name"] = name;

      List<string> rows = new List<string>();
      for (int i = 0; i < checkboxes.Count(); i += boxesPerLine)
      {
        IEnumerable<string> datas = checkboxes
          .Skip(i)
          .Take(boxesPerLine)
          .Select(f => string.Format("<td>{0}</td>\n", f.ToHtmlString()));

        rows.Add("<tr>" + string.Join("", datas) + "</tr>\n");
      }

      TagBuilder table = new TagBuilder("table");
      table.AddCssClass("checkbox-group");
      table.InnerHtml = string.Join("", rows);
      table.MergeAttributes<string, object>(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

      return MvcHtmlString.Create(table.ToString(TagRenderMode.Normal));
    }

    #endregion CheckBoxGroup extensions

    #region RadioButtonGroup extensions

    /// <summary>
    /// Creates a HTML TABLE with given radio buttons
    /// </summary>
    /// <param name="html">Current HTML helper object</param>
    /// <param name="name">Name of the checkbox group</param>
    /// <param name="radioButtons">A collection of radio buttons</param>
    /// <param name="htmlAttributes">[Optional] Extra HTML attributes</param>
    /// <returns>A HTML radio buttons list</returns>
    public static MvcHtmlString RadioButtonGroup(
      this HtmlHelper html,
      string name,
      IEnumerable<RadioButton> radioButtons,
      object htmlAttributes = null)
    {
      return RadioButtonGroup(html, name, radioButtons, 5, htmlAttributes);
    }

    /// <summary>
    /// Creates a HTML TABLE with given radio buttons
    /// </summary>
    /// <param name="html">Current HTML helper object</param>
    /// <param name="name">Name of the checkbox group</param>
    /// <param name="radioButtons">A collection of radio buttons</param>
    /// <param name="buttonsPerLine">No. of radio buttons to display per line</param>
    /// <param name="htmlAttributes">[Optional] Extra HTML attributes</param>
    /// <returns>A HTML radio buttons list</returns>
    public static MvcHtmlString RadioButtonGroup(
      this HtmlHelper html,
      string name,
      IEnumerable<RadioButton> radioButtons,
      int buttonsPerLine,
      object htmlAttributes = null)
    {
      foreach (RadioButton r in radioButtons)
        r["name"] = name;

      List<string> rows = new List<string>();
      for (int i = 0; i < radioButtons.Count(); i += buttonsPerLine)
      {
        IEnumerable<string> datas = radioButtons
          .Skip(i)
          .Take(buttonsPerLine)
          .Select(f => string.Format("<td>{0}</td>\n", f.ToHtmlString()));

        rows.Add("<tr>" + string.Join("", datas) + "</tr>\n");
      }

      TagBuilder table = new TagBuilder("table");
      table.AddCssClass("radiobutton-group");
      table.InnerHtml = string.Join("", rows);
      table.MergeAttributes<string, object>(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

      return MvcHtmlString.Create(table.ToString(TagRenderMode.Normal));
    }

    #endregion RadioButtonGroup extensions

    #region List extensions

    /// <summary>
    /// Create an HTML LIST
    /// </summary>
    /// <param name="html">Current HTML helper object</param>
    /// <param name="type">List type</param>
    /// <param name="listItems">A collection of list items</param>
    /// <param name="htmlAttributes">[Optional] Extra HTML attributes</param>
    /// <returns>A HTML LIST</returns>
    public static HtmlList List(
      this HtmlHelper html,
      ListType type,
      IEnumerable<HtmlListItem> listItems,
      object htmlAttributes = null)
    {
      return new HtmlList(type, listItems, htmlAttributes);
    }

    #endregion List extensions
  }
}