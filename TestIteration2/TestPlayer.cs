using System;
using System.Numerics;
using System.Xml.Linq;
using NUnit.Framework;

namespace SwinAdventure
{
    [TestFixture]

    public class TestPlayer
    {
        Player player;
        Item shield;
        Item axe;
        Inventory inventory;


        [SetUp]
        public void SetUp()
        {
            player = new Player("andy", "music producer");
            shield = new Item(new string[] { "shield" }, "a shield", "this is a shield");
            axe = new Item(new string[] { "axe" }, "an axe", "this is an axe");
            inventory = new();

            player.Inventory.Put(shield);
            player.Inventory.Put(axe);

        }

        [Test]
        public void TestPlayerIsIdentifiable()
        {
            Assert.IsTrue(player.AreYou("me"));
            Assert.IsTrue(player.AreYou("Inventory"));

        }

        [Test]
        public void TestPlayerLocatesItems()
        {
            

            Assert.That(player.Inventory.HasItem("shield"), Is.True);
            Assert.That(player.Inventory.HasItem("axe"), Is.True);

            Assert.That(player.Inventory.HasItem("shield"), Is.True);
            Assert.That(player.Inventory.HasItem("axe"), Is.True);

        }

        [Test]
        public void TestPlayerLocatesItself()
        {
            Assert.That(player, Is.EqualTo(player.Locate("me")));
            Assert.That(player, Is.EqualTo(player.Locate("inventory")));


        }

        [Test]
        public void TestPlayerLocatesNothing()
        {
            Assert.That(player.Locate("macbookpro"), Is.EqualTo(null));

        }

        [Test]
        public void TestPlayerFullDescriotion()
        {
            Assert.That(player.FullDescription, Is.EqualTo($"andy, music producer, you are carrying: {player.Inventory.ItemList}"));

        }
    }
}