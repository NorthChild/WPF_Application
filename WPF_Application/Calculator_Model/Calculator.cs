using System;

namespace Calculator_Model
{
    public class Calculator
    {

        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public double Add() 
        {
            return Num1 + Num2;
        }
        public double Subtract()
        {
            return Num1 - Num2;
        }
        public double Divide()
        {
            if (Num2 == 0) { throw new ArgumentOutOfRangeException("Cant divide by 0"); }
            return Num1 / Num2;
        }
        public double Multiply()
        {
            return Num1 * Num2;
        }

    }
}
