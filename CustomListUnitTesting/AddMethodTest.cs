using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_ListProject;

namespace CustomListUnitTesting
{
    [TestClass]
    public class AddMethodTest
    {
        // test method 1
        // test method 2
        // test method 3
        // test method 4
        // test method 5

        //Arrange

        //Act

        //Assert

        [TestMethod]
        public void Execute_AddOneItem_IntValue_CountEqualsOne()
        {
            //add a single item to the list

            //Arrange
            int itemOne = 3;
            int expected = 1;
            int actual = 0;
            CustomList<int> newIntList = new CustomList<int>();

            //Act
            //calls the Add method from CustomList to add the variable '3' to the list
            newIntList.Add(itemOne);
            actual = newIntList.Count;

            //Assert
            //checks to see that the instantiated list is no longer null
            Assert.Equals(expected, actual);
        }

        [TestMethod]

        public void Execute_AddTwoItems_IntValue_CountEqualsTwo()
        {
            //Arrange
            // add two items to the list
            int itemOne = 3;
            int itemTwo = 4;
            int expected = 2;
            int actual = 0;
            CustomList<int> newIntList = new CustomList<int>();

            //Act
            newIntList.Add(itemOne, itemTwo);
            actual = newIntList.Count;

            //Assert
            Assert.Equals(expected, actual);

        }

        public void TestMethod3()
        {
            //Arrange

            //Act

            //Assert

        }

        public void TestMethod4()
        {
            //Arrange

            //Act

            //Assert

        }

        public void TestMethod5()
        {
            //Arrange

            //Act

            //Assert

        }
    }
}
}
