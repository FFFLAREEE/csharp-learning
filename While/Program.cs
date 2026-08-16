namespace While;
class Program
{
    static void Main()
    {
        while (true)//把读取用户输入的东西放进死循环是很常见的做法
        // for (; ; ) this is also a infinite loop
        //do{Console.WriteLine("1111")}while(false);  尽管是false 但是括号里的内容也会被执行一次
        {
            Console.WriteLine("pls input,press q to exit");
            string input =Console.ReadLine();
            if (input == "q")
            {
                Console.WriteLine("Break");
                break;
            }
            else if (input == "c")
            {
                continue;//不管后面还有什么 continue就直接跳到新的循环
                //continue and break can be used in any loop, not only for-while loop
            }
            Console.WriteLine("Your input is:"+input);
        }
    }
}
//while主要用于有明确终止条件的循环