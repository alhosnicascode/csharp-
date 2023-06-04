namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock s = new Stock("omantel");
            s.Price = 100m;
            s.changePrice(0.5m);
            Console.WriteLine($"{s.Name} :: {s.Price} ");
            
            //Event Subscribing 
            s.OnPriceChange += S_OnPriceChange;
           
            
            
            s.changePrice(-0.3m);
            s.changePrice(0.7m);

        }

        public static void S_OnPriceChange(Stock stock, decimal oldPrice)
        {
            if (stock.Price > oldPrice)
            {
                Console.WriteLine($"{stock.Name} :: {stock.Price} --> up ");
            }
            else if(stock.Price < oldPrice) {
                Console.WriteLine($"{stock.Name} :: {stock.Price} --> Down ");
                           
            }
        }
    }
    class Stock
    {
        private string name;
        private decimal price;
    
        public string Name => this.name;

        public decimal Price { get => this.price ; set => this.price = value; }
        public Stock(string name)
        {
            this.name = name;
        }

        #region DelegateandEvent
        //Delegate method to observe Stock instance for the Price and combare it with last Price
        public delegate void priceChangeObserver(Stock stock, decimal oldPrice);
       
        //event of delegate with it's name
        public event priceChangeObserver OnPriceChange; 
        #endregion

        public void changePrice(decimal Percentage)
        { 
            decimal oldPrice = this.price;
            this.price +=  this.price * Percentage;

            #region eventCONDTION
            if (OnPriceChange != null)
            {
                OnPriceChange(this, oldPrice);
            } 
            #endregion

        }
    }
}