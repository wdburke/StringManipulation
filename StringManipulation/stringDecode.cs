using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using PrimeTest;

namespace StringManipulation
{
    public class StringManip
    {
        public static int PrimeSum { get; set; }
               
        public static int CompositeSum { get; set; }
               
        public static string AsciiShift { get; set; }
               
        public static void NumberClassify()
        {
            var inputVal = MainWindow.InputVal;
            var compositeNumbers = new List<int>();
            var primeNumbers = new List<int>();
            var inputValArray = inputVal.ToCharArray();
            foreach (var t in inputValArray)
            {
                int inputValInt;
                try
                {
                    inputValInt = Convert.ToInt32(t.ToString());
                }
                catch (Exception)
                {
                    continue;
                }

                if (inputValInt>1)
                {
                    var primeTestResults = PrimeTesting.Test(inputValInt);

                    if (primeTestResults)
                    {
                        primeNumbers.Add(inputValInt);
                    }
                    else
                    {
                        compositeNumbers.Add(inputValInt);
                    }
                }
            }
        CompositeSum = compositeNumbers.Sum();
        PrimeSum= primeNumbers.Sum();
        AsciiAccelerate();
        }
               
        public static void AsciiAccelerate()
        {
            string inputVal = MainWindow.InputVal;
            var inputValArray = inputVal.ToCharArray();
            char[] modifyArray = new char[25];
            int modArrayCt = 0;
            for (int i = 0; modArrayCt < 25; i++)
            {
                if (!(Char.IsDigit(inputValArray[i])))
                {
                    modifyArray[modArrayCt] = inputValArray[i];
                    modArrayCt += 1;
                }
            }
            foreach (char c in modifyArray)
            {
                char newVal = (char) (c + 1);
                AsciiShift = AsciiShift + newVal.ToString();
            }
            StringCreate();
        }
               
        public static void StringCreate()
        {
            var sum = CompositeSum*PrimeSum;
            MainWindow.InputVal =  AsciiShift + sum.ToString();
        }
    }
}