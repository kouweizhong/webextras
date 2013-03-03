﻿/*
* This file is part of - Code Library
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
using Newtonsoft.Json;

namespace WebExtras.JQDataTables
{
  /// <summary>
  /// Class encapsulating the returned well formed json data to a datatables table from a ajax call
  /// http://www.datatables.net
  ///
  /// "In reply to each request for information that DataTables makes to the server,
  /// it expects to get a well formed JSON object with the following parameters."
  /// http://www.datatables.net/usage/server-side
  /// </summary>
  [Serializable]
  public class DatatableRecords
  {
    /// <summary>
    /// Total records, before filtering (i.e. the total number of records in the database)
    /// </summary>
    public int iTotalDisplayRecords { get; set; }

    /// <summary>
    /// Total records, after filtering (i.e. the total number of records after filtering has been
    /// applied - not just the number of records being returned in this result set)
    /// </summary>
    public int iTotalRecords { get; set; }

    /// <summary>
    /// An unaltered copy of sEcho sent from the client side. This parameter will change with each draw (it is basically a draw count) -
    /// so it is important that this is implemented. Note that it strongly recommended for security reasons that you 'cast'
    /// this parameter to an integer in order to prevent Cross Site Scripting (XSS) attacks.
    /// </summary>
    public string sEcho { get; set; }

    /// <summary>
    /// The data in a 2D array
    /// </summary>
    public IEnumerable<IEnumerable<string>> aaData { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    public DatatableRecords()
    {
      sEcho = "1";
      aaData = new string[0][];
      iTotalDisplayRecords = 0;
      iTotalRecords = 0;
    }

    /// <summary>
    /// Returns a JSON serialized version of this object
    /// </summary>
    /// <returns>Returns a JSON serialized version of this object</returns>
    public override string ToString()
    {
      return JsonConvert.SerializeObject(this);
    }
  }
}