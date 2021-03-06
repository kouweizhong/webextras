﻿// 
// This file is part of - WebExtras
// Copyright 2016 Mihir Mone
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using WebExtras.Html;

namespace WebExtras.Bootstrap
{
  /// <summary>
  ///   Generic interface implemented by bootstrap form control elements
  /// </summary>
  /// <typeparam name="TModel">Type to be scanned</typeparam>
  /// <typeparam name="TValue">Property to be scanned</typeparam>
  public interface IBootstrapFormComponent<TModel, TValue> : IFormComponent<TModel, TValue>
  {
    /// <summary>
    /// The wrapper DIV element. Note: This property is only initialised in the constructor. Composition of the component takes place just before rendering i.e in the <see cref="IHtmlRenderer.ToHtml"/> method
    /// </summary>
    IHtmlComponent Wrapper { get; }

    /// <summary>
    ///   Changes render behavior to default
    /// </summary>
    /// <returns>The updated form control</returns>
    IBootstrapFormComponent<TModel, TValue> WithDefaultBehavior();

    /// <summary>
    ///   Changes render behavior to add on
    /// </summary>
    /// <returns>The updated form control</returns>
    IBootstrapFormComponent<TModel, TValue> WithAddonBehavior();
  }
}