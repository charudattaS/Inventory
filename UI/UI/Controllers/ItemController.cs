﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model;
using System;

using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using UI.Helper;

namespace UI.Controllers
{
    public class ItemController : Controller
    {
       
        public async Task<IActionResult> Index()
        {

            var data = await HttpHelper.Get<List<Item>>("https://localhost:44315/api/Item/GetList/");
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

        public async Task<IActionResult> Create()
        {
            var data = await HttpHelper.Get<List<ItemCategory>>("https://localhost:44315/api/ItemCategory/GetList");
            ViewBag.ItemCategory = new SelectList(data,"Id","Name");
            return View();
        }

        // POST: ItemCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ItemTrans itemTrans)
        {
            try
            {

                var data = await HttpHelper.Post<ItemTrans>("https://localhost:44315/", "api/ItemStockTransaction/Post", itemTrans);
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
            
            ItemTrans trans = new ItemTrans();
            var data = await HttpHelper.Get<ItemTrans>("https://localhost:44315/api/ItemStockTransaction/GetByItemId/" + id + "");
            trans.item = data.item;
            trans.itemCostDetails = data.itemCostDetails;
            var Getdata = await HttpHelper.Get<List<ItemCategory>>("https://localhost:44315/api/ItemCategory/GetList");
            ViewBag.ItemCategory = new SelectList(Getdata, "Id", "Name", trans.item.ItemCategoryId);
            trans.item.Id = id;
            return View("Create", trans);
        }

        // POST: ItemCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ItemTrans itemTrans)
        {
            try
            {
                var data = await HttpHelper.Put<ItemTrans>("https://localhost:44315/", "api/ItemStockTransaction/Put", itemTrans);
                #region TempDataRegion
                if (data.item.Errors.Count < 1)
                {

                    TempData["Delete"] = false;
                    TempData["Saved"] = false;
                    TempData["Update"] = true;
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

        // GET: ItemCategoryController/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var data = await HttpHelper.Get<Item>("https://localhost:44315/api/Item/GetById/" + id + "");
            return View("Create", data);
        }

        // POST: ItemCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(ItemTrans itemTrans)
        {
            try
            {
                itemTrans.item.IsDeleted = true;
                var data = await HttpHelper.Post<ItemTrans>("https://localhost:44315/", "api/ItemStockTransaction/Post", itemTrans);
                #region TempDataRegion
                if (data.item.Errors.Count < 1)
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