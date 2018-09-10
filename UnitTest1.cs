using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            public void Add_EvenIntValueToIndex3()
            {
                CustomList<int> test = new CustomList<int>();
                //arrange

                test.Add(2);
                test.Add(4);
                test.Add(6);

                int expectedResult = 8;

                //act

                test.Add(8);
                CustomList<int> actual = test.Add(8);

                //assert
                //insert 8 into [3]
                Assert.AreEqual(expectedResult, actual[3]);
            }


            public void Add_ValueToIndex4()
            {
                CustomList<int> test = new CustomList<int>();
                //arrange

                test.Add(2); //1 * 2
                test.Add(6); //2 * 3
                test.Add(12); //3 * 4
                test.Add(20); //4 * 5
                              //(30) // 5 * 6                
                int expectedResult = 30;

                //act

                test.Add(30);
                CustomList<int> actual = test.Add(30);

                //assert
                // add 30 into [4], result of 5 * 6
                Assert.AreEqual(expectedResult, actual[4]);
            }


            public void Add_MissingIntToIndex2()
            {
                CustomList<int> test = new CustomList<int>();
                //arrange

                test.Add(1);
                test.Add(2);
                test.Add(4);
                test.Add(5);

                int expectedResult = 3;

                //act

                test.Add(3);
                CustomList<int> actual = test.Add(3);
                //assert
                // add 3 to [2]
                Assert.AreEqual(expectedResult, actual[2]);
            }


            public void Add_ValueCheckIndex0()
            {
                CustomList<int> test = new CustomList<int>();
                //arrange

                test.Add(1);
                test.Add(2);
                test.Add(3);
                test.Add(4);

                int expectedResult = 0;

                //act

                test.Add(0);
                CustomList<int> actual = test.Add(0);

                //assert
                //insert 0 into [0]
                Assert.AreEqual(expectedResult, actual[0]);
            }


            public void Add_ValueToIndex3()
            {
                CustomList<int> test = new CustomList<int>();
                //arrange

                test.Add(1);
                test.Add(3);
                test.Add(5);
                test.Add(9);

                int expectedResult = 7;

                //act

                test.Add(7);
                test.Count();
                CustomList<int> actual = test.Add(7);

                //assert
                //insert 7 into [3], insert 9 into [4]
                Assert.AreEqual(expectedResult, actual[3]);
            }


            public void Remove_ValueFromIndex0()
            {
                CustomList<int> test = new CustomList<int>();
                //arrange

                test.Add(1);
                test.Add(3);
                test.Add(5);
                test.Add(7);

                int expectedResult = 7;
                CustomList<int> actual = test.Add(7);

                //act

                test.Remove(7);
                CustomList<int> actual = test.Add(7);


                //assert

                Assert.AreEqual(expectedResult, actual[3]);
            }


            public void Remove_StringFromIndex()
            {
                CustomList<string> test = new CustomList<string>();
                //arrange

                test.Add("one");
                test.Add("three");
                test.Add("five");
                test.Add("seven");



                string expectedResult = "three";

                //act

                test.Remove("three");
                CustomList<string> actual = test.Add("three");


                //assert

                Assert.AreEqual(expectedResult, actual[1]);
            }


            public void Remove_IntValueFromIndex()
            {

                CustomList<int> test = new CustomList<int>();
                //arrange

                test.Add(1);
                test.Add(2);
                test.Add(3);
                test.Add(4);



                int expectedResult = 1 - 3;

                //act
                test.Remove(2);
                test.RemoveAt(1);
                CustomList<int> actual = test.Add(2) - test.Add(3) - test.Add(4);


                //assert
                //remove ints 2, 3, 4, at [1, 2, 3]
                Assert.AreEqual(expectedResult, actual[1, 2, 3]);
            }




            public void Remove_SingleStringFromIndex()
            {
                CustomList<string> test = new CustomList<string>();
                //arrange

                test.Add("one");
                test.Add("two");
                test.Add("three");
                test.Add("four");



                string expectedResult = "four";

                //act
                test.Remove("four");
                test.RemoveAt(3);
                CustomList<string> actual = test.Add("four");


                //assert

                Assert.AreEqual(expectedResult, actual[3]);
            }

            public void Remove_MultipleValuesFromIndex()
            {
                CustomList<int> test = new CustomList<int>();
                //arrange

                test.Add(1);
                test.Add(3);
                test.Add(6);
                test.Add(8);

                int expectedResult = 3;

                //act
                test.Remove(2);
                test.RemoveAt(2);
                CustomList<int> actual = test.Add(6) + test.Add(8);
                //assert
                //remove ints 6, 8 at [2, 3]
                Assert.AreEqual(expectedResult, actual[2, 3]);
            }




            public void Add_MultipleLists()
            {
                //arange
                CustomList<int> test1 = new CustomList<int>();
                CustomList<int> test2 = new CustomList<int>();
                CustomList<int> test3 = new CustomList<int>();

                test1.Add(5);
                test1.Add(10);
                test1.Add(15);
                test1.Add(20);
                test1.Add(25);
                test2.Add(30);
                test2.Add(35);
                test2.Add(40);
                test2.Add(45);
                test2.Add(50);
                test3.Add(55);
                test3.Add(60);
                test3.Add(65);
                test3.Add(70);
                test3.Add(75);

                int expectedResult = test1 + test2 + test3;
                CustomList<int> actual = test1 + test2 + test3;

                //act

                Assert.AreEqual(expectedResult, actual[0, 0]);
            }
    }
}
