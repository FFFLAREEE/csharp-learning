namespace Switch;

class Program
{
    static void Main(string[] args) //一个名叫 args 的字符串数组
    {
        int day = 1;
        switch (day)
        {
            case 1:// case后面必须是常量，且和 day的类型一致
                Console.WriteLine("Monday");
                break;//必须有break
            case 2:
            case 3:
            {
                Console.WriteLine("Tuesday/Wednesday");
                break;
            }
            default:
                Console.WriteLine("Wrong Day");
                break;
        }
    }
}