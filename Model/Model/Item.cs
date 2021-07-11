using Model;
using System;

public class Item: CommonProperties
{

    

    public String Name { get; set; }
    public String ItemCategoryName { get; set; }
    public Guid ItemCategoryId { get; set; }
    public Int32 Stock { get; set; }
    public Int32 PurchaseIn { get; set; }
    public Int32 PurchaseOut { get; set; }
    public bool IsComsumed { get; set; }
}