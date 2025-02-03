using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using static Assigment.ListGenerators;
using static System.Net.Mime.MediaTypeNames;

namespace Assigment
{
    internal class Program
    {

        //public class Comparer : IEqualityComparer<string>
        //{
        //    public bool Equals(string x, string y)
        //    {
        //        return String.Concat(x.OrderBy(c => c)).Equals(String.Concat(y.OrderBy(c => c)));
        //    }

        //    public int GetHashCode(string obj)
        //    {
        //        return String.Concat(obj.OrderBy(c => c)).GetHashCode();
        //    }
        //}
        static void Main(string[] args)
        {
            #region LINQ - Partitioning Operators

            #region Q 1.Get the first 3 orders from customers in Washington

            //var result = CustomerList
            //              .Where(c => c.Region == "WA")
            //              .SelectMany(c => c.Orders)
            //              .OrderBy(o => o.OrderDate)
            //              .Take(3)
            //              .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q 2 Get all but the first 2 orders from customers in Washington. 

            //var result = CustomerList
            //            .Where(c => c.Region == "WA")
            //            .SelectMany(c => c.Orders)
            //            .OrderBy(o => o.OrderDate)
            //            .Skip(2)
            //            .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q 3  Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers
            //           .Select((number, index) => new { number, index })
            //           .TakeWhile(x => x.number >= x.index)
            //           .Select(x => x.number)
            //           .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q 4 Get the elements of the array starting from the first element divisible by 3.

            //int[] number = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = number.SkipWhile(n => n % 3 != 0).ToList();


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #endregion


            #region LINQ – Grouping Operators

            #region Q 1 Use group by to partition a list of numbers by their remainder when divided by 5


            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(n => n % 5).ToList();


            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Number with a remainder of {group.Key} when divided by 5 :");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            #endregion


            #region Q 2 Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input


            //    string filePath = "dictionary_english.txt";

            //    List<string> words = File.ReadAllLines(filePath).ToList();

            //    var result = words.GroupBy(word => word[0]);


            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Words starting with '{group.Key}':");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine(); 

            //}

            #endregion

            #region Q 3 Consider this Array as an Input

           
            //    string[] Arr = { "from", "salt", "earn", "last", "near", "form" };
                
            //    var result = Arr.GroupBy(word => word, new Comparer());

            

            //foreach (var group in result)
            //{
                
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    Console.WriteLine("...");
            //}

            #endregion




            #endregion




        }
    }
}
