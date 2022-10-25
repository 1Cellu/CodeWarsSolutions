using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Kata
    {

        #region You only need one
        //public bool Check(object[] a, object x)
        //{
        //    return (a.Contains(x)) ? true : false;
        //}

        #endregion

        #region Fix My Phone Number
        //public String IsItANum(string str)
        //{
        //    var arr = str.ToCharArray();
        //    List<char> list = new List<char>();

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (Char.IsDigit(arr[i])) list.Add(arr[i]);
        //    }

        //    return list.Count == 11 && list.IndexOf('0') == 0 ? string.Join("", list.ToArray()) : "Not a phone number";
        //}


        #endregion

        #region Funny Dots
        //public string Dot(int n, int m)
        //{
        //    var stringConcateneted = "";

        //    var firstPoint = true;
        //    if (firstPoint)
        //    {
        //        stringConcateneted += String.Concat(Enumerable.Repeat("+---", n)) + "+\n" +
        //                              String.Concat(Enumerable.Repeat("| o ", n)) + "|\n" +
        //                              String.Concat(Enumerable.Repeat("+---", n)) + "+";

        //        Console.WriteLine(stringConcateneted);
        //        firstPoint = false;
        //    }

        //    if (!firstPoint)
        //    {
        //        stringConcateneted += String.Concat(Enumerable.Repeat("\n" + String.Concat(Enumerable.Repeat("| o ", n)) + "|\n" +
        //                              String.Concat(Enumerable.Repeat("+---", n)) + "+", (m - 1)));

        //        Console.WriteLine(stringConcateneted);
        //    }
        //    return String.Empty;
        //}
        #endregion

        #region +1Array
        //public int[] UpArray1(int[] num)
        //{

        //    var total = "";
        //    if (num != null)
        //    {
        //        for (int i = 0; i < num.Length; i++)
        //        {
        //            if (num[i] >= 0 && num[i] <= 10)
        //            {
        //                total += num[i].ToString();
        //            }
        //            else
        //            {
        //                return null;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //    if (total != null && total != "")
        //    {
        //        var arrayResult = total.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
        //        if (arrayResult[arrayResult.Length - 1] == 9)
        //        {
        //            if (int.TryParse(total, System.Globalization.NumberStyles.HexNumber, null, out int i))
        //            {
        //                var result = Convert.ToInt64(total) + 1;
        //                arrayResult = result.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
        //            }
        //            else
        //            {
        //                arrayResult[arrayResult.Length - 1] = 0;
        //                arrayResult[arrayResult.Length - 2] = arrayResult[arrayResult.Length - 2] + 1;
        //            }
        //        }
        //        else
        //        {
        //            arrayResult[arrayResult.Length - 1] = arrayResult[arrayResult.Length - 1] + 1;
        //        }
        //        return arrayResult;
        //    }
        //    return null;
        //}

        //public int[] UpArray2(int[] num)
        //{
        //    if (num.Length == 0 || num.Any(a => a < 0 || a > 9))
        //    {
        //        return null;
        //    }

        //    for (var i = num.Length - 1; i >= 0; i--)
        //    {
        //        if (num[i] == 9)
        //        {
        //            num[i] = 0;
        //        }
        //        else
        //        {
        //            num[i]++;
        //            return num;
        //        }
        //    }
        //    return new[] { 1 }.Concat(num).ToArray();
        //}

        //public int[] UpArray3(int[] num)
        //{
        //    string joinedNumber = string.Join(string.Empty, num);
        //    if (num.Length == 0 || joinedNumber.Length != num.Length)
        //    {
        //        // Means num was empty or there was a '-' or an integer greater than 9 in num
        //        return null;
        //    }

        //    List<int> result = new List<int>();

        //    // Starting with one to add the one
        //    int carryover = 1;
        //    for (int i = num.Length - 1; i >= 0; i--)
        //    {
        //        int value = num[i] + carryover;
        //        carryover = value / 10;
        //        value %= 10;

        //        result.Insert(0, value);
        //    }

        //    if (carryover > 0)
        //    {
        //        result.Insert(0, carryover);
        //    }

        //    return result.ToArray();
        //}

        #endregion
    }
}