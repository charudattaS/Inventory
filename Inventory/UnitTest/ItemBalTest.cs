using BusinessLogics.Bal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class ItemBalTest
    {
        private readonly Mock<ItemBal> _bal = new Mock<ItemBal>();
        List<Item> _mockList = new List<Item>();
        Item _mockObj = new Item();
        Guid first = Guid.Parse("08b6e0d5-1a58-48f3-b90d-fd915850bf0a");
        Guid second = Guid.Parse("a8b6e0d5-1a58-48f3-b90d-fd915850bf0a");
        Guid firstItemCategory = Guid.Parse("b8b6e0d5-1a58-48f3-b90d-fd915850bf0a");
        Guid secondItemCategory = Guid.Parse("c8b6e0d5-1a58-48f3-b90d-fd915850bf0a");
        public ItemBalTest()
        {
            TestDataSetup();
        }
        private void TestDataSetup()
        {

            _mockList.Add(new Item
            {
                Id = first,
                Name = "water-melon",
                ItemCategoryId = firstItemCategory,
                PurchaseIn = 10,
                PurchaseOut = 2,
                IsUsed = true
            });

            _mockList.Add(new Item
            {
                Id = Guid.NewGuid(),
                Name = "iPhone",
                ItemCategoryId = Guid.NewGuid(),
                PurchaseIn = 10,
                PurchaseOut = 2,
                IsUsed = true
            });


            _mockObj.Id = Guid.Empty;
            _mockObj.Name = "Pencil";
            _mockObj.ItemCategoryId = Guid.NewGuid();
            _mockObj.PurchaseIn = 10;
            _mockObj.PurchaseOut = 0;
            _mockObj.IsUsed = true;
        }

        [TestMethod]
        public void Get_ItemList_Test()
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
        public void AddStock_Item_Test()
        {
            //Arrange
            _mockObj.Id = Guid.Parse("74016ce7-70c0-4ee2-a430-46c9ade4cd27");
            _bal.Setup(x => x.AddStock(_mockObj)).Returns(_mockObj);

            //Act
            var respose = _bal.Object.AddStock(_mockObj);

            //Asert
            Assert.AreEqual(respose.Id, Guid.Parse("74016ce7-70c0-4ee2-a430-46c9ade4cd27"));
            Assert.IsTrue(respose.PurchaseIn > 0);
            Assert.IsTrue(respose.PurchaseOut < 1);
            Assert.IsNotNull(respose);
        }

        [TestMethod]
        public void ConsumeStock_Item_Test()
        {
            //Arrange
            _mockObj.Id = Guid.Parse("74016ce7-70c0-4ee2-a430-46c9ade4cd27");
            _mockObj.PurchaseOut = 2;
            if (_mockObj.PurchaseIn > _mockObj.PurchaseOut)
            {
                _mockObj.PurchaseIn = _mockObj.PurchaseIn - _mockObj.PurchaseOut;
            }
            _bal.Setup(x => x.ConsumeStock(_mockObj)).Returns(_mockObj);

            //Act
            var respose = _bal.Object.ConsumeStock(_mockObj);

            //Asert
            Assert.AreEqual(respose.Id, Guid.Parse("74016ce7-70c0-4ee2-a430-46c9ade4cd27"));
            Assert.IsTrue(respose.PurchaseOut > 0);
            Assert.IsNotNull(respose);
        }

        [TestMethod]
        public void Insert_Item_Test()
        {
            //Arrange
            _mockObj.Id = Guid.Parse("74016ce7-70c0-4ee2-a430-46c9ade4cd27");
            _mockObj.PurchaseOut = 2;

            _bal.Setup(x => x.Insert(_mockObj)).Returns(_mockObj);

            //Act
            var respose = _bal.Object.Insert(_mockObj);

            //Asert
            Assert.AreEqual(respose.Id, Guid.Parse("74016ce7-70c0-4ee2-a430-46c9ade4cd27"));
            Assert.IsTrue(respose.PurchaseOut > 0);
            Assert.IsNotNull(respose);
        }

        [TestMethod]
        public void Update_Item_Test()
        {
            //Arrange
            _mockObj.Id = Guid.Parse("74016ce7-70c0-4ee2-a430-46c9ade4cd27");
            _mockObj.PurchaseIn = 5;

            _bal.Setup(x => x.Update(_mockObj)).Returns(_mockObj);

            //Act
            var respose = _bal.Object.Update(_mockObj);

            //Asert
            Assert.AreEqual(respose.Id, Guid.Parse("74016ce7-70c0-4ee2-a430-46c9ade4cd27"));
            Assert.IsTrue(respose.PurchaseIn - _mockObj.PurchaseOut >= 0);
            Assert.IsNotNull(respose);
        }
        [TestMethod]
        public void Delete_Item_Test()
        {
            //Arrange
            _mockObj.Id = Guid.Parse("74016ce7-70c0-4ee2-a430-46c9ade4cd27");
            _mockObj.IsUsed = false;

            _bal.Setup(x => x.Delete(_mockObj)).Returns(_mockObj);

            //Act
            var respose = _bal.Object.Delete(_mockObj);

            //Asert
            Assert.AreEqual(respose.Id, Guid.Parse("74016ce7-70c0-4ee2-a430-46c9ade4cd27"));
            Assert.IsTrue(!respose.IsUsed);
            Assert.IsNotNull(respose);
        }
        [TestMethod]
        public void GetById_Item_Test()
        {
            //Arrange
            _bal.Setup(x => x.GetById(first,true)).Returns(_mockList.Where(y=>y.Id==first).FirstOrDefault());

            //Act
            var respose = _bal.Object.GetById(first, true);

            //Asert
            Assert.AreEqual(respose.Id, Guid.Parse("08b6e0d5-1a58-48f3-b90d-fd915850bf0a"));
            Assert.IsTrue(respose.IsUsed);
            Assert.IsNotNull(respose);
        }

    }
}
