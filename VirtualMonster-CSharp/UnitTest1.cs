using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualMonsterClasses;

namespace VirtualMonster_CSharpTests
{
    [TestClass]
    public class VirtualMonsterTests
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
        public void OneArgumentConstructorSetsAttributesToFifty()
        {
            // Arrangement and Activation
            VirtualMonster testMonster = new VirtualMonster("Quirgle");

            // Assertions
            Assert.AreEqual(50, testMonster.Hunger);
            Assert.AreEqual(50, testMonster.Thirst);
            Assert.AreEqual(50, testMonster.Bathroom);
            Assert.AreEqual(0, testMonster.Rage);
        }

        [TestMethod]
        public void FullConstructorSetsNameCorrectly()
        {
            // Arrangement and Activation
            VirtualMonster testMonster = new VirtualMonster("Zarflok", 66, 37, 21, 4);

            // Assertion
            Assert.AreEqual("Zarflok", testMonster.Name);
        }

        [TestMethod]
        public void FullConstructorSetsAttributesCorrectly()
        {
            // Arrangement and Activation
            VirtualMonster testMonster = new VirtualMonster("Zarflok", 66, 37, 21, 4);

            // Assertions
            Assert.AreEqual(66, testMonster.Hunger);
            Assert.AreEqual(37, testMonster.Thirst);
            Assert.AreEqual(21, testMonster.Bathroom);
            Assert.AreEqual(4, testMonster.Rage);
        }
    }
}
