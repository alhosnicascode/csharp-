using System.Dynamic;

namespace Indexer_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook book  = new PhoneBook(5);
            book.SetEntry(0,"usif" , 123);
            book.SetEntry(1,"ali" , 456);
            book.SetEntry(2,"monzer" , 789);
            book.SetEntry(3,"khalil" , 112233);
            Console.WriteLine(book["ali"]);
            book[1, "ahmed"] = 445566;
            Console.WriteLine(book[1]);

            int[,] userInput = new int[,] {
             { 8, 3, 5, 4, 1, 6, 9, 2, 7 },
             {2, 9, 6, 8, 5, 7, 4, 3, 1},
             {4, 1, 7, 2, 9, 3, 6, 5, 8},
             {5, 6, 9, 1, 3, 4, 7, 8, 2},
             {1, 2, 3, 6, 7, 8, 5, 4, 9},
             {7, 4, 8, 5, 2, 9, 1, 6, 3},
             {6, 5, 2, 7, 8, 1, 3, 9, 4},
             {9, 8, 1, 3, 4, 5, 2, 7, 6},
             { 3, 7, 4, 9, 6, 2, 8, 1,5 }
            };
            Sudoko sudoko = new Sudoko(userInput);
            sudoko[1, 2] = 13;
            Console.WriteLine(sudoko[1,2]);
            //Console.WriteLine(book.GetNumber("ali"));
        }
    }
}