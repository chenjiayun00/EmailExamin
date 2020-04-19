using System;
using System.Timers;

namespace TimerExample1
{
    class Program
    {

        //static void Main(string[] args)
        //{
        //    System.Timers.Timer timer = new System.Timers.Timer();
        //    timer.Enabled = true;
        //    timer.Interval = 60000;//执行间隔时间,单位为毫秒;此时时间间隔为1分钟  
        //    timer.Start();
        //    timer.Elapsed += new System.Timers.ElapsedEventHandler(test);

        //    Console.ReadKey();
        //}

        //private static void test(object source, ElapsedEventArgs e)
        //{

        //    if (DateTime.Now.Hour == 10 && DateTime.Now.Minute == 30)  //如果当前时间是10点30分
        //        Console.WriteLine("OK, event fired at: " + DateTime.Now.ToString());

        //}
    }
}
    //复制代码
    //上述代码，是在指定的每天10：30分执行事件。这里需要注意的是，由于是指定到特定分钟执行事件，因此，timer.Inverval的时间间隔最长不得超过1分钟，否则，长于1分钟的时间间隔有可能会错过10：30分这个时间节点，从而导致无法触发该事件。

 