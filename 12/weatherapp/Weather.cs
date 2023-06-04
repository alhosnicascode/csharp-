using System;


namespace WeatherApplication
{   
    #region oldWeather
         /*
         10->17 ==> raing and Cold 
         17-25 ==> cloudy No Rain
         25 --42 ==> hot and melt   
     */
        internal class Weather
        {
            public int Temprateure { get; set; }
            public string Condition { get; set; }
            public Weather(int Tempruature)
            {
                this.Temprateure = Tempruature;
                detectCondtion(this.Temprateure);
            }

            public delegate void WeatherChanged(Weather w);

            public event WeatherChanged onweatherChanged;



            public void detectCondtion(int temp)
            {
                if (Temprateure < 17)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    this.Condition = "raining and Cold";
                }
                else if (Temprateure > 17 && Temprateure < 25)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    this.Condition = "Cloudy without Raining ";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    this.Condition = "Hot and Melt ";
                }
            }

            public void changeWeather(int temp)
            {
                this.Temprateure = temp;
                detectCondtion(this.Temprateure);
                if (onweatherChanged != null)
                {
                    onweatherChanged(this);
                }
            }


        }
    }
#endregion