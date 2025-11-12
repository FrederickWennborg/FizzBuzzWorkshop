using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class FizzBuzzService
    {

        public List<string> GetFizzBuzzResult()
        {

            List<string> result = new List<string>();   

            for (int i = 0; i < 99; i++)
            {
                
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add(FizzBuzz(i));
                }

                else if (i % 3 == 0)
                {
                    result.Add(Fizz(i));
                }

                else if (i % 5 == 0)
                {
                    result.Add(Buzz(i));
                }
                else
                {
                    result.Add(Convert.ToString(i));
                }
            }
            return new List<string>();
        }



        public string Fizz(int number)
        {
            return "Fizz";
        }



        public string Buzz(int number)
        {
            return "Buzz";
        }



        public string FizzBuzz(int number) 
        {
            return "FizzBuzz";
        } 



    }
}
