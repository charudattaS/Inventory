﻿using BusinessLogics.Bal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class ItemCostDetailsBalTest
    {
        private readonly Mock<ItemCostDetailsBal> _bal = new Mock<ItemCostDetailsBal>();
        List<ItemCostDetails> _mockList = new List<ItemCostDetails>();
        ItemCostDetails _mock = new ItemCostDetails();

        Guid first = Guid.Parse("71528eac-8259-4751-8898-7af98946a334");
        Guid second = Guid.Parse("11528eac-8259-4751-8898-7af98946a334");
        Guid itemId = Guid.Parse("51528eac-8259-4751-8898-7af98946a334");
        public ItemCostDetailsBalTest()
        {
            TestDataSetup();
        }

        private void TestDataSetup()
        {
            _mockList.Add(new ItemCostDetails
            {
                Id = first,
                Cost = 2500,
                ItemId = itemId
            });
            _mockList.Add(new ItemCostDetails
            {
                Id = Guid.NewGuid(),
                Cost = 32500,
                ItemId = Guid.NewGuid()
            });

            _mock.Id = Guid.Empty;
            _mock.Cost = 32500;
            _mock.ItemId = Guid.NewGuid();
        }


        [TestMethod]
        public void Get_ItemCostDetails_Test()
        {
            //Arrange
            _bal.Setup(x => x.Get(true)).Returns(_mockList);

            //Act
            var respose = _bal.Object.Get();

            //Asert
            Assert.AreEqual(_mockList, respose);
            Assert.IsNotNull(respose);
        }


        [TestMethod]
        public void GetByItemId_ItemCostDetails_Test()
        {
            //Arrange
            _bal.Setup(x => x.GetByItemId(itemId, true)).Returns(_mockList.Where(y => y.ItemId == itemId).FirstOrDefault());

            //Act
            var respose = _bal.Object.GetByItemId(itemId, true);

            //Asert
            Assert.AreEqual(_mockList.Where(y => y.ItemId == itemId).FirstOrDefault(), respose);
            Assert.IsNotNull(respose);
        }

        [TestMethod]
        public void Insert_ItemCostDetails_Test()
        {
            //Arrange
            _mock.Id = second;
            _mock.ItemId = itemId;
            _bal.Setup(x => x.Insert(_mock)).Returns(_mock);

            //Act
            var respose = _bal.Object.Insert(_mock);

            //Asert
            Assert.IsTrue(respose.Id != Guid.Empty);
            Assert.IsTrue(respose.Cost >0);
            Assert.IsNotNull(respose);
        }
    }
}
