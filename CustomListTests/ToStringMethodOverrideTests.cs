using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class ToStringMethodOverrideTests
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
            myList.ToString();


            //assert
            Assert.AreEqual("My name is Ehretz.", myString); 

        }

        [TestMethod] //test 2: a list of ints returns an expected result -- should this return the list of ints as a string?
        public void ToStringMethodOverride_CreateListOfInts_ExpectedResultReturned() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<int> myList = new();
            string myString = myList.ToString();

            //act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.ToString();
    
            //assert
            Assert.AreEqual("123", myString); 
        }

        [TestMethod] //test 3: an empty list returns an expty string
        public void ToStringMethodOverride_CreateEmptyList_EmptyStringReturned() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<string> myList = new();
            string myString = myList.ToString();

            //act
            myList.ToString();

            //assert
            Assert.AreEqual("", myString);
        }
    }
}
