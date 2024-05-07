using System;
using NUnit.Framework;
using SwinAdventure;

namespace SwinAdventure
{
    [TestFixture]

    public class TestInventory
    {
        Item shield;
        Item gem;
        Inventory newInventory;
        
        [SetUp]
        public void SetUp()
        {
            shield = new Item(new string[] { "shield" }, "a shield", "this is a shield");
            gem = new Item(new string[] { "gem" }, "a gem", "this is a gem");
            newInventory = new Inventory();

        }

        [Test]
        public void TestFindItem()
        {
            newInventory.Put(shield);
            bool expected = true;
            bool actual = newInventory.HasItem("shield");

            Assert.AreEqual(expected, actual);


        }

        [Test]
        public void TestNoItemFind()
        {
            newInventory.Put(shield);

            bool expected = false;
            bool actual = newInventory.HasItem("randomitem");

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestFetchItem()
        {
            newInventory.Put(shield);
            bool expected = true;

            Assert.That(newInventory.Fetch("shield"), Is.EqualTo(shield));

            newInventory.Fetch("shield");
            bool actual = newInventory.HasItem("shield");

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestTakeItem()
        {
            newInventory.Put(shield);
            bool expected = false;

                           
            Assert.That(newInventory.Take("shield"), Is.EqualTo(shield));

            newInventory.Take("shield");
            bool actual = newInventory.HasItem("shield");

            Assert.AreEqual(expected, actual);
            

        }

        [Test]
        public void TestItemList()
        {
            newInventory.Put(shield);
            newInventory.Put(gem);

            string listoutput = $"{shield.ShortDescription}\n\t{gem.ShortDescription}\n\t";

            Assert.That(newInventory.ItemList, Is.EqualTo(listoutput));


        }
    }
}