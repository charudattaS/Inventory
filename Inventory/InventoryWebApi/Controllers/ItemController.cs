using BusinessLogics.Bal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ItemController : ControllerBase
    {
        private ItemBal bal;
        public ItemController(ItemBal bal)
        {
            this.bal = bal;
        }
        [HttpGet]
        
        public IActionResult GetList()
        {
            List<Item> List = bal.Get();
            return Ok(List);
        }
        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetById(Guid Id)
        {
            Item data = bal.GetById(Id);
            return Ok(data);
        }

        [HttpPost]
       
        public IActionResult Post(Item item)
        {
            item = bal.Insert(item);
            return Ok(item);
        }

        [HttpPut]
       
        public IActionResult Put(Item item)
        {
            item = bal.Update(item);
            return Ok(item);
        }
        [HttpPut]
        
        public IActionResult Delete(Item item)
        {
            item = bal.Delete(item);
            return Ok(item);
        }
    }
}
