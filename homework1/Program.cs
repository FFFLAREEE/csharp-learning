namespace homework1
{
    class Program
    {
        static void Main()
        {
            
            for (int i = 1; i < 10; i++) 
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write($"{j} * {i} = {j * i,-2}   ");
                }
                Console.WriteLine();
            }
        }
    }
}
    