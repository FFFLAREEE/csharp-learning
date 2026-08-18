namespace Method
{
    class Animal
    //被重写的基方法必须是 virtual/abstract/override
    //方法签名 返回值 可访问性必须相同
    //属性也是类似
    {
        public int Age{get;set;}
        public string Name{get;set;}

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void Speak()//virtual:会在运行时根据实例实际的类型去调用相应的方法
        //virtual允许我们在子类里覆盖/重写
        //在子类用override标记 否则不加override就还是父类的
        {
            Console.WriteLine("speaking...");
        }

        
    }

    class Cat : Animal
    {
        public Cat(string name) 
        {
            
        }
        public override void Speak()
        {
            Console.WriteLine("Meow...");
        }
    }
    
    class Dog : Animal
    {
        public Dog(string name) 
        {
            base.Age = 10;

        }
        public override void Speak()
        {
            Console.WriteLine("Woof...");
        }
    }
    class Program
    {
        static void Main()
        {
            Cat cat = new Cat("Cat");
            Dog dog = new Dog("Dog");
            Animal cat2 = new Cat("Cat2");
            Animal dog3 = new Dog("Dog3");
                
        }
    }
}