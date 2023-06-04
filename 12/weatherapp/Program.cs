namespace WeatherApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weather w1 = new Weather(24);
            //alarm.Onchanged += w1.ChangeWeather;
            w1.onweatherChanged += W1_onweatherChanged;
            w1.changeWeather(45);
            //Console.WriteLine(w1.Condition);
        
        }

        private static void W1_onweatherChanged(Weather w)
        {
            Console.Write($"The Temprature is CHANGED  {w.Temprateure} \n SO THE Condition is  {w.Condition}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}