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
using WebExtras.Core;

namespace WebExtras.Mvc.Html
{
  /// <summary>
  /// A collection of list types
  /// </summary>
  [Serializable]
  public enum ListType
  {
    /// <summary>
    /// An ordered list
    /// </summary>
    [StringValue("ol")]
    Ordered,

    /// <summary>
    /// An unordered list
    /// </summary>
    [StringValue("ul")]
    Unordered,
  }
}