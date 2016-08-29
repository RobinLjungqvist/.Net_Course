using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture1Exercise1.logic
{
    public enum Operator
    {
        Addition,
        Subtract,
        Multiply,
        Divide
    }
    public class Calculator
    {
        public string firstNumber { get; set; }
        public string secondNumber { get; set; }

        public Operator Operator { get; set; }

        public int Calculate() {

            int first = int.Parse(firstNumber);
            int second = int.Parse(secondNumber);

            switch (Operator)
            {
                case Operator.Addition:
                    return Add(first, second);
                case Operator.Subtract:
                    return Subtract(first, second);
                case Operator.Multiply:
                    return Multiply(first, second);
                case Operator.Divide:
                    if(first != 0 && second != 0)
                    {
                        return Divide(first, second);
                    }
                    else
                    {
                        return 0;
                    }

            }
            return 0;

        }


        private int Add(int first, int second)
        {
            var result = first + second;
            return result;
        }
        private int Subtract(int first, int second)
        {
            var result = first - second;
            return result;
        }
        private int Multiply(int first, int second)
        {
            var result = first * second;
            return result;
        }
        private int Divide(int first, int second)
        {
            var result = first / second;
            return result;
        }


    }
}