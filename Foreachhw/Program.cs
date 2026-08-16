namespace ForeachExample
{
    class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main()
        {
            Person[] people =
            {
                new Person { Age = 18 },
                new Person { Age = 20 },
                new Person { Age = 25 }
            };

            foreach (Person person in people)
            {
                person.Age++;
            }

            foreach (Person person in people)
            {
                Console.WriteLine(person.Age);
            }
        }
    }
}
//person.Age = 100;              // 可以：修改对象内部内容
// person = new Person();         // 不可以：修改 foreach 变量本身

//foreach (Person person in people)
// {
//     person = new Person { Age = 100 }; // 编译错误
// }

//person（只读引用） ──→ Person 对象（不能修改）
// └── Age（可以修改）