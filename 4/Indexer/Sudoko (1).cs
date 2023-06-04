using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Property
{
    public class Sudoko
    {
        private int[,] _matrix;
        public Sudoko(int[,] matrix)
        {
            this._matrix = matrix;            
        }
        public int this[int row , int col]
        {
            get
            {
                return _matrix[row , col];
            }
            set
            {
                _matrix[row , col] = value;
            }
        }
    }
}
