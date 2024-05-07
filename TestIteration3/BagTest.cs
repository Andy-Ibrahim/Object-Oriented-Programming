using System;
using System.Numerics;
using System.Xml.Linq;
using NUnit.Framework;
using SwinAdventure;

namespace SwinAdventureTest
{
    [TestFixture]

    public class TestBag
    {

        Item axe;
        Item chair;
        Bag b1;
        Bag b2;


        [SetUp]
        public void SetUp()
        {
            axe = new Item(new string[] { "axe" }, "an axe", "this is an axe");
            chair = new Item(new string[] { "chair" }, "a chair", "this is a chair");
            b1 = new Bag(new string[] { "bag1" }, "a bag1", "This is a bag1");
            b2 = new Bag(new string[] { "bag2" }, "a bag2", "This is a bag2");
            b1.Inventory.Put(axe);
            
        }

        [Test]
        public void TestBagLocatesItem()
        {
            Assert.AreEqual(b1.Locate("axe"), axe);

            bool expected = true;
            bool actual = b1.Inventory.HasItem("axe");


            Assert.AreEqual(actual, expected);

          
        }

        [Test]
        public void TestBagLocatesItsSelf()
        {
            b1.Inventory.Put(b2);
            Assert.AreEqual(b2.Locate("bag2"), b2);


        }

        [Test]
        public void TestBagLocatesNothing()
        {
            Assert.IsNull(b1.Locate("synth"));
        }


        [Test]
        public void TestBagFullDescriotion()
        {
            string expectedstring = "in the a bag1 you can see: an axe (axe)";
            Assert.AreEqual(b1.FullDescription, expectedstring);

        }

        [Test]
        public void TestBagInBag()
        {
            Item armour = new Item(new string[] { "armour" }, "an armour", "this is an armour");

            b2.Inventory.Put(armour);
            b1.Inventory.Put(chair);
            b1.Inventory.Put(b2);

            Assert.AreEqual(b2, b1.Locate("bag2"));

            Assert.AreEqual(axe, b1.Locate("axe"));

            Assert.IsNull(b1.Locate("armour"));

        }
    }
}