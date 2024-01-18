using CustomList;

namespace CustomListTests
{
    [TestClass]
    internal class RemoveMethodTests
    {
        [TestMethod] //test 1: count decrements when an item is successfully removed
        public void RemoveMethod_RemovingItem_CountDecremented() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<string> myList = new();

            //act
            myList.Add("hello");
            myList.Remove("hello");

            //assert
            Assert.AreEqual(0, myList.Count);
        }

        [TestMethod] //test 2: method returns 'true' when an item is successfully removed
        public void RemoveMethod_RemovingItem_MethodReturnsTrue() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<string> myList = new();
            bool itemRemoved;

            //act
            myList.Add("hello");
            itemRemoved = myList.Remove("hello");


            //assert
            Assert.AreEqual(true, itemRemoved);
        }

        [TestMethod] //test 3: count does NOT decremement when trying to remove an item that is NOT in the CustomList
        public void RemoveMethod_RemovingItemThatIsNotInCustomList_CountRemainsTheSame() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<string> myList = new();

            //act
            myList.Add("hello");
            myList.Remove("there");

            //assert
            Assert.AreEqual(1, myList.Count);
        }

        [TestMethod] //test 4: items shift backwards after the item is removed, filling the index of the removed item
        public void RemoveMethod_ItemsShiftBackwardsAfterOneItemRemoved_ItemsFillIndexOfRemovedItem() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<string> myList = new();

            //act
            myList.Add("hello");
            myList.Add("there");
            myList.Remove("hello");

            //assert
            Assert.AreEqual("there", myList.Items[0]);
        }

        [TestMethod] //test 5: when removing an item that exists multiple times, only the first instance is removed
        public void RemoveMethod_RemovingOneInstanceOfAnItemThatExistsMultipleTimes_OnlyFirstInstanceOfItemIsRemoved() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange
            CustomList<string> myList = new();

            //act
            myList.Add("hello");
            myList.Add("there");
            myList.Add("hello");
            myList.Remove("hello");

            //assert
            Assert.AreEqual(2, myList.Count);
            Assert.AreEqual("there", myList.Items[0]);
            Assert.AreEqual("hello", myList.Items[1]);
        }
    }
}
