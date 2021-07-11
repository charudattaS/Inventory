using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DalAccess.IDal
{
    public interface IItemCostDetails
    {
        #region CURD

        ItemCostDetails Insert(ItemCostDetails itemCostDetails);
        ItemCostDetails Update(ItemCostDetails itemCostDetails);
        ItemCostDetails Delete(ItemCostDetails itemCostDetails);

        #endregion
        List<ItemCostDetails> Fetch(bool IsUsed = true);
        ItemCostDetails FetchByItemId(Guid ItemId, bool IsUsed = true);
    }
}
