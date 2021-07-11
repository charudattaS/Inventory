using BusinessLogics.Bal;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogics.TransactionBal
{
   public class ItemStockTransaction
    {
        private ItemBal itembal;
        private ItemCostDetailsBal itemCostDetailsBal;

        public ItemStockTransaction(ItemBal itembal, ItemCostDetailsBal itemCostDetailsBal)
        {
            this.itembal = itembal;
            this.itemCostDetailsBal = itemCostDetailsBal;

        }
        public ItemTrans Insert(ItemTrans itemTrans)
        {
            itemTrans.item.IsUsed = itemTrans.item.IsDeleted== true?false:true;
            itemTrans.item=itembal.Insert(itemTrans.item);
            if (itemTrans.itemCostDetails == null) 
            {
                itemTrans.itemCostDetails = new ItemCostDetails();
            }
            itemTrans.itemCostDetails.ItemId = itemTrans.item.Id;
            itemTrans.itemCostDetails.IsUsed = itemTrans.item.IsDeleted == true ? false : true;
            itemTrans.itemCostDetails = itemCostDetailsBal.Insert(itemTrans.itemCostDetails);
            return itemTrans;
        }

        public ItemTrans Update(ItemTrans itemTrans)
        {

            if (itemTrans.item.IsComsumed)
            {
                itemTrans.item=itembal.ConsumeStock(itemTrans.item);
            }
            else 
            {
                itemTrans.item = itembal.AddStock(itemTrans.item);
            }
            return itemTrans;
        }

       

        public ItemTrans GetByItemId(Guid ItemId)
        {
            ItemTrans itemTrans = new ItemTrans();
            itemTrans.item= itembal.GetById(ItemId);
            itemTrans.itemCostDetails=itemCostDetailsBal.GetByItemId(ItemId);
            return itemTrans;
        }

       
    }
}
