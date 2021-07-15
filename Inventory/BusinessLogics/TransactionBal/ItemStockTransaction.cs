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
        public ItemStockTransaction()
        {
            
        }
        public virtual ItemTrans Insert(ItemTrans itemTrans)
        {
            if (itemTrans.itemCostDetails.Cost > 0)
            {
                itemTrans.item.IsUsed = itemTrans.item.IsDeleted == true ? false : true;
                itemTrans.item = itembal.Insert(itemTrans.item);
                if (itemTrans.itemCostDetails == null)
                {
                    itemTrans.itemCostDetails = new ItemCostDetails();
                }
                itemTrans.itemCostDetails.ItemId = itemTrans.item.Id;
                itemTrans.itemCostDetails.IsUsed = itemTrans.item.IsDeleted == true ? false : true;
                itemTrans.itemCostDetails = itemCostDetailsBal.Insert(itemTrans.itemCostDetails);
            }
            else
            {
                itemTrans.item.Errors.Add("Only Positive Cost Are Allowed.");
            }
            if (itemTrans.item.PurchaseIn < 1 && itemTrans.item.PurchaseOut < 1)
            {
                itemTrans.item.Errors.Add("Only Positive Stock And Consuption Allowed.");
            }
            return itemTrans;
        }

        public virtual ItemTrans Update(ItemTrans itemTrans)
        {


            if (itemTrans.item.IsComsumed)
            {
                if (itemTrans.item.PurchaseOut > 0)
                {
                    itemTrans.item = itembal.ConsumeStock(itemTrans.item);
                }
                else
                {
                    itemTrans.item.Errors.Add("Only Positive Stock And Consuption Allowed.");
                }

            }
            else
            {
                if (itemTrans.item.PurchaseIn > 0)
                {
                    itemTrans.item = itembal.AddStock(itemTrans.item);
                }
                else
                {
                    itemTrans.item.Errors.Add("Only Positive Stock And Consuption Allowed.");
                }
            }







            return itemTrans;
        }



        public virtual ItemTrans GetByItemId(Guid ItemId)
        {
            ItemTrans itemTrans = new ItemTrans();
            itemTrans.item = itembal.GetById(ItemId);
            itemTrans.itemCostDetails = itemCostDetailsBal.GetByItemId(ItemId);
            return itemTrans;
        }


    }
}
