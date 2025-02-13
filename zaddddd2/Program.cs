namespace zaddddd2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static bool isPowerOfTwo(int n)
            {
                if (n <= 0)
                    return false;
                if (n == 1)
                    return true;
                if(n % 2 !=0)
                    return false;
                return isPowerOfTwo(n / 2);
            }
            Console.Write("Enter number: ");
            int number = int .Parse(Console.ReadLine());
            Console.WriteLine("Result: " + isPowerOfTwo(number));
            Console.ReadKey();
        }
    }
}
