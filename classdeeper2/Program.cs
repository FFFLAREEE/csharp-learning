
namespace  classdeeper2
{
    class Student
    {
        public Student(int age,string name)// ctor 然后tab 自动出来一个没有参数的构造函数
        {
            Age = age;
            Name= name;

        }

        private int _age;
        public string Name{get;init ;}// init 和set 的区别在 init只能在构造的阶段用 初始化成功后再也不能修改相应的属性了
        // private set 就是可以在类内修改 不能在类外修改

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 100)
                {
                    throw new ArgumentOutOfRangeException("age", "age must be less than 100");
                }
                _age = value;
            }
        }
        

        public void IntroduceMyself()
        {
            Console.WriteLine($"My name is {Name},and I am {Age} years old");
        }
    }
    class Program
    {
        static void Main()
        {
            Student stu1 =new Student(17,"Jerry");
           
            stu1.IntroduceMyself();
        }
    }
}