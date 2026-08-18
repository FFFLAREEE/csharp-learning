using System.Xml;
// 可以 人继承自哺乳动物 哺乳动物继承自动物 但是不可以人继承自动物与哺乳动物
namespace Inheritance
{
    class Animal
    {
        public int Age{get;set;}
        public string Name{get;set;}

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public Animal(string name)
        {
            Name = name;
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name)// 传递给父类
        {
            
        }
        public void Speak()
        {
            Console.WriteLine("Meow...");
        }
    }
    
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            base.Age = 10;

        }
        public void Speak()
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
//sealed class：禁止其他类继承
// sealed class Cat
// {
// }
// 
// 这表示 Cat 已经是继承链的终点，不允许再定义它的子类：


//sealed 不能随便添加到任何普通方法上。
// 
// 它通常与 override 一起使用：
// 
// sealed override
// 
// 来看一个三层继承关系：
// 
// class Animal
// {
//     public virtual void Speak()
//     {
//         Console.WriteLine("Animal sound");
//     }
// }
// 
// virtual 表示子类可以重写这个方法。
// 
// 然后：
// 
// class Cat : Animal
// {
//     public sealed override void Speak()
//     {
//         Console.WriteLine("Meow");
//     }
// }
// 
// 这里：
// 
// override：Cat 重写了 Animal.Speak()
// sealed：从 Cat 开始，禁止后续子类再次重写
// 
// 如果再创建子类：
// 
// class BritishShorthair : Cat
// {
//     public override void Speak()
//     {
//         Console.WriteLine("British Shorthair sound");
//     }
// }
// 
// 就会报错，因为 Cat.Speak() 已经被 sealed 封住了。


//父类和子类引用
// Animal animal = new Cat(); // 可以
// Cat cat = new Animal();    // 不可以