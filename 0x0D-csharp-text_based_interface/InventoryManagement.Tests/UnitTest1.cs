using NUnit.Framework;
using System.ComponentModel;
using System;

namespace InventoryLibrary.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            BaseClass new_base = new BaseClass();
            foreach(PropertyDescriptor descriptor in TypeDescriptor.GetProperties(new_base))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(new_base);
                Console.WriteLine("{0}={1}", name, value);
            }
            // new_base.id = "123";
            // new_base.date_created = Datetime.Now;
            // new_base.date_updated = Datetime.Now;
            // Assert.AreEqual(new_base.id, "123");
        }
    }
}
