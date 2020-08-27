using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_ListProject;

namespace CustomListUnitTesting
{
    [TestClass]
    public class CustomSortMethodTests
    {
        [TestMethod]
        public void Execute_SortIntListInAscendingOrder_Equals1234()
        {
            // sort an int list in ascending order
            // Arrange
            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);

            CustomList<int> actual = new CustomList<int>();
            actual.Add(1);
            actual.Add(3);
            actual.Add(4);
            actual.Add(2);


            // Act
            actual.Sort();

            // Assert
            // expected actual is 1234
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Execute_SortIntListInAscendingOrder_Equals12345678()
        {
            // sort a longer, more complex list in ascending order
            // Arrange
            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            expected.Add(5);
            expected.Add(6);
            expected.Add(7);
            expected.Add(8);

            CustomList<int> actual = new CustomList<int>();
            actual.Add(6);
            actual.Add(3);
            actual.Add(4);
            actual.Add(2);
            actual.Add(5);
            actual.Add(8);
            actual.Add(7);
            actual.Add(1);

            // Act
            actual.Sort();

            //Assert
            // expected actual is 12345678
            Assert.AreEqual(expected, actual);
        }
    }
}
