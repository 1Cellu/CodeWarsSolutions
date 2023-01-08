using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Kata
{
    public class Kata
    {

        public string DuplicateEncode(string word)
        {
            var wordTrated = word.ToLower();
            var chars = wordTrated.Distinct();
            var arr = wordTrated.ToArray();
            var retorno = wordTrated;
            foreach (char c in arr)
            {
                if(arr.Count(x => x == c) > 1)
                {
                    retorno = retorno.Replace(c, ')');
                }
                else
                {
                    retorno = retorno.Replace(c, '(');
                }
            }
            return retorno;
        }

        #region DescendingOrder

        //public int DescendingOrder(int num)
        //{
        //    var text = "";
        //    var arr = num.ToString().OrderByDescending(c => c).ToArray();
        //    foreach (int i in arr)
        //    {
        //        text += i - 48;
        //    }
        //    return Convert.ToInt32(text);
        //}

        #endregion

        #region MostFreq

        //public List<string> MostFreq(string s)
        //{
        //    List<string> frequents = s.Replace("#", "").Replace("\"", "").Replace("/", "").Replace(".", "").Replace("\r", "").Replace("\n", "").Replace(",","").Split(" ").ToList();
        //    List<string> unics = frequents.Distinct().ToList();
        //    for (int i=0; i<frequents.Count; i++)
        //    {
        //        frequents.Count(unics[i]);
        //    }

        //    Console.ReadLine();

        //    return frequents;
        //}
        #endregion

        #region DoneOrNot
        //public string DoneOrNot(int[][] board)
        //{
        //    var validSudoku = true;

        //    foreach (int[] i in board)
        //    {
        //        var validValues = i.Any(x => x < 0 || x > 10);
        //        if (!validValues)
        //        {
        //            var uniqueValues = i.Distinct().Count() == i.Count();
        //            if (!uniqueValues)
        //            {
        //                validSudoku = false;
        //            }
        //        }
        //        else
        //        {
        //            validSudoku = false;
        //        }
        //    }

        //    if (validSudoku)
        //    {
        //        List<int> valueByPosition = new List<int>();
        //        for (int j = 0; j < board.Length; j++)
        //        {
        //            for (int m = 0; m < 9; m++)
        //            {
        //                valueByPosition.Add(board[m][j]);
        //            }
        //            if (valueByPosition.Count >= 9)
        //            {
        //                if (valueByPosition.Distinct().Count() == 9)
        //                {
        //                    valueByPosition.Clear();
        //                }
        //                else
        //                {
        //                    validSudoku = false;
        //                    break;
        //                };
        //            }
        //        }
        //    }

        //    if (validSudoku)
        //    {
        //        List<int> valueByQuadrant = new List<int>();
        //        var control = 0;
        //        while (control < 81)
        //        {
        //            for (int j = control / 3; valueByQuadrant.Count < 9;)
        //            {
        //                int m = 0;
        //                for (m = j / 3; m < j / 3 + 3; m++)
        //                {
        //                    valueByQuadrant.Add(board[m][j]);  
        //                    control++;
        //                }
        //                j++;
        //            }
        //            if (valueByQuadrant.Count >= 9)
        //            {
        //                if (valueByQuadrant.Distinct().Count() == 9)
        //                {
        //                    valueByQuadrant.Clear();
        //                }
        //                else
        //                {
        //                    validSudoku = false;
        //                    break;
        //                };
        //            }
        //        }
        //    }
        //    return validSudoku ? "Finished!" : "Try again!";

        //}

        #endregion

        #region Alphanumerics
        //public bool Alphanumeric(string str)
        //{
        //    return Regex.IsMatch(str.ToString().ToLower(), @"^[a-zA-Z0-9_]*$") ? true : false;
        //}
        #endregion

        #region Valid Parentheses
        //public static bool ValidParentheses(string input)
        //{
        //    var arr = input.ToString().Split().ToArray();
        //    Array.Sort(arr);
        //    var num = (decimal)arr.Length / 2;
        //    var dec = (int)Math.Floor(num);
        //    if (arr[dec] == "(" && arr[dec] == ")") return true;
        //    return false;
        //}
        #endregion

        #region Greed is Good
        //public int Score(int[] dice)
        //{
        //    Array.Sort(dice);
        //    var score = 0;

        //    if ((dice[0] == dice[1] && dice[1] == dice[2]) ||
        //        (dice[1] == dice[2] && dice[2] == dice[3]) ||
        //        (dice[2] == dice[3] && dice[3] == dice[4]))
        //    {
        //        if (dice[2] != 1) score += dice[2] * 100;
        //        else score += 1000;
        //    }


        //    if (!(dice.Count(x => x == 1) == 3) && dice.Contains(1))
        //    {
        //        if (dice.Count(x => x == 1) == 5 || dice.Count(x => x == 1) == 2) score += 200;
        //        else score += 100;

        //    }

        //    if (dice.Count(x => x == 5) == 1 || dice.Count(x => x == 5) == 4
        //        || dice.Count(x => x == 5) == 5 || dice.Count(x => x == 5) == 2)
        //    {
        //        if (dice.Count(x => x == 5) == 5 || dice.Count(x => x == 5) == 2) score += 100;
        //        else score += 50;
        //    }

        //    return score;
        //}
        #endregion

        #region ParseAndOperate
        //public int[] Parse(string data)
        //{
        //    var value = 0;
        //    var arr = new List<int>();
        //    foreach (char str in data.ToArray()) {
        //        switch (str.ToString())
        //        {
        //            case "i":
        //                value++;
        //                break;
        //            case "d":
        //                value--;
        //                break;
        //            case "s":
        //                value *= value;
        //                break;
        //            case "o":
        //                arr.Add(value);
        //                break;
        //            default:
        //                continue;
        //        }
        //    }

        //    return arr.ToArray();
        //}
        #endregion

        //public string Balance(string book)
        //{
        //book = book.Replace("!", " ").Replace("=", " ").Replace(":", " ").Replace("  ", " ").Replace("  ", " ");
        //var lines = book.Split("\n");
        //book.Replace("\r\n", "");
        //var result = "";

        //var originalBalance = "Original Balance: " + lines[1].ToString() + "\r\n";
        //var balance = Decimal.Parse(lines[0], CultureInfo.InvariantCulture);
        //var liness = lines[1..];
        //var spend = 0.00m;
        //var i = 0;

        //foreach (string line in liness)
        //{
        //    var lineArray = line.Split(" ");
        //    balance -= Decimal.Parse(lineArray[2], CultureInfo.InvariantCulture);
        //    spend += Decimal.Parse(lineArray[2], CultureInfo.InvariantCulture);
        //    var balanceString = balance.ToString("F").Replace(",", ".");
        //    result += lineArray[0] + " " + lineArray[1] + " " + lineArray[2] + " Balance " + balanceString + "\r\n";
        //    i++;
        //}

        //var averageExpense = (spend / i).ToString("F2");

        //result = originalBalance + result + "Total expense  " + spend.ToString() + "\n" + "Average expense  " + averageExpense;

        //    Regex r = new Regex(@"/^[a-z0-9]+$/i", RegexOptions.IgnoreCase);
        //    var s = r.Match(book);

        //    return "";
        //}
        #region Take a Number And Sum Its Digits Raised To The Consecutive Powers And ....¡Eureka!!

        //public long[] SumDigPow(long a, long b)
        //{
        //    double elevator = 1;
        //    var result = new long();
        //    List<long> list = new List<long>();


        //    while (a < b)
        //    {
        //        var arr = a;
        //        List<long> listOfInts = new List<long>();
        //        while (arr > 0)
        //        {
        //            listOfInts.Add(arr % 10);
        //            arr = arr / 10;
        //        }
        //        listOfInts.Reverse();

        //        foreach (int num in listOfInts)
        //        {
        //            double o = Convert.ToDouble(num);
        //            double r = Math.Pow(o, elevator);
        //            result += long.Parse(r.ToString());
        //            elevator++;
        //        }

        //        if (a == result)
        //        {
        //            list.Add(result);
        //        }
        //        result = 0l;
        //        elevator = 1;
        //        a++;            
        //    }

        //    long[] resultado = list.ToArray();

        //    return resultado;
        //}


        #endregion

        #region You only need one
        //public bool Check(object[] a, object x)
        //{
        //    return (a.Contains(x)) ? true : false;
        //}

        //return a.Contains(x);

        // public static bool Check(object[] a, object v) => a.Contains(v);

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