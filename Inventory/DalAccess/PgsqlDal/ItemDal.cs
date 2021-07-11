using DalAccess.IDal;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace DalAccess.PgsqlDal
{
    public class ItemDal : IItem
    {
        private readonly IConfiguration con;
        string dbconnection;
        public ItemDal(IConfiguration config)
        {
            con = config;
            dbconnection = con.GetConnectionString("Pgsql");
        }

        public Item AddStock(Item Item)
        {
            try
            {
                using (NpgsqlConnection bridge = new NpgsqlConnection(dbconnection))
                {
                    bridge.Open();
                    using (NpgsqlCommand com = bridge.CreateCommand())
                    {
                        com.CommandType = System.Data.CommandType.Text;
                        com.CommandText = @"update itemdemo 
                        set purchasein=(select purchasein from itemdemo where id=@id)+@purchaseIn 
                        where  id=@id";
                        com.Parameters.AddWithValue("@id", Item.Id);
                        com.Parameters.AddWithValue("@isused", Item.IsUsed);
                        com.Parameters.AddWithValue("@purchaseIn", Item.PurchaseIn);
                        com.ExecuteScalar();

                    }
                    bridge.Close();
                }
            }
            catch (Exception)
            {


            }

            return Item;
        }

        public Item ConsumeStock(Item Item)
        {
            try
            {
                using (NpgsqlConnection bridge = new NpgsqlConnection(dbconnection))
                {
                    bridge.Open();
                    using (NpgsqlCommand com = bridge.CreateCommand())
                    {
                        com.CommandType = System.Data.CommandType.Text;
                        com.CommandText = @"update itemdemo 
                        set purchaseout=((select purchaseout from itemdemo where id=@id)+@purchaseOut)
                        where id=@id";
                        com.Parameters.AddWithValue("@id", Item.Id);
                        com.Parameters.AddWithValue("@isused", Item.IsUsed);
                        com.Parameters.AddWithValue("@purchaseOut", Item.PurchaseOut);
                        com.ExecuteScalar();

                    }
                    bridge.Close();
                }
            }
            catch (Exception)
            {


            }

            return Item;
        }

        public Item Delete(Item item)
        {
            try
            {
                using (NpgsqlConnection bridge = new NpgsqlConnection(dbconnection))
                {
                    bridge.Open();
                    using (NpgsqlCommand com = bridge.CreateCommand())
                    {
                        com.CommandType = System.Data.CommandType.Text;
                        com.CommandText = @"UPDATE public.itemdemo
	                                    SET   isactive=@isused
	                                    WHERE id=@id;";
                        com.Parameters.AddWithValue("@id", item.Id);
                        com.Parameters.AddWithValue("@isused", item.IsUsed);
                      com.ExecuteScalar();

                    }
                    bridge.Close();
                }
            }
            catch (Exception)
            {


            }

            return item;
        }

        public List<Item> Fetch( bool IsUsed = true)
        {
            List<Item> itemList = new List<Item>();
            using (NpgsqlConnection bridge = new NpgsqlConnection(dbconnection))
            {
                bridge.Open();
                using (NpgsqlCommand com = bridge.CreateCommand())
                {
                    com.CommandType = System.Data.CommandType.Text;
                    com.CommandText = @"select 
                                    ic.name as itemcategoryname,
                                    i.name,
                                    i.purchasein-i.purchaseout as stock,
                                    i.purchasein,
                                    i.purchaseout ,
                                    i.id
                                    from 
                                    itemcategorydemo ic
                                    inner join itemdemo i on i.itemcategorydemoid=ic.id 
                                    where i.purchasein>0 and (i.purchasein-i.purchaseout)>0 and i.isactive=@isused";
                    com.Parameters.AddWithValue("@isused", IsUsed);
                    NpgsqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {

                        itemList.Add(new Item()
                        {
                            Id = dr.GetGuid(dr.GetOrdinal("id")),
                            PurchaseIn = dr.GetInt32(dr.GetOrdinal("purchasein")),
                            PurchaseOut = dr.GetInt32(dr.GetOrdinal("purchaseout")),
                            Name = dr.GetString(dr.GetOrdinal("name")),
                            Stock= dr.GetInt32(dr.GetOrdinal("stock")),
                            ItemCategoryName = dr.GetString(dr.GetOrdinal("itemCategoryname")),
                        });


                    }
                }
                bridge.Close();
            }

            return itemList;
        }

        public Item FetchById(Guid Id, bool IsUsed = true)
        {
            Item item = new Item();
            using (NpgsqlConnection bridge = new NpgsqlConnection(dbconnection))
            {
                bridge.Open();
                using (NpgsqlCommand com = bridge.CreateCommand())
                {
                    com.CommandType = System.Data.CommandType.Text;
                    com.CommandText = @"Select T.*,ic.name as itemCategoryname from itemdemo T
                                        inner join itemCategorydemo ic on ic.id=T.itemcategorydemoId and ic.isactive=@isused
                                        where T.isactive=@isused and T.id=@id";
                    com.Parameters.AddWithValue("@isused", IsUsed);
                    com.Parameters.AddWithValue("@id", Id);
                    NpgsqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        item.Id = dr.GetGuid(dr.GetOrdinal("id"));
                        item.Name = dr.GetString(dr.GetOrdinal("name"));
                        item.PurchaseIn = dr.GetInt32(dr.GetOrdinal("purchasein"));
                        item.PurchaseOut = dr.GetInt32(dr.GetOrdinal("purchaseout"));
                        item.IsUsed = dr.GetBoolean(dr.GetOrdinal("isactive"));
                        item.ItemCategoryName = dr.GetString(dr.GetOrdinal("itemCategoryname"));
                        item.ItemCategoryId = dr.GetGuid(dr.GetOrdinal("itemcategorydemoid"));
                    }
                }
                bridge.Close();
            }

            return item;
        }

        public Item Insert(Item item)
        {
            try
            {
                using (NpgsqlConnection bridge = new NpgsqlConnection(dbconnection))
                {
                    bridge.Open();
                    using (NpgsqlCommand com = bridge.CreateCommand())
                    {
                        com.CommandType = System.Data.CommandType.Text;
                        com.CommandText = @"INSERT INTO public.itemdemo(
	                                        id, name, itemcategorydemoid, purchasein, purchaseout, isactive)
	                                        VALUES (@id, @name, @itemCategoryId, @purchaseIn, @purchaseOut, @isused) RETURNING id;";
                        com.Parameters.AddWithValue("@id", Guid.NewGuid());
                        com.Parameters.AddWithValue("@isused", item.IsUsed);
                        com.Parameters.AddWithValue("@itemCategoryId", item.ItemCategoryId);
                        com.Parameters.AddWithValue("@purchaseIn", item.PurchaseIn);
                        com.Parameters.AddWithValue("@purchaseOut", 0);
                        com.Parameters.AddWithValue("@name", item.Name);

                        var r = com.ExecuteScalar();
                        item.Id = new Guid(r.ToString());

                    }
                    bridge.Close();
                }
            }
            catch (Exception )
            {


            }

            return item;
        }

        public Item Update(Item item)
        {
            try
            {
                using (NpgsqlConnection bridge = new NpgsqlConnection(dbconnection))
                {
                    bridge.Open();
                    using (NpgsqlCommand com = bridge.CreateCommand())
                    {
                        com.CommandType = System.Data.CommandType.Text;
                        com.CommandText = @"UPDATE public.itemdemo
	                                    SET  name=@name,isactive=@isused
	                                    WHERE id=@id;";
                        com.Parameters.AddWithValue("@id", item.Id);
                        com.Parameters.AddWithValue("@isused", item.IsUsed);
                        
                        com.Parameters.AddWithValue("@name", item.Name);

                        com.ExecuteScalar();

                    }
                    bridge.Close();
                }
            }
            catch (Exception)
            {


            }

            return item;
        }
    }
}
