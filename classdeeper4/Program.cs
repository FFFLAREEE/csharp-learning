namespace  classdeeper4
{
    class Circle
    {
        public const double pi=3.14;
        private readonly double r;
        //const 是编译时就确定的常量；readonly 可以在创建对象时，通过构造函数确定。
        //public Circle(double r)
        // {
        //     this.r = r;  当前对象的 r 字段 = 传进来的 r 参数
        // }
        public Circle(double r)
        {
            Radius = r;
        }
        public double Radius{get;set;}
        public double Area{get{return Radius*Radius*Math.PI;}}//只读 没有set 访问器
    }
    class Program
    {
        static void Main()
        {
            Circle c = new(100);
            Console.WriteLine(c.Area);
        }
    }
}
//最重要的一句话：
// 
// 没有 static 的成员属于每个对象；有 static 的成员属于类本身，并被所有对象共享。
// 
// 例如：
// 
// class Cat
// {
//     public string Name { get; set; }
// 
//     public static int Count { get; set; }
// }
// 
// 其中：
// 
// Name 属于每个具体的猫
// Count 属于整个 Cat 类




//为什么 Main() 是 static？
// 
// 你经常写：
// 
// class Program
// {
//     static void Main()
//     {
//     }
// }
// 
// 程序开始运行时，还没有创建 Program 对象。
// 
// .NET 需要直接通过 Program 类找到并执行程序入口，因此 Main() 是静态方法：
// 
// Program.Main()
// 
// 如果 Main() 不是 static，就需要先创建对象：
// 
// Program program = new Program();
// program.Main();
// 
// 但程序还没有进入 Main()，又没有地方负责创建这个对象，于是产生了“要先运行才能创建、要先创建才能运行”的问题。
// 
// 所以程序入口通常是静态的。




//最后用一句话判断是否加 static：
// 
// 这份数据或这个操作，需要依赖某一个具体对象吗？
// 
// 需要知道“是哪只猫”：不加 static
// 不属于某只猫，而属于整个类型：加 static