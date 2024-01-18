using CustomList;

namespace CustomListTests
{
    [TestClass]
    internal class ToStringMethodOverrideTests
    {
        [TestMethod] //test 1: a list of strings returns expected result
        public void ToStringMethodOverride_CreateListOfString_ExpectedResultReturned() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<string> myList = new();
            string myString = myList.ToString();

            //act
            myList.Add("My ");// is there a more efficient way of adding a bunch of strings to this list?
            myList.Add("name ");
            myList.Add("is ");
            myList.Add("Ehretz.");


            //assert
            Assert.AreEqual("My name is Ehretz.", myString); //do we want the method to create spaces between the strings?

        }

        [TestMethod] //test 2: a list of ints returns an expected result -- should this return the list of ints as a string?
        public void ToStringMethodOverride_CreateListOfInts_ExpectedResultReturned() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<string> myList = new();
            string myString = myList.ToString();

            //act
            //convert ints to strings first?

            //assert
            Assert.AreEqual("1, 2, 3, 4", myString);
        }

        [TestMethod] //test 3: an empty list returns an expty string
        public void ToStringMethodOverride_CreateEmptyList_EmptyStringReturned() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }
    }
}
