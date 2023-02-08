using System;
using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz //implements the IFizzBuzz interface
    {
        public string FizzBuzzifyAnInt(int input)
        {
            string output = "";
            if (input % 3 == 0 && input % 5 == 0) //check to see if the input given is a multiple of 3 and 5
            {
                output = "FizzBuzz";
            }
            else if (input % 3 == 0) //check to see if the input given is a multiple of 3
            {
                output = "Fizz";
            }
            else if (input % 5 == 0) //check to see if the input given is a multiple of 5
            {
                output = "Buzz";
            }
            else //if it is none of the above it will default a string of the int input 
            {
                output = input.ToString();
            }
            return output; //returns the string output
        }

        public string DemoMethod() //I added this back to remove error
        {
            return ("Hello World");
        }
    }
}
