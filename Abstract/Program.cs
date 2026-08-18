namespace Abstract
{
    abstract class Animal//抽象类存在的意义就是继承用的 不允许创造实例
        
    {
        public int Age{get;set;}
        public string Name{get;set;}

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public abstract void Speak();//如果子类没有继承这个method就会报错

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