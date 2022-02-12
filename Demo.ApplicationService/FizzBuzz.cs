using System;

namespace Demo.ApplicationService
{
    public class FizzBuzz
    {

        public string Run(int value)
        {
            string result = string.Empty;

            if (value % 3==0 && value%5==0)
            {
                result = "fizz buzz";
            }
            else if (value%3==0)
            {
                result= "fizz";
            }
            else if (value%5==0)
            {
                result= "buzz";
            }
            else
            {
                result = value.ToString();
            }

           
            return result;
        }


    }
}
