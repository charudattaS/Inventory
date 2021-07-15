﻿using BusinessLogics.TransactionBal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class ItemStockTransactionTest
    {
        private readonly Mock<ItemStockTransaction> _bal = new Mock<ItemStockTransaction>();
        Item _mockItemObj = new Item();
        ItemCostDetails _mockItemCost = new ItemCostDetails();
        ItemTrans trans = new ItemTrans();
        int PurchaseIn = 10;
        int PurchaseOut = 0;
        Guid first = Guid.Parse("08b6e0d5-1a58-48f3-b90d-fd915850bf0a");
       
        public ItemStockTransactionTest()
        {
            TestDataSetup();
        }
        private void TestDataSetup()
        {
            trans.item = _mockItemObj;
            trans.itemCostDetails = _mockItemCost;
            _mockItemObj.Id = Guid.Empty;
            _mockItemObj.Name = "Pencil";
            _mockItemObj.ItemCategoryId = Guid.NewGuid();
            _mockItemObj.PurchaseIn = PurchaseIn;
            _mockItemObj.PurchaseOut = PurchaseOut;
            _mockItemObj.IsUsed = true;


            _mockItemCost.Id = Guid.Empty;
            _mockItemCost.Cost = 32500;
            _mockItemCost.ItemId = Guid.NewGuid();
        }

        [TestMethod]
        public void Insert_ItemStockTransaction_Test()
        {
            //Arrange
            trans.item.Id =  first;
            trans.itemCostDetails.ItemId = trans.item.Id;
            trans.itemCostDetails.Id = _mockItemCost.Id;
            _bal.Setup(x => x.Insert(trans)).Returns(trans);

            //Act
            var respose = _bal.Object.Insert(trans);

            //Asert
            Assert.AreEqual(respose.item.Id, first);
            Assert.IsTrue(respose.item.PurchaseIn>0);
            Assert.IsTrue(respose.itemCostDetails.Cost > 0);
            Assert.IsNotNull(respose);
        }

        [TestMethod]
        public void Update_ItemStockTransaction_Test()
        {
            //Arrange
            trans.item.Id =  first;
            PurchaseOut = 2;
            trans.item.PurchaseIn = PurchaseIn-PurchaseOut;
            trans.item.PurchaseOut = PurchaseOut;
            trans.itemCostDetails.ItemId = trans.item.Id;
            trans.itemCostDetails.Id = _mockItemCost.Id;
            _bal.Setup(x => x.Update(trans)).Returns(trans);

            //Act
            var respose = _bal.Object.Update(trans);

            //Asert
            Assert.AreEqual(respose.item.Id, first);
            Assert.IsTrue(respose.itemCostDetails.Cost > 0);
            Assert.IsTrue(respose.item.PurchaseIn>-1);
            Assert.IsTrue(respose.item.PurchaseOut>-1);
            Assert.IsNotNull(respose);
        }
    }
}
