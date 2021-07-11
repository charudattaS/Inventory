using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApi.Controllers
{
    public class ItemCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
