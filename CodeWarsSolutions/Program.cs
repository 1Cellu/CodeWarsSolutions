using System;
using Kata;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            var instance = new Kata.Kata();
            Console.WriteLine(instance.DoneOrNot(new int[][]
        {
          new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
          new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
          new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
          new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
          new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
          new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
          new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
          new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
          new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
        }));

            #region ParseAndOperate

            //var instance = new Kata.Kata();
            //instance.Parse("issodddd");

            #endregion

            //var instance = new Kata.Kata();
            //Console.WriteLine(instance.Balance("1000.00 !=\n125 Market !=:125.45\n126 Hardware = 34.95\n127 Video! 7.45\n128 Book: 14.32\n129 Gasoline::16.10"));

            #region Take a Number And Sum Its Digits Raised To The Consecutive Powers And ....¡Eureka!!

            //var instance = new Kata.Kata();
            //long[] arr = { 1, 2, 3 };
            //instance.SumDigPow(1, 20);

            #endregion

            #region You only need one

            //var instance = new Kata.Kata();
            //string[] arr = { "a", "b", "c"};
            //instance.Check(arr, "a");
            //Console.WriteLine(instance.Check(arr, "a"));

            #endregion

            #region Fix My Phone Number

            //var instance = new Kata.Kata();
            //instance.IsItANum("S:)0207ERGQREG88349F82!efRF)");
            //Console.ReadLine();

            #endregion

            #region Funny Dots

            //Kata.Kata instance = new Kata.Kata();
            //var n = 1;
            //var m = 2;

            //instance.Dot(n, m);

            //Console.ReadLine();
            #endregion

            #region +1Array 

            //Kata.Kata instance = new Kata.Kata();
            //var arr = new int[] { 9, 3, 6, 4, 1, 2 };     
            //Console.WriteLine(instance.UpArray1(arr));
            //Console.WriteLine(instance.UpArray2(arr));
            //Console.WriteLine(instance.UpArray3(arr));
            //Console.ReadLine();

            #endregion
        }
    }
}

