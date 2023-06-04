using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oldfunc();

            Person p1 = new Person("ahmed");
            Console.WriteLine(p1.FirstName, " ", p1.LastName) ;
            
            var properties = TypeDescriptor.GetProperties(p1);

            foreach (PropertyDescriptor property in properties)
            {
                var displayName = property.DisplayName;
                var value = property.GetValue(p1);

                Console.WriteLine($"{displayName}: {value}");
            }


        }
   [Obsolete("this is method is about to be un used please take into Considration" +
            " in the next update you will use" +
            "newFun() with param message ")]
        public static void Oldfunc()
        {
            Console.WriteLine("old Function ");
        }
        public static void newFunc()
        {
            Console.WriteLine("old Function ");
        }
       
        

    }
    //public class Person
    //{
    //    [DisplayName("الاسم الاول")]

    //    public string FirstName { get; set; }

    //    [DisplayName("Last Name")]
    //    public string LastName { get; set; }
    //}
    
    [Serializable]
    public class Users
    {
        // Class members
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
    public class Person
    {
        [Required]
        [DisplayName("Name1")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Name2")]

        public string LastName { get; set; }
        public Person(string FName)
        {
            FirstName = FName;
        }
    }
}