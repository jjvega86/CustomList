using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_ListProject;


namespace CustomListUnitTesting
{
    [TestClass]
    public class RemoveMethodTest
    {
        [TestMethod]
        public void ExecuteRemoveOneValue_CountEquals5()
        {
            // remove a single value from the CustomList and check for a correct Count property

            //Arrange
            int itemOne = 3;
            int itemTwo = 4;
            int itemThree = 7;
            int itemFour = 8;
            int itemFive = 3;
            int itemSix = 12;

            int expected = 5;
            int actual = 0;
            CustomList<int> newIntList = new CustomList<int>();

            //Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            newIntList.Add(itemThree);
            newIntList.Add(itemFour);
            newIntList.Add(itemFive);
            newIntList.Add(itemSix);
            newIntList.Remove(itemSix);
            actual = newIntList.Count;


            //Assert
            // checks Count property for actual expected value of 5
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExecuteRemoveTwoItems_CapacityEquals4()
        {
            // removes two values from the CustomList, resulting in the array shrinking to original capacity

            //Arrange
            int itemOne = 3;
            int itemTwo = 4;
            int itemThree = 7;
            int itemFour = 8;
            int itemFive = 3;
            int itemSix = 12;

            int expected = 5;
            int actual = 0;
            CustomList<int> newIntList = new CustomList<int>();

            //Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            newIntList.Add(itemThree);
            newIntList.Add(itemFour);
            newIntList.Add(itemFive);
            newIntList.Add(itemSix);
            newIntList.Remove(itemFive);
            newIntList.Remove(itemSix);
            actual = newIntList.Capacity;


            //Assert
            // checks Capacity property for actual expected value of 4 (was 8)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
