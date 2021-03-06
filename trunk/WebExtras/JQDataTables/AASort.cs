﻿/*
* This file is part of - WebExtras
* Copyright (C) 2014 Mihir Mone
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
using WebExtras.Core;

namespace WebExtras.JQDataTables
{
  /// <summary>
  /// Specification for the column sorts
  /// </summary>
  [Serializable]
  public class AASort
  {
    /// <summary>
    /// Column number. This is zero indexed i.e the column numbers start from 0
    /// </summary>
    public int columnNumber;

    /// <summary>
    /// Type of sort. Only valid values are "asc" and "desc"
    /// </summary>
    public string sortType;

    /// <summary>
    /// Default constructor
    /// </summary>
    public AASort() { }

    /// <summary>
    /// Constructor to setup column number and sort type
    /// </summary>
    /// <param name="columnNumber">Column number</param>
    /// <param name="sort">[Optional] Sort type. Defaults to ascending.</param>
    public AASort(int columnNumber, ESort sort = ESort.Ascending)
    {
      this.columnNumber = columnNumber;
      sortType = sort.GetStringValue();
    }

    /// <summary>
    /// Converts the current AASort object to an array
    /// </summary>
    /// <returns>Resultant object array</returns>
    public object[] ToArray()
    {
      return new object[] { columnNumber, sortType };
    }
  }
}