using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_ListProject;

namespace CustomListUnitTesting
{
    [TestClass]
    public class ToStringMethodTest
    {
        [TestMethod]
        public void ExecuteCombineTwoElementsIntoString_ActualEquals34()
        {
            // checks that two elements are combined into a single string
            // Arrange
            int itemOne = 3;
            int itemTwo = 4;
            string expected = "34";
            string actual = "";
            CustomList<int> newIntList = new CustomList<int>();

            // Act
            // calls the Add method from CustomList to add the variable '3' to the list
            newIntList.Add(itemOne);
            newIntList.Add(itemTwo);
            actual = newIntList.ToString();

            // Assert
            // checks to see that expected actual value is "34", the combination of both items in array
            Assert.AreEqual(expected, actual);
        }
    }
}
