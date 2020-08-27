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
            //Arrange
            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);

            CustomList<int> actual = new CustomList<int>();

            //Act
            actual = expected.Sort();

            //Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
