using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_ListProject;

namespace CustomListUnitTesting
{
    [TestClass]
    public class MinusOperatorOverloadMethodTests
    {
        [TestMethod]
        public void Execute_SubtractTwoLists_ResultEquals1()
        {
            // subtracts one list from another, resulting in a list that contains just "1"
            // convert lists into string values in order to compare equality using Assert.AreEqual

            // Arrange
            string actualString;
            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            string expectedString = expected.ToString();

            CustomList<int> actual = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(2);

            // Act

            actual = list1 - list2;
            actualString = actual.ToString();

            // Assert
            // checks to see that expected actual value is 1, the element left over after subtracting two lists
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void Execute_SubtractTwoLists_ResultEquals123()
        {
            // subtracts one list from another, resulting in a list that contains just "123"
            // convert lists into string values in order to compare equality using Assert.AreEqual

            // Arrange
            string actualString;
            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            string expectedString = expected.ToString();

            CustomList<int> actual = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(4);
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(3);
            list2.Add(4);

            // Act

            actual = list1 - list2;
            actualString = actual.ToString();

            // Assert
            // checks to see that expected actual value is 123, the elements left over after subtracting two lists
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void Execute_SubtractEmptyListFromFullList_ResultEquals123()
        {
            // subtracts one empty list from another containing elements, resulting in a list that contains just "123"
            // convert lists into string values in order to compare equality using Assert.AreEqual

            // Arrange
            string actualString;
            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            string expectedString = expected.ToString();

            CustomList<int> actual = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            CustomList<int> list2 = new CustomList<int>();
            

            // Act

            actual = list1 - list2;
            actualString = actual.ToString();

            // Assert
            // checks to see that expected actual value is 123, the elements left over after subtracting one empty list from another with elements
            Assert.AreEqual(expectedString, actualString);
        }


    }
}
