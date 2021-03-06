﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_ListProject;


namespace CustomListUnitTesting
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]
        public void ExecuteRemoveOneValue_CountEquals5()  
        {
            // remove a single value from the CustomList and check for a correct Count property

            // Arrange
            int itemOne = 3;
            int itemTwo = 4;
            int itemThree = 7;
            int itemFour = 8;
            int itemFive = 3;
            int itemSix = 12;

            int expected = 5;
            int actual = 0;
            CustomList<int> newIntList = new CustomList<int>();

            // Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            newIntList.Add(itemThree);
            newIntList.Add(itemFour);
            newIntList.Add(itemFive);
            newIntList.Add(itemSix);
            newIntList.Remove(itemSix);
            actual = newIntList.Count;


            // Assert
            // checks Count property for actual expected value of 5
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExecuteRemoveTwoItems_CapacityEqualsFour()
        {
            // removes two elements from the CustomList, resulting in the array shrinking to original capacity

            // Arrange
            int itemOne = 3;
            int itemTwo = 4;
            int itemThree = 7;
            int itemFour = 8;
            int itemFive = 3;
            int itemSix = 12;

            int expected = 4;
            int actual = 0;
            CustomList<int> newIntList = new CustomList<int>();

            // Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            newIntList.Add(itemThree);
            newIntList.Add(itemFour);
            newIntList.Add(itemFive);
            newIntList.Add(itemSix);
            newIntList.Remove(itemFive);
            newIntList.Remove(itemSix);
            actual = newIntList.Capacity;


            // Assert
            // checks Capacity property for actual expected value of 4 (was 8)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExecuteRemoveItemFive_ReturnEqualsFalse()
        {
            // attempts to remove an element that's not in the array. Should return false
            //Arrange
            int itemOne = 3;
            int itemTwo = 4;
            int itemThree = 7;
            int itemFour = 8;
            int itemFive = 22;
            int itemSix = 12;

            bool expected = false;
            bool actual = false;
            CustomList<int> newIntList = new CustomList<int>();

            //Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            newIntList.Add(itemThree);
            newIntList.Add(itemFour);
            newIntList.Add(itemSix);
            
            actual = newIntList.Remove(itemFive);


            //Assert
            // checks for return bool false since element is not in array
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExecuteRemoveItemOne_ReturnEqualsTrue()
        {
            //confirms successful removal of element with a boolean check

            //Arrange
            int itemOne = 3;
            int itemTwo = 4;
            int itemThree = 7;
            int itemFour = 8;
            int itemFive = 3;
            int itemSix = 12;

            bool expected = true;
            bool actual = true;
            CustomList<int> newIntList = new CustomList<int>();

            //Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            newIntList.Add(itemThree);
            newIntList.Add(itemFour);
            newIntList.Add(itemFive);
            newIntList.Add(itemSix);

            actual = newIntList.Remove(itemOne);


            //Assert
            // checks for return bool true since element was added to array
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExecuteRemoveItemOne_IndexZeroEqualsFour()
        {
            // tests that elements automatically move down one index when element is removed
            //Arrange
            int itemOne = 3;
            int itemTwo = 4;
            int itemThree = 7;
            int itemFour = 8;
            int itemFive = 3;
            int itemSix = 12;

            int expected = 4;
            int actual = 0;
            CustomList<int> newIntList = new CustomList<int>();

            //Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            newIntList.Add(itemThree);
            newIntList.Add(itemFour);
            newIntList.Add(itemFive);
            newIntList.Add(itemSix);
            newIntList.Remove(itemOne);
            actual = newIntList[0];


            //Assert
            // checks for actual expected value of 4, which should be in the 0 index after itemOne element is removed
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExecuteRemoveItemThree_ItemFourEqualsSeven()
        {
            // two duplicates in the CustomList: when Remove method is called, it should only remove the first element it finds, not all elements
            // of same value

            //Arrange
            int itemOne = 3;
            int itemTwo = 4;
            int itemThree = 7;
            int itemFour = 7;
            int itemFive = 3;
            int itemSix = 12;

            int expected = 7;
            int actual = 0;
            CustomList<int> newIntList = new CustomList<int>();

            //Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            newIntList.Add(itemThree);
            newIntList.Add(itemFour);
            newIntList.Add(itemFive);
            newIntList.Add(itemSix);
            newIntList.Remove(itemThree);
            
            actual = newIntList[2];


            //Assert
            // checks for itemFour in array at the [2] location. Only itemThree should have been removed, leaving itemFour to take its spot.
            Assert.AreEqual(expected, actual);
        }
    }
}
