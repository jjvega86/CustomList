using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_ListProject;

namespace CustomListUnitTesting
{
    [TestClass]
    public class AddMethodTest
    {
        
        [TestMethod]
        public void Execute_AddOneItem_CountEqualsOne()
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
            //checks to see that the Count is 1
            Assert.Equals(expected, actual);
        }

        [TestMethod]

        public void Execute_AddTwoItems_CountEqualsTwo()
        {
            //Arrange
            // add two items to the list
            int itemOne = 3;
            int itemTwo = 4;
            int expected = 2;
            int actual = 0;
            CustomList<int> newIntList = new CustomList<int>();

            //Act
            newIntList.Add(itemOne); 
            newIntList.Add(itemTwo);
            actual = newIntList.Count;

            //Assert
            //checks that the expected and actual Counts equal 2
            Assert.Equals(expected, actual);

        }

        [TestMethod]
        public void Execute_AddTwoItems_CapacityEquals4()
        {
            //Arrange
            int itemOne = 3;
            int itemTwo = 4;
            int expected = 4;
            int actual = 0;
            CustomList<int> newIntList = new CustomList<int>();

            //Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            actual = newIntList.Capacity;

            //Assert
            //checks that the expected and actual capacity equal 4 when two items are added
            Assert.Equals(expected, actual);


        }

        [TestMethod]

        public void Execute_AddSixItems_CapacityEquals8()
        {
            //Arrange
            int itemOne = 3;
            int itemTwo = 4;
            int itemThree = 7;
            int itemFour = 8;
            int itemFive = 3;
            int itemSix = 12;
            int expected = 8;
            int actual = 0;
            CustomList<int> newIntList = new CustomList<int>();

            //Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            newIntList.Add(itemThree);
            newIntList.Add(itemFour);
            newIntList.Add(itemFive);
            newIntList.Add(itemSix);
            actual = newIntList.Capacity;

            //Assert
            // checks that the expected and actual capacity is 8, after enough items are added to array to double capacity
            Assert.Equals(expected, actual);
            

        }

        [TestMethod]
        public void Execute_AddSixItems_IndexZeroIsThree()
        {
            //Arrange
            int itemOne = 3;
            int itemTwo = 4;
            int itemThree = 7;
            int itemFour = 8;
            int itemFive = 3;
            int itemSix = 12;

            int expected = 3;
            int actual = 0;
            CustomList<int> newIntList = new CustomList<int>();

            //Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            newIntList.Add(itemThree);
            newIntList.Add(itemFour);
            newIntList.Add(itemFive);
            newIntList.Add(itemSix);
            actual = newIntList[0];
           

            //Assert
            // checks index 0 for correct expected value of 3
            Assert.Equals(expected, actual);
            


        }

        [TestMethod]
        public void Execute_AddSixItems_IndexTwoIsSeven()
        {
            //Arrange
            int itemOne = 3;
            int itemTwo = 4;
            int itemThree = 7;
            int itemFour = 8;
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
            actual = newIntList[2];


            //Assert
            // checks index 2 for correct expected value of 7
            Assert.Equals(expected, actual);



        }

        [TestMethod]
        public void Execute_AddSixItems_IndexFiveIsTwelve()
        {
            //Arrange
            int itemOne = 3;
            int itemTwo = 4;
            int itemThree = 7;
            int itemFour = 8;
            int itemFive = 3;
            int itemSix = 12;

            int expected = 3;
            int actual = 0;
            CustomList<int> newIntList = new CustomList<int>();

            //Act
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            newIntList.Add(itemThree);
            newIntList.Add(itemFour);
            newIntList.Add(itemFive);
            newIntList.Add(itemSix);
            actual = newIntList[5];


            //Assert
            // checks index 5 for correct expected value of 12
            Assert.Equals(expected, actual);



        }
    }
}

