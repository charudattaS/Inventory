using InventoryWebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class ItemCategoryController : Controller
    {
        private Guid shopid = Guid.Parse("f44ca7a7-c13a-45f4-b781-3e8af2176091");
        ItemCategoryWebApiController data;
        ItemCategoryController(ItemCategoryWebApiController data) 
        {
            this.data = data;
        }
        public IActionResult Index()
        {
           var list= data.GetList(shopid);
            return View(list);
        }
    }
}
