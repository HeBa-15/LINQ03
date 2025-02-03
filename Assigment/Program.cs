using static Assigment.ListGenerators;
namespace Assigment
{
    internal class Program
    {
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
           
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

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
        }
    }
}