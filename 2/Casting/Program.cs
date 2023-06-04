static void Main(string[] args)
{

    //implicit Casting

    int x = 100000000;

    long y = x;
    float f = 3.14159f;
    double d = f;

    decimal dec = 123.456m;


    //Explicit Casting

    double t = 3.14159;
    int i = (int)t;


    //boxing and unboxing
    int ni = 42;
    object o = ni;



    int j = (int)o;






    string value = "9999";
    int u = int.Parse(value);
    int p = Convert.ToInt32(value);
    dynamic result =  (int.TryParse(value, out int z) ) ? z : "error"  ;


    //TryParse

    string input = "123";
    int number;

    if (int.TryParse(input, out number))
    {
       Console.WriteLine("Conversion successful. Number: {0}", number);
    }
    else
   {
       Console.WriteLine("Conversion failed.");
    }




}
