namespace FizzBuzzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var limit = 99;

            var fizzBuzzService = new FizzBuzzService();

            var result = fizzBuzzService.GetFizzBuzzResult(limit);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
