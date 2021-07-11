using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Helper;

namespace UI.Controllers
{
    public class ItemCategoryController : Controller
    {
        // GET: ItemCategoryController

        public async Task<IActionResult> Index()
        {

            var data = await HttpHelper.Get<List<ItemCategory>>("https://localhost:44315/api/ItemCategory/GetList/");
            #region TempDataRegion
            if (TempData["Saved"] == null)
            {
                TempData["Saved"] = false;
            }
            if (TempData["Update"] == null)
            {
                TempData["Update"] = false;
            }
            if (TempData["Delete"] == null)
            {
                TempData["Delete"] = false;
            }
            if (TempData["Cannot"] == null)
            {
                TempData["Cannot"] = false;
            }
            #endregion


            return View(data);
        }

        // GET: ItemCategoryController/Details/5


        // GET: ItemCategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ItemCategory itemCategory)
        {
            try
            {


                var data = await HttpHelper.Post<ItemCategory>("https://localhost:44315/", "api/ItemCategory/Post", itemCategory);
                #region TempDataRegion
                TempData["Saved"] = true;
                TempData["Update"] = false;
                TempData["Delete"] = false;
                TempData["Cannot"] = false;
                #endregion
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemCategoryController/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var data = await HttpHelper.Get<ItemCategory>("https://localhost:44315/api/ItemCategory/GetById/" + id + "");
            return View("Create", data);
        }

        // POST: ItemCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ItemCategory itemCategory)
        {
            try
            {

                var data = await HttpHelper.Put<ItemCategory>("https://localhost:44315/", "api/ItemCategory/Put", itemCategory);
                #region TempDataRegion
                if (data.Errors.Count < 1)
                {
                  
                    TempData["Delete"] = false;
                    TempData["Saved"] = false;
                    TempData["Update"] = true;
                    TempData["Cannot"] = false;
                    
                }
                else {
                    TempData["Delete"] = false;
                    TempData["Saved"] = false;
                    TempData["Update"] = false;
                    TempData["Cannot"] = true;
                }
                #endregion
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemCategoryController/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = await HttpHelper.Get<ItemCategory>("https://localhost:44315/api/ItemCategory/GetById/" + id + "");
            return View("Create", data);
        }

        // POST: ItemCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(ItemCategory itemCategory)
        {
            try
            {
                ItemCategory itemCategory1 = new ItemCategory();
                itemCategory1 = itemCategory;
                var data = await HttpHelper.Put<ItemCategory>("https://localhost:44315/", "api/ItemCategory/Delete", itemCategory1);
                #region TempDataRegion
                if (data.Errors.Count < 1)
                {
                    TempData["Delete"] = true;
                    TempData["Saved"] = false;
                    TempData["Update"] = false;
                    TempData["Cannot"] = false;
                }
                else 
                {
                    TempData["Delete"] = false;
                    TempData["Saved"] = false;
                    TempData["Update"] = false;
                    TempData["Cannot"] = true;
                }
                #endregion

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
