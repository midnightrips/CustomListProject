using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod] //test 1: count increments as items added
        public void AddMethod_AddItems_CountIncremented() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }

        [TestMethod] //test 2: first item added is found at 0 index
        public void AddMethod_AddOneItem_ItemAtIndexZero() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }
        [TestMethod] //test 3:second item added is found at 1 index
        public void AddMethod_AddTwoItems_SecondItemAtIndexOne() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }
        [TestMethod] //test 4: capacity increases when exceeded
        public void AddMethod_CapacityExceeded_CapacityIncreased() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }
        [TestMethod] //test 5: after capacity increases, at least one of the original items persists in same index
        public void AddMethod_OriginalItemRemainsAtSameIndexAfterCapacityIncreases_ItemAtItsOriginalIndex() //method being tested_the situation we are testing_what we expect to happen
        {
            //arrange


            //act


            //assert

        }
    }
}