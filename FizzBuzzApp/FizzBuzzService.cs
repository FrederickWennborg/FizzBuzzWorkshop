using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    public class FizzBuzzService
    {

        public List<string> GetFizzBuzzResult(int limit)
        {
            List<string> result = new List<string>();

            for (int i = 1; i < limit; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add(FizzBuzz());
                }

                else if (i % 3 == 0)
                {
                    result.Add(Fizz());
                }

                else if (i % 5 == 0)
                {
                    result.Add(Buzz());
                }
                else
                {
                    result.Add(Convert.ToString(i));
                }
            }
            return result;

        }

        public string Fizz()
        {
            return "Fizz";
        }


        public string Buzz()
        {
            return "Buzz";
        }



        public string FizzBuzz()
        {
            return "FizzBuzz";
        }



    }
}
