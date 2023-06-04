namespace ENUMS
{
    enum Months
    {
        jan,
        feb,
        mar,
        april,
        may,
        june,
        july,
        aug,
        sep,
        oct,
        nov,
        dec
    }
    [Flags]
    enum Permissions
    {
        None = 0, //    0b_0000_0000 ->0
        Read = 1, //    0b_0000_0001 ->1
        Write = 2,//    0b_0000_0010-->2
        Delete = 4,//   0b_0000_0100-->4
        Execute = 8, //  0b_0000_1000-->8
        Level1 = Read | Write,
        Admin = Read | Write | Delete,
        superAdmin = Read | Write | Delete | Execute,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region simple Enum
            //Months months = Months.june;
            //Console.WriteLine((int)months); 

            #endregion
            #region Enum Flag 

            ////flags targeting the True or Flase 
            //Permissions mypermissions = Permissions.Read | Permissions.Write;
            //Console.WriteLine(mypermissions); // outputs: read, write

            //Permissions User = Permissions.Read | Permissions.Write;
            //if(User.HasFlag(Permissions.Level1))
            //{
            //    Console.WriteLine($"you have only read write your CARDENTIALS IS :" +
            //        $" {Permissions.Level1.ToString()} ");
            //} 
            #endregion

            #region EnumParsing

            //var month = "feb";
            //Console.WriteLine((int)(Enum.Parse(typeof(Months) ,month)));

            //if (Enum.TryParse(month, out Months mnth))
            //{
            //    Console.WriteLine(mnth);
            //}
            //if(Enum.IsDefined(typeof(Months), month))
            //{
            //    Console.WriteLine(Enum.Parse(typeof(Months), month));
            //} 
            #endregion

            #region Foreach on enums
            //foreach(Months mnth in Enum.GetValues(typeof(Months)) )
            //{
            //    Console.WriteLine(mnth + ":"+ (int)mnth );
            //} 
            #endregion


        }
    }
}