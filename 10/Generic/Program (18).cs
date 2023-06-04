namespace Genericintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayMethod
            ////Print(1);
            ////Print("hello there ");

            ////#region Objectuse

            ////Print(new { firstname = "usif", lastname = "mohamed" });
            ////Print(new Person { Fname = "usif", Lname = "mohamed" });

            //#endregion 
            #endregion

            arr<int> numbers = new arr<int>();
            numbers.add(1);
            numbers.add(2);
            numbers.add(3);
            numbers.add(4);
            numbers.Removeat(0);
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.isEmpty); 
            numbers.display();

            arr<Person> people = new arr<Person>();
            people.add(new Person() {Fname="joe" , Lname = "Mohamed" });
            people.add(new Person() {Fname="lolo" , Lname = "mohamed" });
            people.display();
            List<Person>peopls = new List<Person>();


        }
        #region ArrayMethod
        //    public static void Print<T>(T obj )
        //    {
        //        Console.WriteLine($"Datatype : {typeof(T)}");
        //        Console.WriteLine(obj);
        //    }
        //    //public static void Print(int value)
        //    //{
        //    //    Console.WriteLine(value);
        //    //}

        //    //public static void Print(string value)
        //    //{
        //    //    Console.WriteLine(value);
        //    //}

        //}
        //class Person

        //{
        //    public string  Fname { get; set; }
        //    public string Lname { get; set; }
        //} 
        #endregion
    }
    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public override string ToString()
        {
            return $"{Fname} {Lname}";
        }
    }
    class arr<T> //where T : class
    {
        private T[] _items;

        public void add(T item)
        {
            if( _items is  null)
            {
                _items = new T[] { item };
            }
            else
            {
                int length = _items.Length;
                T[] Temp = new T[length+1];
                for (int i = 0; i < length; i++)
                {
                    Temp[i] = _items[i];

                }
                Temp[Temp.Length - 1] = item; 
                _items = Temp;
            }

        }

        public void Removeat(int index) {
            if(index <0 || index > _items.Length -1)
            {
                return;
            }
            int pos = 0;
            T[] TEMP = new T[_items.Length-1];
            for (int i = 0; i < _items.Length; i++)
            {
                if(index == i)
                {
                    continue;
                }
                TEMP[pos++] = _items[i];
            }
            _items = TEMP;

        }
        public bool isEmpty =>  _items is null  || _items.Length == 0;

        public int Count => _items.Length;

        public void display()
        {
            Console.Write("[");
            foreach (T item in _items)
            {
                Console.Write(item + ",");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }

    #region boilerplateclassGeneric
    //class all<T>
    //{
    //    private T[] _items;


    //    public void add(T item) { }
    //    public void remove(int index) { }
    //    public void isEmpty( ) { }
    //    public void Count( ) { }
    //    public void display() { }

    //} 
    #endregion
}