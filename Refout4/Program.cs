namespace refout4
{//方法的重载：方法的名称相同但是签名不同
    //参与重载判断的3个因素：参数类型，参数数量，参数顺序
    //这三个合起来也就叫方法签名
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static float Add(float a, float b)
        {
            return a + b;
        }
        static float Add(float a, int b)
        {
            return a + b;
        }
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main()
        {
            int a =Add (1,2,3);
            int b =Add(1,2);
            float f =Add(1.0f,2.0f);
            float f2 =Add(1.0f,2);
        }
    }
}