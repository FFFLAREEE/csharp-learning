namespace homework1
{
    class Program
    {
        static void Main()
        {
            int count = 1;
            for (int i = 1; i < 10; i++) 
            {
                for (int j = i; j < 10; j++)
                {
                    Console.WriteLine(i+"*"+j+"="+i*j);
                }
            }
        }
    }
}
    