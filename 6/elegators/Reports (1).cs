using System;

namespace delegators
{
    internal class Reports
    {
        public delegate bool SalesConditon(Employee e);
        public void ProcessEmployee(Employee[] emp ,string Title , SalesConditon cond)
        {

            Console.WriteLine(Title);
            Console.WriteLine("------------------------------------------------");
            foreach (Employee e in emp)
            {
                if (cond(e))
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.gender} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");

        }
        #region DlegateBefore
        //public void ProcessEmployee(Employee[] emp, string Title, ?? )
        //{

        //    Console.WriteLine(Title);
        //    Console.WriteLine("------------------------------------------------");
        //    foreach (Employee e in emp)
        //    {
        //        if (e.TotalSales >= ?? )
        //        {
        //            Console.WriteLine($"{e.Id} | {e.Name} | {e.gender} | {e.TotalSales}");
        //        }
        //    }
        //    Console.WriteLine("\n\n");

        //} 
        #endregion

        #region oldFunction
        //    public void TotalSalesmorethan60k(Employee[] emp)
        //    {
        //        Console.WriteLine("report for employees total sales morethan 60k");
        //        Console.WriteLine("------------------------------------------------");
        //        foreach (Employee e in emp) { 
        //            if(e.TotalSales >= 60000m)
        //            {
        //                Console.WriteLine($"{e.Id} | {e.Name} | {e.gender} | {e.TotalSales}");
        //            }
        //        }
        //        Console.WriteLine("\n\n");
        //    }

        //public void TotalSalesbetween30kto59999k(Employee[] emp)
        //{
        //    Console.WriteLine("report for employees total sales between 30k to 60k");
        //    Console.WriteLine("------------------------------------------------");
        //    foreach (Employee e in emp)
        //    {
        //        if ( 30000m <= e.TotalSales && e.TotalSales <= 59999m)
        //        {
        //            Console.WriteLine($"{e.Id} | {e.Name} | {e.gender} | {e.TotalSales}");
        //        }
        //    }
        //    Console.WriteLine("\n\n");
        //}

        //    public void TotalSaleslessthan30k(Employee[] emp)
        //    {
        //        Console.WriteLine("report for employees total sales lessThan 30k");
        //        Console.WriteLine("------------------------------------------------");
        //        foreach (Employee e in emp)
        //        {
        //            if ( e.TotalSales < 30000)
        //            {
        //                Console.WriteLine($"{e.Id} | {e.Name} | {e.gender} | {e.TotalSales}");
        //            }
        //        }
        //        Console.WriteLine("\n\n");
        //    } 
        #endregion
    }
}
