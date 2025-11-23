using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5Christensen
{
    internal class ComparisonClass
    {
        public double LeftValue { get; set; }
        public double RightValue { get; set; }
        public double CheckValue { get; set; }

        public ComparisonClass()
        {

        }
        public ComparisonClass(double left, double right, double check)
        {
            LeftValue = left;
            RightValue = right;
            CheckValue = check;
        }
        public string GetResultMessage()
        {
            if (CheckValue == LeftValue)
            {
                return "The number equals the lower bound.";
            }

            if (CheckValue == RightValue)
            {
                return "The number equals the upper bound.";
            }

            if (CheckValue < LeftValue)
            {
                return "The number is less than the lower bound.";
            }

            if (CheckValue > RightValue)
            {
                return "The number is greater than the upper bound.";
            }

            return "The number is between the lower and upper bounds.";
        }
    
    }
}
