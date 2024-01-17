using CustomList;

namespace CustomListTests
{
    [TestClass]
    internal class RemoveMethodTests
    {
        [TestMethod] //test 1: count decrements when an item is successfully removed
        public void RemoveMethod_ItemRemoved_CountDecremented() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }

        [TestMethod] //test 2: method returns 'true' when an item is successfully removed
        public void RemoveMethod_ItemRemoved_MethodReturnsTrue() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }

        [TestMethod] //test 3: count does NOT decremement when trying to remove an item that is NOT in the CustomList
        public void RemoveMethod_RemovingItemThatIsNotInCustomList_CountRemainsTheSame() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }

        [TestMethod] //test 4: items shift backwards after the item is removed, filling the index of the removed item
        public void RemoveMethod_ItemsShiftBackwardsAfterOneItemRemoved_ItemsFillIndexOfRemovedItem() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }

        [TestMethod] //test 5: when removing an item that exists multiple times, only the first instance is removed
        public void RemoveMethod_RemovingOneInstanceOfAnItemThatExistsMultipleTimes_OnlyFirstInstanceOfItemIsRemoved() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }
    }
}
