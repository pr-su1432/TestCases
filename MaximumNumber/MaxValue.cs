using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    public class MaxValue<T> where T : IComparable
    {
        public T[] MaxArray;
        

        public MaxValue(T[] valueArray)
        {
            this.MaxArray = valueArray;
        }

        

        public T[] SortArray(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T CheckMax(T[] maxArray)
        {
            var values = SortArray(maxArray);
            return values[values.Length - 1];

        }

        public T CheckMaximumValue()
        {
            T value = CheckMax(this.MaxArray);
            PrintMax(value);
            return value;
        }

        public void PrintMax(T value)
        {
            Console.WriteLine("Maximum value is ---> " + value);
        }

        
    }
}

