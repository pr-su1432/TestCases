using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    public class MaxValue<T> where T : IComparable
    {
        public int maximumofintegers(int firstvalue, int secondvalue, int thirdvale)
        {
            if(firstvalue>secondvalue && firstvalue>thirdvale)
            {
                return firstvalue;
                
            }
            else if(secondvalue > firstvalue && secondvalue > thirdvale)
            {
                return secondvalue;
         
            }
            else
            {
                return thirdvale;
            }
        
        }
        public int maximumofSecintegers(int firstvalue, int secondvalue, int thirdvale)
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

       

        public int maximumofThirdintegers(int firstvalue, int secondvalue, int thirdvale)
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

        

        public string MaximumofStringValue(string firststring, string secondstring, string thirdstring)
        {
            if (firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0)    
            {
                return firststring;

            }
            else if (secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0)
            {
                return secondstring;

            }
            else
            {
                return thirdstring;
            }

        }

        public string MaximumofFirstStringValue(string firststring, string secondstring, string thirdstring)
        {
            if (firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0)
            {
                return firststring;

            }
            else if (secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0)
            {
                return secondstring;

            }
            else
            {
                return thirdstring;
            }

        }
        public string MaximumofSecStringValue(string firststring, string secondstring, string thirdstring)
        {
            if (firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0)
            {
                return firststring;

            }
            else if (secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0)
            {
                return secondstring;

            }
            else
            {
                return thirdstring;
            }

        }
    }
}
