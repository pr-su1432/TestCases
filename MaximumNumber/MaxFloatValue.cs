using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    internal class MaxFloatValue<T> where T : IComparable
    {
        public double MaximumofFloatValue(double firstvalue, double secondvalue, double thirdvale)
        {
            if (firstvalue > secondvalue && firstvalue > thirdvale)
            {
                return firstvalue;

            }
            else if (secondvalue > firstvalue && secondvalue > thirdvale)
            {
                return secondvalue;

            }
            else
            {
                return thirdvale;
            }

        }

        

        public double maximumofSecFloatvalue(double firstvalue, double secondvalue, double thirdvale)
        {
            if (firstvalue > secondvalue && firstvalue > thirdvale)
            {
                return firstvalue;

            }
            else if (secondvalue > firstvalue && secondvalue > thirdvale)
            {
                return secondvalue;

            }
            else
            {
                return thirdvale;
            }


        }
        public double maximumofThirdFloatValue(double firstvalue, double secondvalue, double thirdvale)
        {
            if (firstvalue > secondvalue && firstvalue > thirdvale)
            {
                return firstvalue;

            }
            else if (secondvalue > firstvalue && secondvalue > thirdvale)
            {
                return secondvalue;

            }
            else
            {
                return thirdvale;
            }

        }

        
    }
}
