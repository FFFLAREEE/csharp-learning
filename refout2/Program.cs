namespace refout2
{
    class Program
    {
        static int GetSum(params int[] numbers)
        //参数数组必须放在参数列表的最后 比如 static int GetSum(params int[] numbers，int b) 不行
        //static int GetSum(int b,params int[] numbers) 行
        {
            int result = 0;

            foreach (int number in numbers)
            {
                result += number;
            }

            return result;
        }

        static void Main()
        {
            Console.WriteLine(GetSum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        }
    }
}