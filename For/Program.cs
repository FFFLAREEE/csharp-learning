namespace Forwhile;
class Program
{
    static void Main()
    {
        int count = 0;
        for (int i = 0; i < 10; i++)//执行完{}里的内容再执行i++
        {
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(count++);
            }
        }
    }
}
//for主要用于有明确终止次数饿循环