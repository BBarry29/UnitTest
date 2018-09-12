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
            MyCustomList<int> test = new MyCustomList<int>();

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

        [TestMethod]
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
            MyCustomList<double> expectedResult = new MyCustomList<double>() { 1.5, 3.5, 5.5, 7.5, 2.5, 4.5, 6.5, 8.5 };

            //act
            list3 = (list1 + list2);

            //assert
            Assert.AreEqual(expectedResult, list3[4]);
        }

        [TestMethod]
        public void AddOperator_StringAndInt()
        {
            //arrange
            MyCustomList<string> list1 = new MyCustomList<string>() { "Illinois", "Minnesota" };
            MyCustomList<string> list2 = new MyCustomList<string>() { "Iowa", "Michigan" };
            MyCustomList<string> list3 = new MyCustomList<string>();
            MyCustomList<string> expectedResult = new MyCustomList<string>() { "Illinois", "Minnesota", "Iowa", "Michigan" };

            //act
            list3 = (list1 + list2);

            //assert
            Assert.AreEqual(expectedResult, list3[2]);
        }

        [TestMethod]
        public void Subtract_IntsFromList()
        {
            //arrange
            MyCustomList<int> list1 = new MyCustomList<int>() { 5, 10, 15, 20 };
            MyCustomList<int> list2 = new MyCustomList<int>() { 5, 15 };
            MyCustomList<int> list3 = new MyCustomList<int>();
            MyCustomList<int> expectedResult = new MyCustomList<int>() { 10, 20};

            //act
            list3 = (list1 - list2);

            //assert
            Assert.AreEqual(expectedResult, list3);
        }

        [TestMethod]
        public void Subtract_StringsFromList()
        {
            //arrange
            MyCustomList<string> list1 = new MyCustomList<string>() { "red", "orange", "yellow", "green", "blue", "indigo", "violet"};
            MyCustomList<string> list2 = new MyCustomList<string>() { "green", "blue", "indigo" };
            MyCustomList<string> list3 = new MyCustomList<string>();
            MyCustomList<string> expectedResult = new MyCustomList<string>() {"red", "orange", "yellow" };

            //act
            list3 = (list1 - list2);

            //assert
            Assert.AreEqual(expectedResult, list3);
        }

        [TestMethod]
        public void Subtract_DecimalFromList()
        {
            //arrange
            MyCustomList<double> list1 = new MyCustomList<double>() { 5.3, 10.2, 15.1 };
            MyCustomList<double> list2 = new MyCustomList<double>() { 5.3 };
            MyCustomList<double> list3 = new MyCustomList<double>();
            MyCustomList<double> expectedResult = new MyCustomList<double>() { 10.2, 15.1};

            //act
            list3 = (list1 - list2);

            //assert
            Assert.AreEqual(expectedResult, list3);
        }

        [TestMethod]
        public void Subtract_NegDecimals()
        {
            //arrange
            MyCustomList<double> list1 = new MyCustomList<double>() { -5.3, -10.2, -15.1 };
            MyCustomList<double> list2 = new MyCustomList<double>() { -10.2 };
            MyCustomList<double> list3 = new MyCustomList<double>();
            MyCustomList<double> expectedResult = new MyCustomList<double>() { -5.3, -15.1 };

            //act
            list3 = (list1 - list2);

            //assert
            Assert.AreEqual(expectedResult, list3);
        }

        [TestMethod]
        public void Zip_IntsInList()
        {
            //Arrange
            MyCustomList<int> zipList1 = new MyCustomList<int>() { 10, 30, 50 };
            MyCustomList<int> zipList2 = new MyCustomList<int>() { 20, 40, 60 };
            MyCustomList<int> expectedResult = new MyCustomList<int>() { 10, 20, 30, 40, 50, 60 };

            //Act
            MyCustomList<int> zipList3 = zipList1.ZipTwoLists(zipList2);

            //Assert
            Assert.AreEqual(expectedResult, zipList3);
        }

        [TestMethod]
        public void Zip_StringsInList()
        {
            //Arrange
            MyCustomList<string> zipList1 = new MyCustomList<string>() { "Wisconsin", "Illinois"};
            MyCustomList<string> zipList2 = new MyCustomList<string>() { "Madison", "Springfield" };
            MyCustomList<string> expectedResult = new MyCustomList<string>() { "Wisconsin", "Madison", "Illinois", "Springfield" };

            //Act
            MyCustomList<string> zipList3 = zipList1.ZipTwoLists(zipList2);

            //Assert
            Assert.AreEqual(expectedResult, zipList3);
        }

        [TestMethod]
        public void Zip_IntsWithStrings()
        {
            MyCustomList<string> zipList1 = new MyCustomList<string>() { "Wisconsin Founded:", "Illinois Founded:" };
            MyCustomList<int> zipList2 = new MyCustomList<int>() { 1848, 1818};
            MyCustomList<string> expectedResult = new MyCustomList<string>() {"Wisconsin Founded:" 1848, "Illinois Founded:" 1818  };

            //Act
            MyCustomList<string> zipList3 = zipList1.ZipITwoLists(zipList2);

            //Assert
            Assert.AreEqual(expectedResult, zipList3);
        }

        [TestMethod]
        public void Zip_IntsToDecimals()
        {
            MyCustomList<int> zipList1 = new MyCustomList<int>() { 1, 2, 3, 4 };
            MyCustomList<double> zipList2 = new MyCustomList<double>() { .1, .2, .3, .4 };
            MyCustomList<double> expectedResult = new MyCustomList<double>() { 1.1, 2.2, 3.3, 4.4 };

            //Act
            MyCustomList<string> zipList3 = zipList1.ZipTwoLists(zipList2);

            //Assert
            Assert.AreEqual(expectedResult, zipList3);
        }
        [TestMethod]
        public void Zip_NegativeInts()
        {
            //Arrange
            MyCustomList<int> zipList1 = new MyCustomList<int>() { -1, -3, -5 };
            MyCustomList<int> zipList2 = new MyCustomList<int>() { -2, -4, -6 };
            MyCustomList<int> expectedResult = new MyCustomList<int>() { -1, -2, -3, -4, -5, -6 };

            //Act
            MyCustomList<int> zipList3 = zipList1.ZipTwoLists(zipList2);

            //Assert
            Assert.AreEqual(expectedResult, zipList3);
        }

        [TestMethod]
        public void Override_ToStringInts()
        {
            //Arrange
            MyCustomList<int> List = new MyCustomList<int>();
            list.Add(09);
            list.Add(11);
            list.Add(18);
            string expected = "091118";

            //Act
            string result = list.ToString();

            //Assert
            Assert.AreEqual(expected, result);
        }
        
            [TestMethod]
            public void Override_ToStringWithString()
        {
            //Arrange
            MyCustomList<string> List = new MyCustomList<string>();
            list.Add("Br");
            list.Add("id");
            list.Add("ge");
            list.Add("t");
            
            string expected = "Bridget";

            //Act
            string result = list.ToString();

            //Assert
            Assert.AreEqual(expected, result);
        }
        
                
            

    


         
               
            
        
    

