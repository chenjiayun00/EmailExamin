using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// 在开发中经常会遇到线程的例子，如果某个后台操作比较费时间，我们就可以启动一个线程去执行那个费时的操作，同时程序继续执行。在某些情况下可能会出现多个线程的同步协同的问题，下面的例子就展示了在两个线程之间如何协同工作。
///
///这个程序的思路是共同做一件事情（从一个ArrayList中删除元素）,如果执行完成了，两个线程都停止执行。
///作者：周公
/// 时间：2008-5-17
/// 原发地址：http://blog.csdn.net/zhoufoxcn
/// </summary>
/// 
namespace WindowsFormsApp1
{
    public class ThreadDemo
    {
        private Thread threadOne;
        private Thread threadTwo;
        private ArrayList stringList;
        private event EventHandler OnNumberClear;//数据删除完成引发的事件

        public static void  Threa()
        {
            ThreadDemo demo = new ThreadDemo(1000);
            demo.Action();
        }
        public ThreadDemo(int number)
        {
            Random random = new Random(1000000);
            stringList = new ArrayList(number);
            for (int i = 0; i < number; i++)
            {
                stringList.Add(random.Next().ToString());
            }
            threadOne = new Thread(new ThreadStart(Run));//两个线程共同做一件事情
            threadTwo = new Thread(new ThreadStart(Run));//两个线程共同做一件事情
            threadOne.Name = "线程1";
            threadTwo.Name = "线程2";
            OnNumberClear += new EventHandler(ThreadDemo_OnNumberClear);

        }
        /// <summary>
            /// 开始工作
            /// </summary>
        public void Action()
        {
            threadOne.Start();
            threadTwo.Start();
        }
        /// <summary>
            /// 共同做的工作
            /// </summary>
        private void Run()
        {
            string stringValue = null;
            while (true)
            {
                Monitor.Enter(this);//锁定，保持同步
                stringValue = (string)stringList[0];
                Console.WriteLine(Thread.CurrentThread.Name + "删除了" + stringValue);
                stringList.RemoveAt(0);//删除ArrayList中的元素
                if (stringList.Count == 0)
                {
                    OnNumberClear(this, new EventArgs());//引发完成事件
                }
                Monitor.Exit(this);//取消锁定
                Thread.Sleep(5);
            }
        }

        //执行完成之后，停止所有线程
        void ThreadDemo_OnNumberClear(object sender, EventArgs e)
        {
            Console.WriteLine("执行完了，停止了所有线程的执行。");
            threadTwo.Abort();
            threadOne.Abort();

        }
    }
}




