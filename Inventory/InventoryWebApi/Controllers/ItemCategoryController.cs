using BusinessLogics.Bal;
using DalAccess.IDal;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ItemCategoryController : ControllerBase
    {
       
        private ItemCategoryBal bal;
        public ItemCategoryController(ItemCategoryBal bal) 
        {
            this.bal = bal;
        }

        [HttpGet]
       public IActionResult GetList()
        {
            List<ItemCategory> List = bal.Get();
            return Ok(List);
        }
        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(Guid Id)
        {
            ItemCategory data = bal.GetById(Id);
            return Ok(data);
        }

        [HttpPost]
       // [Route("{api/ItemCategory}")]
        public IActionResult Post(ItemCategory itemCategory)
        {
            itemCategory= bal.Insert(itemCategory);
            return Ok(itemCategory);
        }

        [HttpPut]
        //[Route("{itemCategory}")]
        public IActionResult Put(ItemCategory itemCategory)
        {
            itemCategory = bal.Update(itemCategory);
            return Ok(itemCategory);
        }
        [HttpPut]
        //[Route("{itemCategory}")]
        public IActionResult Delete(ItemCategory itemCategory)
        {
            itemCategory = bal.Delete(itemCategory);
            return Ok(itemCategory);
        }
    }
}
