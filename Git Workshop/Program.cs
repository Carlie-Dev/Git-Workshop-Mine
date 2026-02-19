namespace Git_Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true){
                string fizzbuzz_out = "";
                if ((count % 3 == 0) && (count % 5 == 0))
                {
                    fizzbuzz_out = "\x1b[35mFizzbuzz\x1b[39m";
                } else if ((count % 3 == 0))
                {
                    fizzbuzz_out = "\x1b[31mFizz\x1b[39m";
                }  if ((count % 5 == 0))
                {
                    fizzbuzz_out = "\x1b[34mBuzz\x1b[39m";
                }
                Console.WriteLine($"{count}! {fizzbuzz_out}");
                Thread.Sleep(500);
                count++;
            }
        }
    }
}
