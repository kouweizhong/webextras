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

using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebExtras.Core;
using WebExtras.DemoApp.Models.Core;
using WebExtras.JQDataTables;
using WebExtras.JQFlot;
using WebExtras.JQPlot;

namespace WebExtras.DemoApp.Areas.JQueryUI.Controllers
{
  public partial class CoreController : BaseController
  {
    #region Ctor and attributes

    private readonly GraphDataGenerator m_graphDataGenerator;

    /// <summary>
    /// Constructor
    /// </summary>
    public CoreController()
    {
      m_graphDataGenerator = new GraphDataGenerator();
    }

    #endregion Ctor and attributes

    #region Index action

    //
    // GET: /JQueryUI/Core/
    public virtual ActionResult Index()
    {
      return RedirectToAction(Actions.Generic());
    }

    #endregion Index action

    #region Generic action

    //
    // GET: /JQueryUI/Core/Generic
    public virtual ActionResult Generic()
    {
      return View();
    }

    #endregion Generic action

    #region Datatables actions

    //
    // GET: /JQueryUI/Core/Datatables
    public virtual ActionResult Datatables(int? mode)
    {
      if (!mode.HasValue)
        return RedirectToAction(Actions.Datatables(0));

      DatatablesViewModel model = new DatatablesViewModel();
      string tableId = string.Empty;

      IEnumerable<AOColumn> dtAOColumns = new List<AOColumn> { 
        new AOColumn { sTitle = "First Column", sWidth = "25%" },
        new AOColumn { sTitle = "Second Column" }
      };

      DatatableSettings dtSettings = null;
      DatatableRecords dtRecords = null;
      bool enableStatusColumn = false;

      switch (mode)
      {
        case 1:
          tableId = "ajax-table";
          dtSettings = new DatatableSettings(5, dtAOColumns, new AASort(0, ESort.Ascending), MVC.Bootstrap.Core.ActionNames.GetAjaxData, "ajax records", "150px");
          break;

        case 2:
          tableId = "paged-table";
          dtSettings = new DatatableSettings(5, dtAOColumns, new AASort(0, ESort.Ascending), MVC.Bootstrap.Core.ActionNames.GetPagedData, "paged records", "150px");
          dtRecords = GetPagedRecords(new DatatableFilters { iDisplayStart = 0, iDisplayLength = 5 });
          break;

        case 3:
          tableId = "paged-and-sorted-table";
          dtAOColumns = new List<AOColumn>
          {
            new AOColumn { sTitle = "HTML field column", bSortable = true },
            new AOColumn { sTitle = "String Column", bSortable = true },
            new AOColumn { sTitle = "DateTime Column", bSortable = true },
            new AOColumn { sTitle = "Numeric Column", bSortable = true },
            new AOColumn { sTitle = "Currency Column", bSortable = true }
          };
          dtSettings = new DatatableSettings(5, dtAOColumns, new AASort(0, ESort.Ascending), MVC.Bootstrap.Core.ActionNames.GetSortedData, "sorted records", "150px");
          dtRecords = GetSortedRecords(new DatatableFilters { iDisplayStart = 0, iDisplayLength = 5 });
          break;

        case 4:
          tableId = "status-table";
          dtSettings = new DatatableSettings(5, dtAOColumns, new AASort(0, ESort.Ascending), null, "status records", "150px");
          IEnumerable<string[]> statusData = new string[][]
          {
            new string[] { "first column row 1", "second column row 1", "error" },    
            new string[] { "first column row 2", "second column row 2", "warning" },
            new string[] { "first column row 3", "second column row 3", "info" },
            new string[] { "first column row 4", "second column row 4", "success" }
          };
          enableStatusColumn = true;
          dtRecords = new DatatableRecords
          {
            iTotalRecords = statusData.Count(),
            iTotalDisplayRecords = statusData.Count(),
            aaData = statusData.ToArray()
          };
          break;

        case 0:
        case 5:
        default:
          tableId = "basic-table";
          dtSettings = new DatatableSettings(5, dtAOColumns, new AASort(0, ESort.Ascending), null, "basic records", "150px");
          IEnumerable<string[]> dtData = new string[][]
          {
            new string[] { "first column row 1", "second column row 1" },    
            new string[] { "first column row 2", "second column row 2" },
            new string[] { "first column row 3", "second column row 3" },
            new string[] { "first column row 4", "second column row 4" }
          };

          dtRecords = new DatatableRecords
          {
            iTotalRecords = dtData.Count(),            // Total records in table
            iTotalDisplayRecords = dtData.Count(),     // Total records to be displayed in the table
            aaData = dtData.ToArray()                  // The data to be displayed
          };
          break;
      }

      // Resets the pagination scheme
      dtSettings.bJQueryUI = true;

      // Let's create the datatable object with an HTML ID, our settings, columns and records
      model.DisplayMode = mode.Value;
      model.Table = new Datatable(tableId, dtSettings, dtRecords, null, enableStatusColumn);
      return View(model);
    }

