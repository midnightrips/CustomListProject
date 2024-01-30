using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class PlusOperatorOverloadTests //rewatch video explanation for what these tests are looking for
    {
        [TestMethod] //test 1: first list is longer than second list
        public void PlusOperatorOverload_FirstListLongerThanSecondList_ListsCombinedSuccessfully() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<int> firstList = new();
            CustomList<int> secondList = new();
            CustomList<int> newList = new();
            string expectedString;
            string actualString;
            

            //act
            firstList.Add(1);
            firstList.Add(2);
            secondList.Add(1);
            newList = firstList + secondList;
            actualString = newList.ToString();
            expectedString = "1 2 1";


            //assert
            Assert.AreEqual(expectedString, actualString);

        }

        [TestMethod] //test 2: second list is longer than first list
        public void PlusOperatorOverload_SecondListLongerThanFirstList_ListsCombinedSuccessfully() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<int> firstList = new();
            CustomList<int> secondList = new();
            CustomList<int> newList = new();
            string expectedString;
            string actualString;

            //act
            firstList.Add(1);
            secondList.Add(1);
            secondList.Add(2);
            newList = firstList + secondList;
            actualString = newList.ToString();
            expectedString = "1 1 2";

            //assert
            Assert.AreEqual(expectedString, actualString);

        }

        [TestMethod] //test 3: if one list is empty, the result is unchanged
        public void PlusOperatorOverload_OneListIsEmpty_ResultUnchanged() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<int> firstList = new();
            CustomList<int> secondList = new();
            CustomList<int> newList = new();
            string expectedString;
            string actualString;

            //act
            firstList.Add(1);
            firstList.Add(2);
            newList = firstList + secondList;
            actualString = newList.ToString();
            expectedString = "1 2";

            //assert
            Assert.AreEqual(2, newList.Count);
            Assert.AreEqual(expectedString, actualString);
        }
    }
}
