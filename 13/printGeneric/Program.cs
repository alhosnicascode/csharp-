namespace printGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PrintOBJ
            //Print("Hello, World!");
            //Print(10);
            //Print(10.36);
            //Print(50);
            //Print(new Person {FName="usif" , LName="mohamed" }); 
            #endregion
            List<int> number = new List<int>();
            number.Add(1);
            ARR<int> numbers  = new ARR<int>(); 
            numbers.add(1);
            numbers.add(2);
            numbers.add(3);
            numbers.add(4);
            numbers.add(5);
            numbers.add(6);
            numbers.Removeat(2);
            numbers.Display();
            ARR<Person> People = new ARR<Person>();
            People.add(new Person() { FName = "yousif" ,LName = "ahmed"});
            People.add(new Person() { FName = "Ahmed" ,LName = "Bakri"});
            People.add(new Person() { FName = "Adel " ,LName = "Mahmoud"});
            People.Display();


        }
        #region tESTINGpRINT
        //public static void Print<T>(T val)
        //{
        //    Console.WriteLine(val);
        //}
        ////public static void Print(int val)
        ////{
        ////    Console.WriteLine(val);
        ////}
        ////public static void Print(double val)
        ////{
        ////    Console.WriteLine(val);
        ////}
        ////public static void Print(string val)
        ////{
        ////    Console.WriteLine(val);
        ////} 
        #endregion
    }
    class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public override string ToString()
        {
            return $"{FName} {LName}";
        }
    }


    class ARR<T>
    {
        private T[] _items; //declare  

        public void add(T item)
        {   if(  _items == null )
            {
                _items = new T[] { item };
            }
            else
            {   
                int length = _items.Length;
                T[] temp = new T[length +1];
                for (int i = 0; i < length ; i++)
                {
                    temp[i] = _items[i];                   
                }
                temp[ temp.Length-1 ] = item; 
                _items = temp;
            }

        }
        public void Removeat(int index)
        {
            T[] temp = new T[ _items.Length-1];
            int pos = 0;
            for (int i = 0; i < _items.Length ; i++)
            {   if(i == index)
                {   
                    continue;
                }

            //0 ,  2 , 3 , 4 
                temp[pos++] = _items[i];
            }
            _items = temp;

        }
        public int Count => _items.Length;
        public bool isEmpty => _items.Length == 0;

        public void Display()
        {
            Console.Write("[");
            foreach (T item in _items)
            {
                Console.Write(item +"," );
            }
            Console.Write("]");
            Console.WriteLine();
        }

    }
}