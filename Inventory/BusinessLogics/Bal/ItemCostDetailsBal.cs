using DalAccess.IDal;
using DalAccess.PgsqlDal;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogics.Bal
{
  public  class ItemCostDetailsBal
    {
        private IItemCostDetails dal;
        public ItemCostDetailsBal(IItemCostDetails dal)
        {
            this.dal = dal;
        }

        public List<ItemCostDetails> Get(bool IsUsed = true)
        {
            List<ItemCostDetails> List = new List<ItemCostDetails>();
            List = dal.Fetch();
            return List;
        }

        public ItemCostDetails Insert(ItemCostDetails itemCostDetails)
        {
            itemCostDetails.IsUsed = true;
            itemCostDetails = dal.Insert(itemCostDetails);
            return itemCostDetails;
        }

        public ItemCostDetails Update(ItemCostDetails itemCostDetails)
        {

            itemCostDetails.IsUsed = true;
            itemCostDetails = dal.Update(itemCostDetails);
           
            return itemCostDetails;
        }
        public ItemCostDetails Delete(ItemCostDetails itemCostDetails)
        {

            itemCostDetails.IsUsed = false;
            itemCostDetails = dal.Update(itemCostDetails);
            
            return itemCostDetails;
        }

        public ItemCostDetails GetByItemId(Guid ItemId, bool IsUsed = true)
        {
            ItemCostDetails data = new ItemCostDetails();
            data = dal.FetchByItemId(ItemId);
            return data;
        }

       
    }
}
