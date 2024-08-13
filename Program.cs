namespace SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of Even Numbers in Array");
            Console.WriteLine("Enter the Element Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[n];
            Console.WriteLine("Enter the Elements in an Array");
            for (int i = 0; i < n; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach (int i in number)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of the Even Numbers in Array: " + sum);
            Console.ReadKey();
        }
    }
}
