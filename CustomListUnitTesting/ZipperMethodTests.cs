using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_ListProject;

namespace CustomListUnitTesting
{
    [TestClass]
    public class ZipperMethodTests
    {
        [TestMethod]
        public void ExecuteAddTwoListsTwoValuesEach_ActualEquals1234()
        {
            // adds two lists together with one element in each list
            // convert lists into string values in order to compare equality using Assert.AreEqual

            // Arrange
            string actualString;
            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            string expectedString = expected.ToString();

            CustomList<int> actual = new CustomList<int>();
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);

            // Act

            actualString = odd.Zip(even).ToString();
            

            // Assert
            // checks to see that expected actual value is 1234, a combination of both arrays odd and even
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void ExecuteAddTwoListsTwoValuesEach_ActualEquals1234()
        {
            // adds two lists together with one element in each list
            // convert lists into string values in order to compare equality using Assert.AreEqual

            // Arrange
            string actualString;
            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            string expectedString = expected.ToString();

            CustomList<int> actual = new CustomList<int>();
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);

            // Act

            actualString = odd.Zip(even).ToString();


            // Assert
            // checks to see that expected actual value is 1234, a combination of both arrays odd and even
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void ExecuteAddTwoListsOneEmpty_ActualEquals1234()
        {
            // adds two lists together with one element in each list
            // convert lists into string values in order to compare equality using Assert.AreEqual

            // Arrange

            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            string expectedString = expected.ToString();

            CustomList<int> actual = new CustomList<int>();
            string actualString;
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            CustomList<int> list2 = new CustomList<int>();

            // Act

            actual = list1 + list2;
            actualString = actual.ToString();

            // Assert
            // checks to see that expected actual value is 1234, with one of the arrays returning empty
            Assert.AreEqual(expectedString, actualString);
        }

    }
}
}
