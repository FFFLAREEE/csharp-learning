namespace homework2
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 8, 3, 6, 1, 9, 2, 5 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}