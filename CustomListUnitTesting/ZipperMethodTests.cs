using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_ListProject;

namespace CustomListUnitTesting
{
    [TestClass]
    public class ZipperMethodTests
    {
        [TestMethod]
        public void Execute_ZipTwoListsTwoValuesEach_ActualEquals1234()
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
        public void ExecuteZipTwoListsFourValuesEach_ActualEquals12345678()
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
            expected.Add(5);
            expected.Add(6);
            expected.Add(7);
            expected.Add(8);
            string expectedString = expected.ToString();

            CustomList<int> actual = new CustomList<int>();
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            odd.Add(7);
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);
            even.Add(8);

            // Act

            actualString = odd.Zip(even).ToString();


            // Assert
            // checks to see that expected actual value is 12345678, a combination of both arrays odd and even
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void Execute_ZipTwoListsOneEmpty_ActualEquals1357()
        {
            // adds two lists together with one element in each list
            // convert lists into string values in order to compare equality using Assert.AreEqual

            // Arrange
            string actualString;
            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(3);
            expected.Add(5);
            expected.Add(7);
            string expectedString = expected.ToString();

            CustomList<int> actual = new CustomList<int>();
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            odd.Add(7);
            CustomList<int> even = new CustomList<int>();
            

            // Act

            actualString = odd.Zip(even).ToString();


            // Assert
            // checks to see that expected actual value is 1357, a combination of both arrays odd and even (even is empty)
            Assert.AreEqual(expectedString, actualString);
        }

    }
}

