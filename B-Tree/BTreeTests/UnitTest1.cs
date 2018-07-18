using System;
using System.Collections.Generic;
using B_Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BTreeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetMaxValueTest()
        {
            //Arrange
            Node treeRoot = null;

            int[] hardcodedNumbersArray = new int[] { 14, 1, 5, 2, 4, 6, 8, 10, 15, 17 };

            for (int numberIndex = 0; numberIndex < hardcodedNumbersArray.Length; numberIndex++)
            {
                Program.AddNode(hardcodedNumbersArray[numberIndex], ref treeRoot);
            }

            //Act
            int maxValue = Program.GetMaxValue(treeRoot);

            //Assert
            Assert.AreEqual(maxValue, 17);
        }

        [TestMethod]
        public void GetMinValueTest()
        {
            //Arrange
            Node treeRoot = null;

            int[] hardcodedNumbersArray = new int[] { 14, 1, 5, 2, 4, 6, 8, 10, 15, 17 };

            for (int numberIndex = 0; numberIndex < hardcodedNumbersArray.Length; numberIndex++)
            {
                Program.AddNode(hardcodedNumbersArray[numberIndex], ref treeRoot);
            }

            //Act
            int minValue = Program.GetMinValue(treeRoot);

            //Assert
            Assert.AreEqual(minValue, 1);
        }

        [TestMethod]
        public void GetIncreaseArray()
        {
            //Arrange
            Node treeRoot = null;

            int[] hardcodedNumbersArray = new int[] { 14, 1, 5, 2, 4, 6, 8, 10, 15, 17 };

            for (int numberIndex = 0; numberIndex < hardcodedNumbersArray.Length; numberIndex++)
            {
                Program.AddNode(hardcodedNumbersArray[numberIndex], ref treeRoot);
            }

            //Act
            List<int> array = new List<int>(); 
            Program.GetIncreasedArray(treeRoot, ref array);

            //Assert
            for(int arrayIndex = 0; arrayIndex<array.Count - 1; arrayIndex++)
            {
                Assert.IsTrue(array[arrayIndex] < array[arrayIndex + 1]);
            }
        }
    }
}
