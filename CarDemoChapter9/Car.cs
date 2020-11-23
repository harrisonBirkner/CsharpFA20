using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemoChapter9
{
    public class Car : IComparable
    {
        string Model { get; set; }
        double MPG { get; set; }

        public Car(string model, double mpg)
        {
            Model = model;
            MPG = mpg;
        }

        public Car(string model)
        {
            Model = model;
            MPG = 20;
        }

        public static Car operator ++(Car c)
        {
            ++c.MPG;
            return c;
        }

        int IComparable.CompareTo(object o)
        {
            int returnVal;
            Car temp = (Car)o;
            if (this.MPG > temp.MPG)
                returnVal = 1;
            else
               if (this.MPG < temp.MPG)
                returnVal = -1;
            else
                returnVal = 0;
            return returnVal;
        }
    }
}
