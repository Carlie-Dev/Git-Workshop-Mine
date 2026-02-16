namespace Git_Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool counting = true;

            while (counting){

                string fizzbuzz_out = "";

                if ((count % 3 == 0) && (count % 5 == 0))
                {
                    fizzbuzz_out = "Fizzbuzz";
                } 
                else if ((count % 3 == 0))
                {
                    fizzbuzz_out = "Fizz";
                }  
                if ((count % 5 == 0))
                {
                    fizzbuzz_out = "Buzz";
                }

                Console.WriteLine($"{count}! {fizzbuzz_out}");
                Thread.Sleep(500);

                count++;
            }
        }
    }
}
