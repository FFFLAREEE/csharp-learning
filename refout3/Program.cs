namespace  refout3
{
    class Program
    {
        static void Mylog(string msg, int level=0)
        //一旦第一个默认参数出现了 后面的所有参数都应该是默认参数
        {
            Console.WriteLine($"[{level}] {msg}");
        }

        static void Main()
        {
            Mylog("Hello");
        }
    }
}