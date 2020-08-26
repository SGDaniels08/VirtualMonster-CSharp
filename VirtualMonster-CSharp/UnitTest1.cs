using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualMonsterClasses;

namespace VirtualMonster_CSharpTests
{
    [TestClass]
    public class VirtualMonsterConstructorTests
    {
        [TestMethod]
        public void BlankConstructorCreatesVirtualMonsterObject()
        {
            // Arrangement and Activation
            VirtualMonster testMonster1 = new VirtualMonster();
            VirtualMonster testMonster2 = new VirtualMonster();

            // Assertion
            Assert.AreEqual(testMonster1.GetType(), testMonster2.GetType());
        }

        [TestMethod]
        public void OneArgumentConstructorNamesMonster()
        {
            // Arrangement and Activation
            VirtualMonster testMonster = new VirtualMonster("Quirgle");

            // Assertion
            Assert.AreEqual("Quirgle", testMonster.Name);
        }

        [TestMethod]
        public void OneArgumentConstructorSetsAttributes()
        {
            // Arrangement and Activation
            VirtualMonster testMonster = new VirtualMonster("Quirgle");

            // Assertions
            Assert.AreEqual(50, testMonster.Hunger);
            Assert.AreEqual(50, testMonster.Sleepiness);
            Assert.AreEqual(50, testMonster.Thirst);
            Assert.AreEqual(25, testMonster.Bathroom);
            Assert.AreEqual(0, testMonster.Rage);
        }

        [TestMethod]
        public void FullConstructorSetsNameCorrectly()
        {
            // Arrangement and Activation
            VirtualMonster testMonster = new VirtualMonster("Zarflok", 19, 66, 37, 21, 4);

            // Assertion
            Assert.AreEqual("Zarflok", testMonster.Name);
        }

        [TestMethod]
        public void FullConstructorSetsAttributesCorrectly()
        {
            // Arrangement and Activation
            VirtualMonster testMonster = new VirtualMonster("Zarflok", 19, 66, 37, 21, 4);

            // Assertions
            Assert.AreEqual(19, testMonster.Sleepiness);
            Assert.AreEqual(66, testMonster.Hunger);
            Assert.AreEqual(37, testMonster.Thirst);
            Assert.AreEqual(21, testMonster.Bathroom);
            Assert.AreEqual(4, testMonster.Rage);
        }

    }

    [TestClass]
    public class VirtualMonsterTickTests
    {
        [TestMethod]
        public void TickMethodIncreasesHungerByFive()
        {
            // Arrangment
            VirtualMonster testMonster = new VirtualMonster("Bugluk");

            // Activation
            testMonster.Tick();

            // Assertion
            Assert.AreEqual(55, testMonster.Hunger);
        }

        [TestMethod]
        public void TickMethodIncreasesThirstAndSleepienssByFiveBathroomByOne()
        {
            // Arrangment
            VirtualMonster testMonster = new VirtualMonster("Bugluk");

            // Activation
            testMonster.Tick();

            // Assertion
            Assert.AreEqual(55, testMonster.Sleepiness);
            Assert.AreEqual(55, testMonster.Thirst);
            Assert.AreEqual(26, testMonster.Bathroom);
        }

        [TestMethod]
        public void TickMethodDoesNotRaiseAttributesOverOneHundred()
        {
            // Arrangment
            VirtualMonster testMonster = new VirtualMonster("Gragnoff", 98, 98, 98, 100, 50);

            // Activation
            testMonster.Tick();

            // Assertion
            Assert.AreEqual(100, testMonster.Sleepiness);
            Assert.AreEqual(100, testMonster.Hunger);
            Assert.AreEqual(100, testMonster.Thirst);
            Assert.AreEqual(100, testMonster.Bathroom);
        }
        
        [TestMethod]
        public void TickMethodCanRaiseRageAboveOneHundred()
        {
            // Arrangment
            VirtualMonster testMonster = new VirtualMonster("Burzurz", 98, 98, 98, 100, 97);

            // Activation
            testMonster.Tick();

            // Assertion
            Assert.IsTrue(testMonster.Rage > 100);
        }
    }
}