    [HttpPost]
    public virtual ActionResult Datatables(DatatablesViewModel viewModel)
    {
      // create the basic table again
      IEnumerable<AOColumn> dtAOColumns = new List<AOColumn> { 
        new AOColumn { sTitle = "First Column", sWidth = "25%" },
        new AOColumn { sTitle = "Second Column" }
      };

      DatatableSettings dtSettings = new DatatableSettings(5, dtAOColumns, new AASort(0, ESort.Ascending), null, "basic records", "150px");
      dtSettings.bJQueryUI = true;

      IEnumerable<string[]> dtData = new string[][]
      {
        new string[] { "first column row 1", "second column row 1" },    
        new string[] { "first column row 2", "second column row 2" },
        new string[] { "first column row 3", "second column row 3" },
        new string[] { "first column row 4", "second column row 4" }
      };

      DatatableRecords dtRecords = new DatatableRecords
      {
        iTotalRecords = dtData.Count(),            // Total records in table
        iTotalDisplayRecords = dtData.Count(),     // Total records to be displayed in the table
        aaData = dtData.ToArray()                  // The data to be displayed
      };
      viewModel.Table = new Datatable("basic-table", dtSettings, dtRecords);

      // create the postbacks enabled table
      IEnumerable<PostbackItem> dtPostbacks = PostbackItem.FromObject(viewModel.PostbackFormFields);
      dtSettings = new DatatableSettings(5, dtAOColumns, new AASort(0, ESort.Ascending), MVC.Bootstrap.Core.ActionNames.GetPostbackData, "searched/filtered records", "150px");
      dtSettings.bJQueryUI = true;
      viewModel.PostbackEnabledTable = new Datatable("postbacks-table", dtSettings, null, dtPostbacks);

      // update the display mode
      viewModel.DisplayMode = 6;

      return View(MVC.JQueryUI.Core.Views.Datatables, viewModel);
    }

    //
    // GET: /JQueryUI/Core/GetAjaxData
    public virtual JsonResult GetAjaxData(DatatableFilters filters)
    {
      // Let's create the actual data to go into the table
      string[][] dtData = new string[][]
      {
        new string[] { "first column ajax row 1", "second column ajax row 1" },    
        new string[] { "first column ajax row 2", "second column ajax row 2" }
      };

      DatatableRecords dtRecords = new DatatableRecords
      {
        sEcho = filters.sEcho,
        iTotalRecords = dtData.Length,                                                // Total records in table
        iTotalDisplayRecords = dtData.Length,                                         // Total records to be displayed in the table
        aaData = dtData                                                               // The data to be displayed
      };

      return Json(dtRecords, JsonRequestBehavior.AllowGet);
    }

    //
    // GET: /JQueryUI/Core/GetPagedData
    public virtual JsonResult GetPagedData(DatatableFilters filters)
    {
      DatatableRecords dtRecords = GetPagedRecords(filters);

      return Json(dtRecords, JsonRequestBehavior.AllowGet);
    }

