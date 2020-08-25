using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_ListProject;

namespace CustomListUnitTesting
{
    [TestClass]
    public class PlusOperatorOverloadTestMethod
    {
        [TestMethod]
        public void ExecuteAddTwoListsOneValueEach_ActualEquals12()
        {
            // adds two lists together with one element in each list
            // Arrange

            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            CustomList<int> actual = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(2);

            // Act

            actual = list1 + list2;

            // Assert
            // checks to see that expected actual value is 12, a combination of both arrays list1 and list2
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod4()
        {
        }

        [TestMethod]
        public void TestMethod5()
        {
        }
    }
}
