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
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace WebExtras.Mvc.Core
{
  /// <summary>
  /// JSON.Net action result
  /// </summary>
  public class JsonNetResult : ActionResult
  {
    /// <summary>
    /// Content encoding
    /// </summary>
    public Encoding ContentEncoding { get; set; }

    /// <summary>
    /// Content type
    /// </summary>
    public string ContentType { get; set; }

    /// <summary>
    /// Data to be returned
    /// </summary>
    public object Data { get; set; }

    /// <summary>
    /// JSON serialiser settings
    /// </summary>
    public JsonSerializerSettings SerialiserSettings { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="data">Data to be returned</param>
    /// <param name="settings">JSON serialiser settings</param>
    public JsonNetResult(object data, JsonSerializerSettings settings = null)
      : this(data, "application/json", Encoding.UTF8, settings)
    { }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="data">Data to be returned</param>
    /// <param name="contentType">Content type</param>
    /// <param name="settings">JSON serialiser settings</param>
    public JsonNetResult(object data, string contentType, JsonSerializerSettings settings = null)
      : this(data, contentType, Encoding.UTF8, settings)
    { }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="data">Data to be returned</param>
    /// <param name="contentType">Content type</param>
    /// <param name="contentEncoding">Content encoding</param>
    /// <param name="settings">JSON serialiser settings</param>
    public JsonNetResult(object data, string contentType, Encoding contentEncoding, JsonSerializerSettings settings = null)
    {
      Data = data;
      ContentType = contentType;
      ContentEncoding = ContentEncoding;
      SerialiserSettings = settings ?? new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
    }

    /// <summary>
    /// Execute this result
    /// </summary>
    /// <param name="context">Controller context</param>
    public override void ExecuteResult(ControllerContext context)
    {
      if (context == null)
        throw new ArgumentNullException("context");

      HttpResponseBase response = context.HttpContext.Response;

      response.ContentType = ContentType;
      response.ContentEncoding = ContentEncoding;

      if (Data != null)
      {
        JsonTextWriter writer = new JsonTextWriter(response.Output);
        JsonSerializer serializer = JsonSerializer.Create(SerialiserSettings);
        serializer.Serialize(writer, Data);

        writer.Flush();
      }
    }
  }
}
