using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class MathUtility
    {
        public T Addnumber<T>(T first, T second) 
        {
            dynamic firstnumber = first;
            dynamic secondnumber = second;  
            return firstnumber + secondnumber;
        }
    }
}
