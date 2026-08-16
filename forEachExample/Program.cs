namespace forEachExample
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var item in arr1)//foreach 是一条可执行语句，不能直接写在类 Program 里面，必须放进一个方法中，例如 Main()
            {
                Console.WriteLine(item);
            }
            List <int> list =new(){1,2,3,4,5,6,7,8,9};
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }// foreach 是一种只读遍历 
    }
}