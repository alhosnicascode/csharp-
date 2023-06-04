using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Property
{
    public class PhoneBook
    {
        string[] Names;
        long[] Numbers;
        int Size;
        public PhoneBook(int _size)
        {
            this.Size = _size;
            Names = new string[_size];
            Numbers = new long[_size];
        }

        public void SetEntry(int index, string Name, long Number)
        {
            Names[index] = Name;
            Numbers[index] = Number;
        }
        public long GetNumber(string Name)
        {
            for (int i = 0; i < Names?.Length; i++)
            {
                if (Names[i] == Name)
                {
                    return Numbers[i];
                }

            }
            return -1;//not Found
        }

        public long this[string Name]
        {
            get{
                for (int i = 0; i < Names?.Length; i++)
                {
                    if (Names[i] == Name)
                    {
                        return Numbers[i];
                    }

                }
                return -1;//not Found

            }
            set
            {
                for (int i = 0; i < Names?.Length; i++)
                {
                    if (Names[i] == Name)
                    {
                         Numbers[i] = value;
                    }

                }

            }
        }

        public string this[int index] {
            get{
                if ( (index >=0) && (index < Size) ){
                    return $"{Names[index]} ::: {Numbers[index]}";
                }
                return "NA";
            }
        }
        public long this[int index , string Name]
        {
            set
            {
                if ((index >= 0) && (index < Size))
                    Names[index] = Name;
                    Numbers[index] = value;

            }
        } 


    }
}
