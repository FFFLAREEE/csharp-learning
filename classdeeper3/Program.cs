namespace  classdeeper3
{
    class Student
    {
        public Student(string name)// ctor 然后tab 自动出来一个没有参数的构造函数
        {
           
            Name= name;

        }

        private int _age;
        public string Name{get;init ;}// init 和set 的区别在 
        //init 可以在构造函数中赋值，也可以在对象初始化器中赋值；对象初始化完成以后，不能再次赋值
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
            Student tom = new Student("Tom")
            {
                Age = 1,
                Name = "123"//对象初始化语句执行顺序是在构造函数之后的
            };
           
            tom.IntroduceMyself();
        }
    }
}