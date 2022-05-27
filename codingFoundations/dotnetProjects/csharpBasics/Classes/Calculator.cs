using System;
namespace Classes
{
    public class Calculator
    {
        // add
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // subtract
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        // multiply
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // divide
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        // find remainder
        public int Remainder(int num1, int num2)
        {
            // * MODULUS "%" CHECKS HOW MANY TIMES SECOND NUMBER WILL GO INTO FIRST NUMBER, 
            // * AND RETURN THE REMAINDER
            int remainder = num1 % num2;

            return remainder;
        }

        // ! STATIC METHOD EXAMPLE
        // "static" keyword comes AFTER "access modifier" and BEFORE "return type"
        public static int GetRandomNum(int maxVal)
        {
            Random rand = new Random();

            // should return an "int" between the range of 0 and whatever int specified for "maxVal"
            return rand.Next(0, maxVal);
        }
    }
}