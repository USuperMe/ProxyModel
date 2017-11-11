using System;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            CCosPlayer c=new CCosPlayer();

            BCosPlayerProxy b=new BCosPlayerProxy(c) ;

            b.GiveWeChat();
            b.GiveFlower();
            b.WatchMovie();
            b.HavingDinner();
        }
    }
}
