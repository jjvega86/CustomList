﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_ListProject;

namespace CustomListUnitTesting
{
    [TestClass]
    public class PlusOperatorOverloadMethodTests
    {
        [TestMethod]
        public void ExecuteAddTwoListsOneValueEach_ActualEquals12()
        {
            // adds two lists together with one element in each list
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
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(2);

            // Act

            actual = list1 + list2;
            actualString = actual.ToString();

            // Assert
            // checks to see that expected actual value is 12, a combination of both arrays list1 and list2
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void ExecuteAddTwoListsFourValuesEach_ActualEquals12345678()
        {
            // adds two lists together with one element in each list
            // convert lists into string values in order to compare equality using Assert.AreEqual

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
            string expectedString = expected.ToString();


            CustomList<int> actual = new CustomList<int>();
            string actualString;
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(5);
            list2.Add(6);
            list2.Add(7);
            list2.Add(8);

            // Act

            actual = list1 + list2;
            actualString = actual.ToString();
            // Assert
            // checks to see that expected actual value is 12345678, a combination of both arrays list1 and list2
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
