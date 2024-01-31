using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class MinusOperatorOverloadTests //subtract one instance of a custom list class from another instance of a custom list class. This should result in each item from the second list being removed from the first list.
    {
        [TestMethod] //test 1: first list is longer than second list
        public void MinusOperatorOverload_FirstListLongerThanSecondList_ListsCombinedSuccessfully() //method being tested_the situation we are testing_what we expect to happen
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
            newList = firstList - secondList;
            actualString = newList.ToString();
            expectedString = "2";

            //assert
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod] //test 2: second list is longer than first list
        public void MinusOperatorOverload_CreateTwoListsWhereSecondListLongerThanFirstList_ListsCombinedSuccessfully() //method being tested_the situation we are testing_what we expect to happen
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
            secondList.Add(4);
            secondList.Add(3);
            newList = firstList - secondList;
            actualString = newList.ToString();
            expectedString = "2";

            //assert
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod] //test 3: if second list is empty, result is unchanged
        public void MinusOperatorOverload_SecondListIsEmpty_ResultUnchanged() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<int> firstList = new();
            CustomList<int> secondList = new();
            CustomList<int> newList = new();
            //string expectedString;
            //string actualString;

            //act
            firstList.Add(1);
            firstList.Add(2);
            newList = firstList - secondList;
            //actualString = newList.ToString();
            //expectedString = "1 2";

            //assert
            Assert.AreEqual(firstList, newList);
        }

        [TestMethod] //test 4: operation should only remove single instance of thing in second list (i.e. {3,3,3} - {1,2,3} should result in {3,3}, not an empty list)
        public void MinusOperatorOverload_RemovingOneInstanceOfItemInSecondList_OnlyOneInstanceOfItemInSecondListRemoved() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<int> firstList = new();
            CustomList<int> secondList = new();
            CustomList<int> newList = new();
            string expectedString;
            string actualString;

            //act
            firstList.Add(3);
            firstList.Add(3);
            firstList.Add(3);
            secondList.Add(1);
            secondList.Add(2);
            secondList.Add(3);
            newList = firstList - secondList;
            actualString = newList.ToString();
            expectedString = "3 3";

            //assert
            Assert.AreEqual(expectedString, actualString);
            Assert.AreEqual(2, newList.Count);
        }
    }
}
