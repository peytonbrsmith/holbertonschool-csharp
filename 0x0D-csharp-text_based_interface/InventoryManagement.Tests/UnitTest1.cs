using NUnit.Framework;
using System.ComponentModel;
using System;
using System.Reflection;
using System.Collections.Generic;
namespace InventoryLibrary.Tests
{
    public class Tests
    {
        static BaseClass new_base = new BaseClass();
        static Item new_item = new Item();
        static User new_user = new User("Test User");
        static Inventory new_inventory = new Inventory(new_user.Id, new_item.Id);

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Base_Create()
        {

            Guid base_guid;
            Assert.AreEqual(Guid.TryParse(new_base.Id, out base_guid), true);
            Assert.AreEqual(new_base.Date_created.GetType(), typeof(DateTime));
            Assert.AreEqual(new_base.Date_updated.GetType(), typeof(DateTime));
        }

        [Test]
        public void Test_Item_Create()
        {

            Guid base_guid;
            Assert.AreEqual(Guid.TryParse(new_item.Id, out base_guid), true);
            Assert.AreEqual(new_item.Date_created.GetType(), typeof(DateTime));
            Assert.AreEqual(new_item.Date_updated.GetType(), typeof(DateTime));
            new_item.Name = "Test Item";
            Assert.AreEqual(new_item.Name, "Test Item");
            new_item.Price = 10.00f;
            Assert.AreEqual(new_item.Price, 10.00);
            new_item.Description = "Test Description";
            Assert.AreEqual(new_item.Description, "Test Description");
            List<string> tags = new List<string>();
            tags.Add("Test Tag");
            tags.Add("Test Tag2");
            tags.Add("Test Tag3");
            new_item.Tags = tags;
            Assert.AreEqual(new_item.Tags.Count, 3);
        }


        [Test]
        public void Test_User_Create()
        {
            Guid base_guid;
            Assert.AreEqual(Guid.TryParse(new_user.Id, out base_guid), true);
            Assert.AreEqual(new_user.Date_created.GetType(), typeof(DateTime));
            Assert.AreEqual(new_user.Date_updated.GetType(), typeof(DateTime));
            Assert.AreEqual(new_user.Name, "Test User");
            new_user.Name = "New User Name";
            Assert.AreEqual(new_user.Name, "New User Name");
        }

        [Test]
        public void Test_Inventory_Create()
        {
            Guid base_guid;
            Assert.AreEqual(Guid.TryParse(new_inventory.Id, out base_guid), true);
            Assert.AreEqual(new_inventory.Date_created.GetType(), typeof(DateTime));
            Assert.AreEqual(new_inventory.Date_updated.GetType(), typeof(DateTime));
            Assert.AreEqual(new_inventory.User_id, new_user.Id);
            Assert.AreEqual(new_inventory.Item_id, new_item.Id);
            Assert.AreEqual(new_inventory.Quantity, 1);
            new_inventory.Quantity = 10;
            Assert.AreEqual(new_inventory.Quantity, 10);
        }
    }
}
