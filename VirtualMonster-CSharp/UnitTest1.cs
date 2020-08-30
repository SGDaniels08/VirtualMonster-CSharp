using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
            Assert.AreEqual(100, testMonster.Health);
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
            VirtualMonster testMonster = new VirtualMonster("Zarflok", 95, 19, 66, 37, 21, 4);

            // Assertion
            Assert.AreEqual("Zarflok", testMonster.Name);
        }

        [TestMethod]
        public void FullConstructorSetsAttributesCorrectly()
        {
            // Arrangement and Activation
            VirtualMonster testMonster = new VirtualMonster("Zarflok", 95, 19, 66, 37, 21, 4);

            // Assertions
            Assert.AreEqual(95, testMonster.Health);
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
            VirtualMonster testMonster = new VirtualMonster("Gragnoff", 99, 98, 98, 98, 100, 50);

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
            VirtualMonster testMonster = new VirtualMonster("Burzurz", 82, 98, 98, 98, 100, 97);

            // Activation
            testMonster.Tick();

            // Assertion
            Assert.IsTrue(testMonster.Rage > 100);
        }

        [TestMethod]
        public void HungerAtOneHundredReducesHealthByTen()
        {
            // Arrangemenet
            VirtualMonster testMonster = new VirtualMonster("Frabbleb", 46, 98, 76, 44, 56, 75);

            // Activation
            testMonster.Tick();

            // Assertion
            Assert.AreEqual(36, testMonster.Health);
        }

        [TestMethod]
        public void ThirstAtOneHundredReducesHealthByTen()
        {
            // Arrangemenet
            VirtualMonster testMonster = new VirtualMonster("Uuuug", 58, 77, 98, 14, 39, 12);

            // Activation
            testMonster.Tick();

            // Assertion
            Assert.AreEqual(48, testMonster.Health);
        }

        [TestMethod]
        public void SleepinessAndBathroomAtOneHundredReducesHealthByTwentyTotal()
        {
            // Arrangemenet
            VirtualMonster testMonster = new VirtualMonster("Ragelok", 66, 100, 77, 20, 100, 87);

            // Activation
            testMonster.Tick();

            // Assertion
            Assert.AreEqual(46, testMonster.Health);
        }

        [TestMethod]
        public void HealthAtZeroMonsterDies()
        {
            // Arrangement
            VirtualMonster testMonster = new VirtualMonster("TestMonster", 10, 50, 50, 99, 50, 50);

            // Activation
            testMonster.Tick();

            // Assertion
            Assert.AreEqual(0, testMonster.Health);
            Assert.AreEqual(false, testMonster.IsAlive);
        }
    }

    [TestClass]
    public class VirtualMonsterActionMethods
    {
        [TestMethod]
        public void EatReducesHungerByForty()
        {
            // Arrangement
            VirtualMonster testMonster = new VirtualMonster("Testo");

            // Activation
            testMonster.Eat();

            // Assertion
            Assert.AreEqual(10, testMonster.Hunger);
        }

        [TestMethod]
        public void EatIncreasesBathroomByFifteen()
        {
            // Arrangement
            VirtualMonster testMonster = new VirtualMonster("Testo");

            // Activation
            testMonster.Eat();

            // Assertion
            Assert.AreEqual(40, testMonster.Bathroom);
        }

        [TestMethod]
        public void DrinkReducesThirstByForty()
        {
            // Arrangement
            VirtualMonster testMonster = new VirtualMonster("Testo");

            //Activation
            testMonster.Drink();

            // Assertion
            Assert.AreEqual(10, testMonster.Thirst);
        }

        [TestMethod]
        public void DrinkIncreasesBathroomByFifteen()
        {
            // Arrangement
            VirtualMonster testMonster = new VirtualMonster("Testo");

            //Activation
            testMonster.Drink();

            // Assertion
            Assert.AreEqual(40, testMonster.Bathroom);
        }

        [TestMethod]
        public void PottyReducesBathroomToZero()
        {
            // Arrangement
            VirtualMonster testMonster = new VirtualMonster("Testo");

            //Activation
            testMonster.Potty();

            // Assertion
            Assert.AreEqual(0, testMonster.Bathroom);
        }
    }

    [TestClass]
    public class VirtualMonsterPenTests
    {
        [TestMethod]
        public void VirtualMonsterPenInstanceCreatesSuccessfully()
        {
            // Arrangement and Activation
            VirtualMonsterPen testPen = new VirtualMonsterPen();

            // Assertion
            Assert.IsInstanceOfType(testPen, typeof(VirtualMonsterPen));
        }

        /*
        [TestMethod]
        public void VirtualMonsterPenConstructorWithDictionaryWorks()
        {
            // Arrangment
            VirtualMonster testMonster1 = new VirtualMonster("Borzong");
            VirtualMonster testMonster2 = new VirtualMonster("Guflap");
            Dictionary<string, VirtualMonster> testPen = new Dictionary<string, VirtualMonster>();
            testPen.Add(testMonster1.Name, testMonster1);
            testPen.Add(testMonster2.Name, testMonster2);

            // Activation
            VirtualMonsterPen testMonsterPen = new VirtualMonsterPen(testPen);

            // Assertion
            
        } */
    }
}