    //
    // GET: /Bootstrap/Core/GetSortedData
    public virtual JsonResult GetSortedData(DatatableFilters filters)
    {
      DatatableRecords dtRecords = GetSortedRecords(filters);

      return Json(dtRecords, JsonRequestBehavior.AllowGet);
    }

    //
    // GET: /JQueryUI/Core/GetPostbackData
    public virtual JsonResult GetPostbackData(DatatableFilters filters, PostbackSetupViewModel postbacks)
    {
      IEnumerable<string[]> dtData = new string[][]
      {
        new string[] { "first column row 1", "second column row 1" },    
        new string[] { "first column row 2", "second column row 2" },
        new string[] { "first column row 3", "second column row 3" },
        new string[] { "first column row 4", "second column row 4" }
      };

      if (!string.IsNullOrEmpty(postbacks.FirstColumn))
        dtData = dtData.Where(f => f[0].ContainsIgnoreCase(postbacks.FirstColumn));
      if (!string.IsNullOrEmpty(postbacks.SecondColumn))
        dtData = dtData.Where(f => f[1].ContainsIgnoreCase(postbacks.SecondColumn));

      DatatableRecords dtRecords = new DatatableRecords
      {
        sEcho = filters.sEcho,
        iTotalRecords = dtData.Count(),
        iTotalDisplayRecords = dtData.Count(),
        aaData = dtData.ToArray()
      };

      return Json(dtRecords, JsonRequestBehavior.AllowGet);
    }

    //
    // Non action: /Core/GetPagedRecords
    [NonAction]
    public DatatableRecords GetPagedRecords(DatatableFilters filters)
    {
      // Let's create the actual data to go into the table
      List<string[]> dtData = new List<string[]>();

      for (int i = 0; i < 15; i++)
      {
        dtData.Add(new string[] { 
          string.Format("first column paged row {0}", i + 1), 
          string.Format("second column paged row {0}", i + 1) 
        });
      }

      DatatableRecords dtRecords = new DatatableRecords
      {
        sEcho = filters.sEcho,
        iTotalRecords = dtData.Count(),                     // Total records in table
        iTotalDisplayRecords = dtData.Count(),              // Total records to be displayed in the table
        aaData = dtData
          .Skip(filters.iDisplayStart)                      // The data to be displayed
          .Take(filters.iDisplayLength)
          .ToArray()
      };

      return dtRecords;
    }

    //
    // Non action: /Core/GetSortedRecords
    [NonAction]
    public DatatableRecords GetSortedRecords(DatatableFilters filters)
    {
      // Let's create the actual data to go into the table
      IList<string[]> dtData = DatatableGenerator.GetDataWithSpecialFormat();

      DatatableRecords dtRecords = new DatatableRecords
      {
        sEcho = filters.sEcho,
        iTotalRecords = dtData.Count(),                                 // Total records in table
        iTotalDisplayRecords = dtData.Count(),                          // Total records to be displayed in the table
        aaData = dtData
          .Sort(filters.iSortCol_0, filters.SortDirection)              // The data to be displayed
          .ToArray()
      };

      return dtRecords;
    }

    #endregion Datatables actions

    #region Flot actions

    //
    // GET: /JQueryUI/Core/Flot
    public virtual ActionResult Flot(int? mode)
    {
      int dmode = mode.HasValue ? mode.Value : 0;

      FlotChart chart = m_graphDataGenerator.GetFlotChart(dmode);

      FlotViewModel model = new FlotViewModel
      {
        Chart = chart,
        DisplayMode = dmode
      };

      return View(model);
    }

    #endregion Flot actions

    #region JQPlot actions

    //
    // GET: /JQueryUI/Core/JQPlot
    public virtual ActionResult JQPlot(int? mode)
    {
      int dmode = mode.HasValue ? mode.Value : 0;

      JQPlotChartBase[] charts = m_graphDataGenerator.GetJQPlotCharts(dmode, Url);

      JQPlotViewModel model = new JQPlotViewModel
      {
        Charts = charts,
        DisplayMode = dmode
      };

      return View(model);
    }
    
    #endregion JQPlot actions
  }
}
