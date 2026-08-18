namespace  classdeeper
{
    class Student
    {
        private int _age;

        
        //public string _name;
        public string Name { get;  private set; } //private set 防止外部随意的修改
        //private 访问器只能在类内访问

        public int Age// 有了 get set 这两个访问器 我们就可以在外部对这个属性进行读写了
        {
            get
            {
                return _age;
            }
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
            Student stu1 =new Student();
            stu1.Age = 17;
           // stu1._age=10; 不行
            stu1.Name = "Tom";
            stu1.IntroduceMyself();
        }
    }
}