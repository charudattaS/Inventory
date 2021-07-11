using DalAccess.IDal;
using Microsoft.Extensions.Configuration;
using Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace DalAccess.PgsqlDal
{
    public class ItemCostDetailsDal : IItemCostDetails
    {
        private readonly IConfiguration con;

        string dbconnection;
        public ItemCostDetailsDal(IConfiguration config)
        {
            con = config;
            dbconnection = con.GetConnectionString("Pgsql");
        }
        public ItemCostDetails Delete(ItemCostDetails itemCostDetails)
        {
            try
            {
                using (NpgsqlConnection bridge = new NpgsqlConnection(dbconnection))
                {
                    bridge.Open();
                    using (NpgsqlCommand com = bridge.CreateCommand())
                    {
                        com.CommandType = System.Data.CommandType.Text;
                        com.CommandText = @"UPDATE public.itemcostdetails
	                                        SET  isactive=@isused
	                                        WHERE id=@id;";
                        com.Parameters.AddWithValue("@id", itemCostDetails.Id);
                        com.Parameters.AddWithValue("@isused", false);
                        com.ExecuteScalar();

                    }
                    bridge.Close();
                }
            }
            catch (Exception)
            {


            }
           
            return itemCostDetails;
        }

        public List<ItemCostDetails> Fetch(bool IsUsed = true)
        {
            List<ItemCostDetails> itemCostDetails = new List<ItemCostDetails>();
            using (NpgsqlConnection bridge = new NpgsqlConnection(dbconnection))
            {
                bridge.Open();
                using (NpgsqlCommand com = bridge.CreateCommand())
                {
                    com.CommandType = System.Data.CommandType.Text;
                    com.CommandText = @"Select * from itemcostdetails where isactive=@isused";
                    com.Parameters.AddWithValue("@isused", IsUsed);
                    NpgsqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {


                        itemCostDetails.Add(new ItemCostDetails()
                        {
                            Id = dr.GetGuid(dr.GetOrdinal("id")),
                            ItemId = dr.GetGuid(dr.GetOrdinal("itemid")),
                            Cost = dr.GetDouble(dr.GetOrdinal("name")),
                            IsUsed = dr.GetBoolean(dr.GetOrdinal("isactive")),
                        });


                    }
                }
                bridge.Close();
            }

            return itemCostDetails;
        }

        public ItemCostDetails FetchByItemId(Guid ItemId, bool IsUsed = true)
        {
            ItemCostDetails itemCostDetails = new ItemCostDetails();
            using (NpgsqlConnection bridge = new NpgsqlConnection(dbconnection))
            {
                bridge.Open();
                using (NpgsqlCommand com = bridge.CreateCommand())
                {
                    com.CommandType = System.Data.CommandType.Text;
                    com.CommandText = @"Select * from itemcostdetails where isactive=@isused and itemid=@id";
                    com.Parameters.AddWithValue("@isused", IsUsed);
                    com.Parameters.AddWithValue("@id", ItemId);
                    NpgsqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        itemCostDetails.Id = dr.GetGuid(dr.GetOrdinal("id"));
                        itemCostDetails.Cost = dr.GetDouble(dr.GetOrdinal("cost"));
                        itemCostDetails.IsUsed = dr.GetBoolean(dr.GetOrdinal("isactive"));
                    }
                }
                bridge.Close();
            }

            return itemCostDetails;
        }

        public ItemCostDetails Insert(ItemCostDetails itemCostDetails)
        {
            try
            {

                using (NpgsqlConnection bridge = new NpgsqlConnection(dbconnection))
                {
                    bridge.Open();
                    using (NpgsqlCommand com = bridge.CreateCommand())
                    {
                        com.CommandType = System.Data.CommandType.Text;
                                            com.CommandText = @"INSERT INTO public.itemcostdetails(
	                    id, itemid, cost, isactive)
	                    VALUES (@id, @itemId, @cost, @isused) RETURNING id;";
                        com.Parameters.AddWithValue("@id", Guid.NewGuid());
                        com.Parameters.AddWithValue("@isused", true);
                        com.Parameters.AddWithValue("@cost", itemCostDetails.Cost);
                        com.Parameters.AddWithValue("@itemId", itemCostDetails.ItemId);
                        var r = com.ExecuteScalar();
                        itemCostDetails.Id = new Guid(r.ToString());
                    }
                    bridge.Close();
                }
            }
            catch (Exception)
            {


            }

            return itemCostDetails;
        }

        public ItemCostDetails Update(ItemCostDetails itemCostDetails)
        {
            try
            {
                using (NpgsqlConnection bridge = new NpgsqlConnection(dbconnection))
                {
                    bridge.Open();
                    using (NpgsqlCommand com = bridge.CreateCommand())
                    {
                        com.CommandType = System.Data.CommandType.Text;
                        com.CommandText = @"UPDATE public.itemcostdetails
	                                        SET id=@id, itemid=@itemId, cost=@cost, isactive=@isused
	                                       WHERE id=@id;";

                        com.Parameters.AddWithValue("@id", itemCostDetails.Id);
                        com.Parameters.AddWithValue("@isused", itemCostDetails.IsUsed);
                        com.Parameters.AddWithValue("@itemId", itemCostDetails.ItemId);
                        com.Parameters.AddWithValue("@cost", itemCostDetails.Cost);

                        com.ExecuteScalar();

                    }
                    bridge.Close();
                }
            }
            catch (Exception)
            {


            }

            return itemCostDetails;
        }
    }
}
