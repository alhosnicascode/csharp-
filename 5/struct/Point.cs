using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_01
{
    readonly struct Point
    {
        readonly int x;
        readonly int y;
        //private int z = 1000;
        #region MultiConstrctor
        //public Point()
        //{
        //    x = y = 0;
        //}
        //public Point(int N)
        //{
        //    x = y = N;
        //}
        //public Point(int _y, int _x)
        //{
        //    x = _x;
        //    y = _y;
        //}
        //public override string ToString()
        //{
        //    return $"point x :{x} -- point y :{y}";
        //} 
        #endregion
        public Point(int _x , int _y)
        {
            this.x = _x;
            this.y = _y;    
        }
        public override string ToString()
        {
            return $"{x} {y}";
        }
    }
}
