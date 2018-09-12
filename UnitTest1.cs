using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using CustomListProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_TwoIntsToList()         
        {
            //arrange
            MyCustomList<int> test  = new MyCustomList<int>();

            int item1 = 6;
            int item2 = 5;

            //act
            test.Add(item1);
            test.Add(item2);
            
            //assert
            Assert.AreEqual(item1, test[0]);
        }
        
            [TestMethod]
            public void Add_MultipleStringsToList()
            {
            //arrange
            MyCustomList<string> test = new MyCustomList<string>();

            string item1 = "December";
            string item2 = "May";
            string item3 = "October";
            string item4 = "March";
            string item5 = "January";
            string item6 = "April";
            

            test.Add(1); 
            test.Add(2); 
            test.Add(3); 
            test.Add(4);
            test.Add(5);
            test.Add(6);
            

            //act
            Assert.AreEqual(item1, test[0]);

            }

            [TestMethod]
            public void Add_DecimalToIndexZero()
        {
            //arrange
            MyCustomList<double> test = new MyCustomList<double>();

            double item = 3.14;

            //assert
            test.Add(item);

            //act
            Assert.AreEqual(item, test[0]);

            }

        [TestMethod]
        public void Add_MutipleDecimalsToIndex()
        {
            //arrange
            MyCustomList<double> test = new MyCustomList<double>();

            double item1 = 0.966;
            double item2 = 2.59;
            double item3 = 11.22;

            //assert
            test.Add(item1);
            test.Add(item2);
            test.Add(item3);

            //act
            Assert.AreEqual(item1, test[0]);

        }
        [TestMethod]
        public void Add_NegativeIntToIndexZero()
        {
            //arrange
            MyCustomList<int> test = new MyCustomList<int>();

            int item1 = -17;

            //assert
            test.Add(item1);

            //act
            Assert.AreEqual(item1, test[0]);
        }
        [TestMethod]
        public void Remove_IntFromList()
        {
            //arrange
            MyCustomList<int> test = new MyCustomList<int>();

            int item1 = 10;
            int item2 = 15;
            test.Add(item1);
            test.Add(item2);

            //act
            test.Remove(item1);
            
            //act
            Assert.AreEqual(item2, test[0]);
        }

        public void Remove_DecimalFromList()
        {
            //arrange
            MyCustomList<double> test = new MyCustomList<double>();

            double item1 = 6.130;
            double item2 = 1.59;
            test.Add(item1);
            test.Add(item2);

            //act
            test.Remove(item2);

            //act
            Assert.AreEqual(item1, test[0]);
        }
        [TestMethod]
        public void Remove_StringFromList()
        {
            //arrange
            MyCustomList<string> test = new MyCustomList<string>();

            string item1 = "Blue";
            string item2 = "Red";
            test.Add(item1);
            test.Add(item2);

            //act
            test.Remove(item2);

            //act
            Assert.AreEqual(item1, test[0]);
        }
        [TestMethod]
        public void Remove_NegativeIntsFromList()
        {
            //arrange
            MyCustomList<double> test = new MyCustomList<double>();

            double item1 = -44;
            double item2 = -3.14;
            test.Add(item1);
            test.Add(item2);

            //act
            test.Remove(item2);

            //act
            Assert.AreEqual(item1, test[0]);
        }
        [TestMethod]
        public void Remove_NegativeDecimalFromList()
        {
            //arrange
            MyCustomList<double> test = new MyCustomList<double>();

            double item1 = (-2.64);
            double item2 = (-3.41);
            double item3 = (-0.16);
            test.Add(item1);
            test.Add(item2);
            test.Add(item3);

            //act
            test.Remove(item2);

            //act
            Assert.AreEqual(item1, test[0]);
        }
        [TestMethod]
        public void AddOperator_Ints()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>() { 5, 10 };
            MyCustomList<int> list2 = new MyCustomList<int>() { 15, 20 };
            MyCustomList<int> list3 = new MyCustomList<int>();
            MyCustomList<int> expectedResult = new MyCustomList<int>() { 5, 10, 15, 20 };

            //act
            list3 = (list1 + list2);

            //assert
            Assert.AreEqual(expectedResult, list3[2]);
        }
        
        [TestMethod]
        public void AddOperator_Strings()
        {
            //arrange
            MyCustomList<string> list1 = new MyCustomList<string>() { "red", "orange", "yellow" };
            MyCustomList<string> list2 = new MyCustomList<string>() { "green", "blue", "violet" };
            MyCustomList<string> list3 = new MyCustomList<string>();
            MyCustomList<string> expectedResult = new MyCustomList<string>() { "red", "orange", "yellow", "green", "blue", "violet" };
            
            //act
            list3 = (list1 + list2);

            //assert
            Assert.AreEqual(expectedResult, list3[3]);

        }
        [TestMethod]
        public void AddOperator_Decimals()
        {
            //arrange
            MyCustomList<double> list1 = new MyCustomList<double>() { 1.5, 3.5, 5.5, 7.5 };
            MyCustomList<double> list2 = new MyCustomList<double>() { 2.5, 4.5, 6.5, 8.5 };
            MyCustomList<double> list3 = new MyCustomList<double>();
            MyCustomList<string> expectedResult = new MyCustomList<string>() { 1.5, 3.5, 5.5, 7.5, 2.5, 4.5, 6.5, 8.5 };

            //act
            list3 = (list1 + list2);

            //assert
            Assert.AreEqual(expectedResult, list3[4]);
        }
        [TestMethod]
        public void AddOperator_StringAndInt()
        {
           MyCustomList<string> list1 = new MyCustomList<string>()
        }
        
                
            }

    


         
               
            }
        
    }
}
