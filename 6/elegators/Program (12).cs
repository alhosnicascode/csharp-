namespace delegators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[]
            {
                new Employee{Id=1 , Name="yousif" , gender='m' , TotalSales=70000m},
                new Employee{Id=2 , Name="ahmed" , gender='m' , TotalSales=15000m},
                new Employee{Id=3 , Name="mohamed" , gender='m' , TotalSales=30000m},
                new Employee{Id=4 , Name="mirna" , gender='f' , TotalSales=27000m},
                new Employee{Id=5 , Name="ziko" , gender='m' , TotalSales=82000m},
                new Employee{Id=6 , Name="hmada" , gender='m' , TotalSales=60000m},
                new Employee{Id=7 , Name="lolsh" , gender='f' , TotalSales=50000m},
                new Employee{Id=8 , Name="dodo" , gender='f' , TotalSales=10000m},
            };
            Reports reports = new Reports();
            reports.ProcessEmployee(emps, "total sales morethan 60 k",(emp) => emp.TotalSales >= 60000m);
            reports.ProcessEmployee(emps, "total sales between 30 to 60 k",(emp) => emp.TotalSales >= 30000m && emp.TotalSales <= 60000m);
            reports.ProcessEmployee(emps, "total sales lessthan 30k", (emp) => emp.TotalSales < 30000m);

            bool greater60(Employee emp) => emp.TotalSales >= 60000m;
            bool inbetween3060(Employee emp) => emp.TotalSales>=30000m && emp.TotalSales <= 60000m;
            bool lessthan30(Employee emp) => emp.TotalSales < 30000m;
            //reports.TotalSalesmorethan60k(emps);
            //reports.TotalSalesbetween30kto59999k(emps);
            //reports.TotalSaleslessthan30k(emps);
        }
    }
   
}