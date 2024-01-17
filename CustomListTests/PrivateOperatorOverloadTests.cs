using CustomList;

namespace CustomListTests
{
    [TestClass]
    internal class PrivateOperatorOverloadTests
    {
        [TestMethod] //test 1: first list is longer than second list
        public void PrivateOperatorOverload_CreateTwoListsWhereFirstListLongerThanSecondList_FirstListLongerThanSecondList() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }

        [TestMethod] //test 2: second list is longer than first list
        public void PrivateOperatorOverload_CreateTwoListsWhereSecondListLongerThanFirstList_SecondListLongerThanFirstList() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }

        [TestMethod] //test 3: if second list is empty, result is unchanged
        public void PublicOperatorOverload_SecondListIsEmpty_ResultUnchanged() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }

        [TestMethod] //test 4: operation should only remove single instance of thing in second list (i.e. {3,3,3} - {1,2,3} should result in {3,3}, not an empty list)
        public void PublicOperatorOverload_RemovingOneInstanceOfItemInSecondList_OnlyOneInstanceOfItemInSecondListRemoved() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }
    }
}
