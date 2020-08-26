using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_ListProject;

namespace CustomListUnitTesting
{
    [TestClass]
    public class ToStringMethodTests
    {
        [TestMethod]
        public void ExecuteCombineTwoIntElementsIntoString_ActualEquals34()
        {
            // checks that two elements are combined into a single string
            // Arrange
            int itemOne = 3;
            int itemTwo = 4;
            string expected = "34";
            string actual = "";
            CustomList<int> newIntList = new CustomList<int>();

            // Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            actual = newIntList.ToString();

            // Assert
            // checks to see that expected actual value is "34", the combination of both items in array
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void ExecuteCombineSixIntElementsIntoString_ActualEquals123456()
        {
            // checks that six elements are combined into a single string
            // Arrange
            int itemOne = 1;
            int itemTwo = 2;
            int itemThree = 3;
            int itemFour = 4;
            int itemFive = 5;
            int itemSix = 6;
            string expected = "123456";
            string actual = "";
            CustomList<int> newIntList = new CustomList<int>();

            // Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            newIntList.Add(itemThree);
            newIntList.Add(itemFour);
            newIntList.Add(itemFive);
            newIntList.Add(itemSix);
            actual = newIntList.ToString();

            // Assert
            // checks to see that expected actual value is "123456", the combination of all items in array
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExecuteCombineSixStringElementsIntoString_ActualEquals123456()
        {
            // checks that six elements are combined into a single string
            // Arrange
            string itemOne = "1";
            string itemTwo = "2";
            string itemThree = "3";
            string itemFour = "4";
            string itemFive = "5";
            string itemSix = "6";
            string expected = "123456";
            string actual = "";
            CustomList<string> newStringList = new CustomList<string>();

            // Act
            newStringList.Add(itemOne);
            newStringList.Add(itemTwo);
            newStringList.Add(itemThree);
            newStringList.Add(itemFour);
            newStringList.Add(itemFive);
            newStringList.Add(itemSix);
            actual = newStringList.ToString();

            // Assert
            // checks to see that expected actual value is "123456", the combination of all string items in array
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExecuteRunToStringOnEmptyList_ActualEqualsNull()
        {
            // runs ToString on an empty method
            // Arrange
            string expected = null;
            string actual = "";
            CustomList<int> newIntList = new CustomList<int>();

            // Act
            
            actual = newIntList.ToString();

            // Assert
            // checks to see that expected actual value null since there is nothing to return
            Assert.AreEqual(expected, actual);
        }


    }
}
