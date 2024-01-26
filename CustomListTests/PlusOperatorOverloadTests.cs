using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class PlusOperatorOverloadTests //rewatch video explanation for what these tests are looking for
    {
        [TestMethod] //test 1: first list is longer than second list
        public void PlusOperatorOverload_FirstListLongerThanSecondList_FirstListReturned() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<string> firstList = new();
            CustomList<string> secondList = new();
            CustomList<string> newList = new();

            //act
            firstList.Add("one");
            firstList.Add("two");
            secondList.Add("one");

            //assert
            Assert.AreEqual(firstList, newList);
        }

        [TestMethod] //test 2: second list is longer than first list
        public void PlusOperatorOverload_SecondListLongerThanFirstList_SecondListReturned() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<string> firstList = new();
            CustomList<string> secondList = new();
            CustomList<string> newList = new();

            //act
            firstList.Add("one");
            secondList.Add("one");
            secondList.Add("two");

            //assert
            Assert.AreEqual(secondList, newList);
        }

        [TestMethod] //test 3: if one list is empty, the result is unchanged
        public void PlusOperatorOverload_OneListIsEmpty_ResultUnchanged() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<string> firstList = new();
            CustomList<string> secondList = new();
            CustomList<string> newList = new();

            //act
            firstList.Add("one");
            firstList.Add("two");

            //assert
            Assert.AreEqual(2, newList.Count);
        }
    }
}
