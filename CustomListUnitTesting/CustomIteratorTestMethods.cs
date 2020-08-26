using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_ListProject;

namespace CustomListUnitTesting
{
    [TestClass]
    public class CustomIteratorTestMethods
    {
        [TestMethod]
        public void Execute_ForEachOverList_TotalEqualsSix()
        {
            // use a foreach loop to add total values of all elements in CustomList to int variable. 

            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            int actual = 0;
            int expected = 6;

            // Act
            foreach (int number in list1)
            {
                actual += number;
            }

            // Assert
            // expected actual value should equal total value of elements in list
            Assert.AreEqual(expected, actual);
        }
    }
}
