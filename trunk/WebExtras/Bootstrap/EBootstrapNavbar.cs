﻿// 
// This file is part of - WebExtras
// Copyright (C) 2016 Mihir Mone
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using WebExtras.Core;

namespace WebExtras.Bootstrap
{
  /// <summary>
  ///   Types of bootstrap navigation bars available
  /// </summary>
  [Serializable]
  public enum EBootstrapNavbar
  {
    /// <summary>
    ///   Regular navigation bar
    /// </summary>
    [StringValue("navbar navbar-default")] Normal,

    /// <summary>
    ///   Navigation bar fixed at top of the viewport
    /// </summary>
    [StringValue("navbar-fixed-top")] FixedTop,

    /// <summary>
    ///   Navigation bar fixed at bottom of the viewport
    /// </summary>
    [StringValue("navbar-fixed-bottom")] FixedBottom,

    /// <summary>
    ///   Navigation bar fixed at top of the page
    /// </summary>
    [StringValue("navbar-static-top")] StaticTop
  }
}