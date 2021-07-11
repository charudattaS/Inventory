using BusinessLogics.Bal;
using BusinessLogics.TransactionBal;
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
    public class ItemStockTransactionController : ControllerBase
    {
        private ItemStockTransaction bal;
        private ItemBal itembal;
        public ItemStockTransactionController(ItemStockTransaction bal, ItemBal itembal)
        {
            this.bal = bal;
            this.itembal = itembal;
        }

        [HttpPost]
        public IActionResult Post(ItemTrans itemTrans)
        {
            if (!itemTrans.item.IsDeleted)
            {
                itemTrans = bal.Insert(itemTrans);
            }
            else 
            {
                itembal.Delete(itemTrans.item);
            }
            
            return Ok(itemTrans);
        }


        

        [HttpPut]
       
        public IActionResult Put(ItemTrans itemTrans)
        {
            itemTrans = bal.Update(itemTrans);
            return Ok(itemTrans);
        }

        [HttpPost]
        public IActionResult ItemStockEffect(ItemTrans itemTrans)
        {
            itemTrans = bal.Insert(itemTrans);
            return Ok(itemTrans);
        }
        [HttpGet]
        [Route("{ItemId}")]
        public IActionResult GetByItemId(Guid ItemId)
        {
            ItemTrans itemTrans = new ItemTrans();
            itemTrans = bal.GetByItemId(ItemId);
            return Ok(itemTrans);
        }
    }
}
