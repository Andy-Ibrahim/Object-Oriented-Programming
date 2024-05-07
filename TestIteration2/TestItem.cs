using System;
using NUnit.Framework;

namespace SwinAdventure
{
    [TestFixture]

    public class TestItem
    {
        Item axe;

        [SetUp]
        public void SetUp()
        {

            axe = new Item(new string[] { "axe" }, "an axe", "this is an axe");

        }

        [Test]
        public void TestItemIdentifiable()
        {
            bool expected = true;
            bool actual = axe.AreYou("axe");
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestShortDescription()
        {
            string expected = "an axe (axe)";
            string actual = axe.ShortDescription;

            Assert.AreEqual(expected, actual);


        }

        [Test]
        public void TestFullDescription()
        {
            string expected = "this is an axe";
            string actual = axe.FullDescription;

            Assert.AreEqual(expected, actual);

        }

        
    }
}