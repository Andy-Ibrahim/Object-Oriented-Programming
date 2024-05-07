using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SwinAdventure;

namespace SwinAdventureTest
{
    [TestFixture]

    public class TestIdentifiableObject
    {
        private IdentifiableObject ObjectTest;
        private string[] _array;
        private string[] empty_array = new string[] { };
        private IdentifiableObject emptyobject;


        [SetUp]
        public void SetUp()
        {
            _array = new string[] { "fred", "george", "bob" };
            ObjectTest = new IdentifiableObject(_array);
            emptyobject = new IdentifiableObject(empty_array);

        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(ObjectTest.AreYou("fred"));

        }

        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(ObjectTest.AreYou("john"));

        }

        [Test]
        public void TestCaseSensitive()
        {
            Assert.IsTrue(ObjectTest.AreYou("FreD"));

        }

        [Test]
        public void TestFirstID()
        {
            Assert.AreEqual("fred", ObjectTest.FirstId);

        }

        [Test]
        public void TestFirstIDWithNoIDs()
        {
            Assert.AreEqual("",emptyobject.FirstId);


        }

        [Test]
        public void TestAddId()
        {

            ObjectTest.Addidentifier("billy");

            Assert.IsTrue(ObjectTest.AreYou("billy"));
            Assert.IsTrue(ObjectTest.AreYou("fred"));
            Assert.IsTrue(ObjectTest.AreYou("george"));
            Assert.IsTrue(ObjectTest.AreYou("bob"));

        }
    }
}