using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace TestSample.Controllers
{
    public class GridController : Controller
    {
        public IActionResult Grid()
        {
            var DataSource = OrdersDetails.GetAllRecords().ToList();
            ViewData["datasource"] = DataSource;
            return PartialView("Grid", ViewData);
        }
    }
}