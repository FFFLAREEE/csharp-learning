namespace  refout3
{
    class Program
    {
        static void Mylog(string msg, int level)
        {
            Console.WriteLine($"[{level}] {msg}");
        }

        static void Main()
        {
            Mylog("Hello",0);
        }
    }
}