namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzService = new FizzBuzzService();

            var result = fizzBuzzService.GetFizzBuzzResult();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}
