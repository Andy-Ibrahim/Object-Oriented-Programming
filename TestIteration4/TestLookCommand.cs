using System;
using System.Numerics;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;

namespace SwinAdventure
{
    [TestFixture]

    public class lookCommandTest
    {

        LookCommand look;
        Player player;
        Bag b1;
        Item gem;

    [SetUp]
        public void SetUp()
        {

            gem = new Item(new string[] { "gem" }, "a gem", "this is a gem");
            b1 = new Bag(new string[] { "bag1" }, "a bag1", "This is a bag1");
            player = new Player("andy", "music producer");
            look = new LookCommand();
            

        }

        [Test]
        public void TestLookAtMe()
        {
            string Output = look.Execute(player, new string[] { "look", "at", "inventory" });

            string expected = $"andy, music producer, you are carrying: ";

            Assert.AreEqual(expected, Output);

        }

        [Test]
        public void TestLookAtGem()
        {
            player.Inventory.Put(gem);

            string Output = look.Execute(player, new string[] { "look", "at", "gem" });
            string expected= $"{gem.FullDescription}";

            Assert.AreEqual(expected, Output);

        }

        [Test]
        public void TestLookAtUnk()
        {
            string Output = look.Execute(player, new string[] { "look", "at", "gem" });
            string expected = $"I can't find the gem";

            Assert.AreEqual(expected, Output);

        }

        [Test]
        public void TestLookAtGemInMe()
        {
            player.Inventory.Put(gem);
            string Output = look.Execute(player, new string[] { "look", "at", "gem", "in", "me" });
            string expected = $"{gem.FullDescription}";
            Assert.AreEqual(expected, Output);

        }

        [Test]
        public void TestLookAtGemInBag()
        {
            player.Inventory.Put(b1);
            b1.Inventory.Put(gem);

            string Output = look.Execute(player, new string[] { "look", "at", "gem", "in", "bag1" });
            string expected = $"{gem.FullDescription}";
            Assert.AreEqual(expected, Output);

        }

        [Test]
        public void TestLookAtGemInNoBag()
        {
            string expected = "I can't find the bag1";
            string Output = look.Execute(player, new string[] { "look", "at", "gem", "in", "bag1" });
            Assert.AreEqual(expected, Output);

        }

        [Test]
        public void TestLookAtNoGemInBag()
        {
            player.Inventory.Put(b1);
            string expected = "I can't find the gem";
            string Output = look.Execute(player, new string[] { "look", "at", "gem", "in", "bag1" });
            Assert.AreEqual(expected, Output);

        }

        [Test]
        public void InvalidLook()
        {
            string Output1 = look.Execute(player, new string[] { "look", "around"});
            string Output2 = look.Execute(player, new string[] { "hello"});
            string Output3 = look.Execute(player, new string[] { "look", "at","a","at","b"});

            Assert.AreEqual("I don't know how to look like that", Output1);
            Assert.AreEqual("I don't know how to look like that", Output2);
            Assert.AreEqual("What do you want to look in?", Output3);


        }
    }
}