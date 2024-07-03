using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5_Demo
{
    internal struct Point
    {
        public int x;
        public int y;
        //Constructor : is a special Method
        //same name of its Calss 
        //no return
        //Ptarameterless Constructor
        public Point()
        {
            x = y = 0;
        }
        public Point(int _x, int _y)
        {
            //this.x = x;
            //this.y = y;
            x = _x;
            y = _y;
        }
    }
}
