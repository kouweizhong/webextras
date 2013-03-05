﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebExtras.DemoApp.Models.Core;
using WebExtras.JQDataTables;

namespace WebExtras.DemoApp.Controllers
{
  public partial class CoreController : Controller
  {
    //
    // GET: /Core/
    public virtual ActionResult Index()
    {
      return RedirectToAction(Actions.Generic());
    }

    //
    // GET: /Core/Generic
    public virtual ActionResult Generic()
    {
      return View();
    }

    //
    // GET: /Core/Datatables
    public virtual ActionResult Datatables(int? mode)
    {
      if (!mode.HasValue)
        return RedirectToAction(Actions.Datatables(0));

      DatatablesViewModel model = new DatatablesViewModel();
      string tableId = string.Empty;
      IEnumerable<DatatableColumn> dtColumns = new List<DatatableColumn>
      {
        new DatatableColumn("First Column"),
        new DatatableColumn("Second Column")
      };
      DatatableSettings dtSettings = null;
      DatatableRecords dtRecords = null;
      bool enableStatusColumn = false;

      switch (mode)
      {
        case 1:
          tableId = "ajax-table";
          dtSettings = new DatatableSettings(5, new AASort(0, SortType.Ascending), MVC.Core.ActionNames.GetAjaxData, "ajax records", "150px");
          break;

        case 2:
          tableId = "paged-table";
          dtSettings = new DatatableSettings(5, new AASort(0, SortType.Ascending), MVC.Core.ActionNames.GetPagedData, "paged records", "150px");
          dtRecords = GetPagedRecords(new DatatableFilters { iDisplayStart = 0, iDisplayLength = 5 });
          break;

        case 3:
          tableId = "paged-and-sorted-table";
          dtColumns = new List<DatatableColumn>
          {
            new DatatableColumn("HTML field column", bSortable: true),
            new DatatableColumn("String Column", bSortable: true),
            new DatatableColumn("DateTime Column", bSortable: true),
            new DatatableColumn("Numeric Column", bSortable: true),
            new DatatableColumn("Currency Column", bSortable: true)
          };
          dtSettings = new DatatableSettings(5, new AASort(0, SortType.Ascending), MVC.Core.ActionNames.GetSortedData, "sorted records", "150px");
          dtRecords = GetSortedRecords(new DatatableFilters { iDisplayStart = 0, iDisplayLength = 5 });
          break;

        case 4:
          tableId = "status-table";
          dtSettings = new DatatableSettings(5, new AASort(0, SortType.Ascending), null, "status records", "150px");
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
            aaData = statusData
          };
          break;

        case 0:
        default:
          tableId = "basic-table";
          dtSettings = new DatatableSettings(5, new AASort(0, SortType.Ascending), null, "basic records", "150px");
          IEnumerable<string[]> dtData = new string[][]
          {
            new string[] { "first column row 1", "second column row 1" },    
            new string[] { "first column row 2", "second column row 2" }
          };

          dtRecords = new DatatableRecords
          {
            iTotalRecords = dtData.Count(),            // Total records in table
            iTotalDisplayRecords = dtData.Count(),     // Total records to be displayed in the table
            aaData = dtData                           // The data to be displayed
          };
          break;
      }

      // Let's create the datatable object with an HTML ID, our settings, columns and records
      model.DisplayMode = mode.Value;
      model.Table = new Datatable(tableId, dtSettings, dtColumns, dtRecords, null, enableStatusColumn);
      return View(model);
    }

    //
    // GET: /Core/GetAjaxData
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
        aaData = dtData      // The data to be displayed
      };

      return Json(dtRecords, JsonRequestBehavior.AllowGet);
    }

    //
    // GET: /Core/GetPagedData
    public virtual JsonResult GetPagedData(DatatableFilters filters)
    {
      DatatableRecords dtRecords = GetPagedRecords(filters);

      return Json(dtRecords, JsonRequestBehavior.AllowGet);
    }

    //
    // GET: /Core/GetSortedData
    public virtual JsonResult GetSortedData(DatatableFilters filters)
    {
      DatatableRecords dtRecords = GetSortedRecords(filters);

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
        iTotalRecords = dtData.Count(),                                                // Total records in table
        iTotalDisplayRecords = dtData.Count(),                                         // Total records to be displayed in the table
        aaData = dtData.Skip(filters.iDisplayStart).Take(filters.iDisplayLength)      // The data to be displayed
      };

      return dtRecords;
    }

    //
    // Non action: /Core/GetSortedRecords
    [NonAction]
    public DatatableRecords GetSortedRecords(DatatableFilters filters)
    {
      // Let's create the actual data to go into the table
      List<string[]> dtData = new List<string[]> {
        new string[] { "<a href='#'>4</a>", "mihir", "02-Jan-13", "2", "&euro; 15.00" },
        new string[] { "<a href='#'>3</a>", "sneha", "2013-Mar-12", "45", "&pound; 12.00" },
        new string[] { "<a href='#'>1</a>", "mohan", "20 Mar 13", "32", "rs. 151.00" },
        new string[] { "<a href='#'>2</a>", "swati", "29May13", "10", "$ 201.00" },
        new string[] { "<a href='#'>2</a>", "sindhu", "Feb 11, 2012", "110", "&yen; 92.00" }
      };

      DatatableRecords dtRecords = new DatatableRecords
      {
        sEcho = filters.sEcho,
        iTotalRecords = dtData.Count(),                                                // Total records in table
        iTotalDisplayRecords = dtData.Count(),                                         // Total records to be displayed in the table
        aaData = dtData.Sort(filters.iSortCol_0, filters.SortDirection)      // The data to be displayed
      };

      return dtRecords;
    }

    //
    // GET: /Core/Flot
    public virtual ActionResult Flot()
    {
      return View();
    }
  }
}
