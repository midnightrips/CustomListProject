﻿using CustomList;

namespace CustomListTests
{
    [TestClass]
    internal class PlusOperatorOverloadTests
    {
        [TestMethod] //test 1: first list is longer than second list
        public void PlusOperatorOverload_CreateTwoListsWhereFirstListLongerThanSecondList_FirstListLongerThanSecondList() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }

        [TestMethod] //test 2: second list is longer than first list
        public void PlusOperatorOverload_CreateTwoListsWhereSecondListLongerThanFirstList_SecondListLongerThanFirstList() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }

        [TestMethod] //test 3: if one list is empty, the result is unchanged
        public void PlusOperatorOverload_OneListIsEmpty_ResultUnchanged() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }
    }
}