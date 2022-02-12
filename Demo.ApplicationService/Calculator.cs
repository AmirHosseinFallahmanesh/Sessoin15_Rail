using System;

namespace Demo.ApplicationService
{
    public class Calculator
    {

        public int Sum(int number1,int number2)
        {

            return number1+number2;
        }


        public double Divide(double number1,double number2)
        {
            if (number2==0)
            {
                throw new DivideByZeroException();
            }
            return number1 / number2;
        }
    }
}
