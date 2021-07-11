using DalAccess.IDal;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogics.Bal
{
    public class ItemBal
    {
        private IItem dal;
        public ItemBal(IItem dal)
        {
            this.dal = dal;
        }
        public Item AddStock(Item Item) 
        {
            Item=dal.AddStock(Item);
            return Item;
        }
        public Item ConsumeStock(Item Item)
        {
            Item=dal.ConsumeStock(Item);
            return Item;
        }
         
        public List<Item> Get( bool IsUsed = true)
        {
            List<Item> List = new List<Item>();
            List = dal.Fetch();
            return List;
        }

        public Item Insert(Item item)
        {
            item.IsUsed = true;
            item = dal.Insert(item);
            return item;
        }

        public Item Update(Item item)
        {
           
            item.IsUsed = true;
            item = dal.Update(item);
          
            return item;
        }
        public Item Delete(Item item)
        {
                item.IsUsed = false;
                item = dal.Delete(item);
           
            return item;
        }

        public Item GetById(Guid Id, bool IsUsed = true)
        {
            Item data = new Item();
            data = dal.FetchById(Id);
            data.Stock = data.PurchaseIn - data.PurchaseOut;
            return data;
        }
    }
}
