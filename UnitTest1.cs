using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        public void Add_IntToList()         
        {
            //arrange
            MyCustomList<int> test  = new MyCustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            
            int expectedResult = 6;

  
            //act
            test.Add(expectedResult, test[5]);


            //assert
            Assert.AreEqual(expectedResult, test1[5]);
        }
        

            public void Add_ValueToIndex4()
            {
                //arrange
                MyCustomList<int> test = new MyCustomList<int>();
                

                test.Add(2); //1 * 2
                test.Add(6); //2 * 3
                test.Add(12); //3 * 4
                test.Add(20); //4 * 5
                      //(30) // 5 * 6                
                int expectedResult = 30;

                //act

                test.Add(30);
                MyCustomList<int> actual = test.Add(30);

                //assert
                // add 30 into [4], result of 5 * 6
                Assert.AreEqual(expectedResult, actual[4]);
            }


            public void Add_MissingIntToIndex2()
            {
                MyCustomList<int> test = new MyCustomList<int>();
                //arrange

                test.Add(1);
                test.Add(2);
                test.Add(4);
                test.Add(5);

                int expectedResult = 3;

                //act

                test.Add(3);
                MyCustomList<int> actual = test.Add(3);
                //assert
                // add 3 to [2]
                Assert.AreEqual(expectedResult, actual[2]);
            }


            public void Add_ValueCheckIndex0()
            {
                MyCustomList<int> test = new MyCustomList<int>();
                //arrange

                test4.Add(1);
                test4.Add(2);
                test4.Add(3);
                test4.Add(4);

                int expectedResult = 0;

                //act

                test4.Add(0);
                MyCustomList<int> actual = test.Add(0);

                //assert
                //insert 0 into [0]
                Assert.AreEqual(expectedResult, actual[0]);
            }


            public void Add_ValueToIndex3()
            {
                MyCustomList<int> test5 = new MyCustomList<int>();
                //arrange

                test5.Add(1);
                test5.Add(3);
                test5.Add(5);
                test5.Add(9);

                int expectedResult = 7;

                //act

                test5.Add(7);
                test5.Count();
                MyCustomList<int> actual = test5.Add(7);

                //assert
                //insert 7 into [3], insert 9 into [4]
                Assert.AreEqual(expectedResult, actual[3]);
            }


            public void Remove_ValuesFromIndex()
            {
                MyCustomList<int> test = new MyCustomList<int>();
               //arrange

               test.Remove(1);
               test.Remove(3);
               test.Remove(5);
               test.Remove(7);
               test.Remove(7);
               test.Remove(9);
               test.Remove(11);
               test.Remove(13);
               test.Remove(15);

                
                

            int expectedResult = 7;


            //act
            MyCustomList<int> actual = test.Remove(7);

            //assert

            Assert.AreEqual(expectedResult, actual[3]);
            }


            public void Remove_StringFromIndex()
            {
                MyCustomList<string> test = new MyCustomList<string>();
            //arrange


            test.Remove("one");
            test.Remove("three");
            test.Remove("five");
            test.Remove("seven");
            test.Remove("nine");
            test.Remove("eleven");
            test.Remove("three");
            test.Remove("thirteen");
            test.Remove("fifteen");
            test.Remove("seventeen");
            test.Remove("nineteen");



            string expectedResult = "three";

             //act

            test.Remove("three");
            MyCustomList<string> test = new MyCustomList<string>();


            //assert

            Assert.AreEqual(expectedResult, test[6]);
            }


            public void Remove_ValueFromIndex()
            {

                MyCustomList<int> test = new MyCustomList<int>();
            //arrange

            test.Remove(5);
            test.Remove(10);
            test.Remove(15);
            test.Remove(20);
            test.Remove(25);
            test.Remove(30);
            test.Remove(35);



            int expectedResult = 30 - 35;

            //act
            test.Remove(10);
            test.RemoveAt(5);
            MyCustomList<int> actual = test.Remove(30); test.Remove(35);


                //assert
                //remove ints 30, 35 [5, 6]
                Assert.AreEqual(expectedResult, test[1, 2, 3]);
            }




            public void Remove_SingleStringFromIndex()
            {
                MyCustomList<string> test = new MyCustomList<string>();
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

                Assert.AreEqual(expectedResult, test[3]);
            }

            public void Remove_MultipleValuesFromIndex()
            {
                MyCustomList<int> test = new MyCustomList<int>();
                //arrange

                test.Add(1);
                test.Add(3);
                test.Add(6);
                test.Add(8);

                int expectedResult = 3;

                //act
                test.Remove(2);
                test.RemoveAt(2);
                MyCustomList<int> actual = test.Add(6) + test.Add(8);
                //assert
                //remove ints 6, 8 at [2, 3]
                Assert.AreEqual(expectedResult, test[2, 3]);
            }




            public void Add_MultipleLists()
            {
                //arange
                MyCustomList<int> test1 = new MyCustomList<int>();
                MyCustomList<int> test2 = new MyCustomList<int>();
                MyCustomList<int> test3 = new MyCustomList<int>();

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
                MyCustomList<int> actual = test1 + test2 + test3;

                //act

                Assert.AreEqual(expectedResult, actual[0, 0]);
            }
        }
    }
}
