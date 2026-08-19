using System.Collections.Generic;

namespace Abstract2
{
    interface Ipay
    {
        void Pay(decimal money);
    }

    class AliPay : Ipay
    {
        public void Pay(decimal money)
        {
            Console.WriteLine($"use AliPay {money}");
        }
    }
    
    class Wechat : Ipay
    {
        public void Pay(decimal money)
        {
            Console.WriteLine($"use Wechat {money}");
        }
    }
    class Program
    {
        static void BuyCar(Ipay pay)
        {
            pay.Pay(10000000);
        }
        static void Main()
        {
            Ipay pay = new AliPay();
            BuyCar(pay);
        }
    }
}

//在新增需求的时候 尽量不要改原有的代码：也就是没改BuyCar 只需要增加新的接口就可以