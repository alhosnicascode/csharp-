namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock Facebook = new Stock("facebook");
            Facebook.Price = 100;
            Facebook.OnPriceChanged += Facebook_OnPriceChanged;
            Console.WriteLine($" {Facebook.Name} : {Facebook.Price}");
            Facebook.changeStockPrice(0.5m);
            //Console.WriteLine($" {Facebook.Name} : {Facebook.Price}");
            Facebook.changeStockPrice(-0.03m);
        }

        private static void Facebook_OnPriceChanged(Stock stock, decimal oldprice)
        {
           if(stock.Price > oldprice)
            {
                Console.WriteLine($"{stock.Name} : {stock.Price} --> condition: increased");
            }else if(stock.Price<oldprice)
            {
                Console.WriteLine($"{stock.Name} : {stock.Price} --> condition: decreased");


            }
        }
    }

    public delegate void priceChangedwatch(Stock stock, decimal oldprice);
   public  class Stock
    {
        private string  name  ;
        private decimal price;

        public event priceChangedwatch OnPriceChanged;
        public string Name => this.name;
        public decimal Price {
            get => this.price; set => this.price = value;   
       }
        
        public Stock(string name)
        {
            this.name = name;
        }
        public void changeStockPrice(decimal Percentage)
        {   decimal prevprice = this.price;
            this.price += price * Percentage;
            if(OnPriceChanged != null)
            {
                OnPriceChanged(this, prevprice);

            }
        }

    }
}