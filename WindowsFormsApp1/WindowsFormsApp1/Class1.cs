using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowsFormsApp1
{
    public class Class1
    {
        [DllImport("User32")]
        public extern static void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);
        [DllImport("User32")]
        public extern static void SetCursorPos(int x, int y);
        [DllImport("User32")]
        public extern static bool GetCursorPos(out POINT p);
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }
        public enum MouseEventFlags
        {
            Move = 0x0001, //移动鼠标
            LeftDown = 0x0002,//模拟鼠标左键按下
            LeftUp = 0x0004,//模拟鼠标左键抬起
            RightDown = 0x0008,//鼠标右键按下
            RightUp = 0x0010,//鼠标右键抬起
            MiddleDown = 0x0020,//鼠标中键按下 
            MiddleUp = 0x0040,//中键抬起
            Wheel = 0x0800,
            Absolute = 0x8000//标示是否采用绝对坐标
        }

        public static void AutoClick(int X,int Y)
        {
          
                //设置鼠标的坐标

                SetCursorPos(X, Y);

                //这里模拟的是一个鼠标单击事件
                mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.Absolute), X, Y, 0, IntPtr.Zero);
                mouse_event((int)(MouseEventFlags.LeftUp | MouseEventFlags.Absolute), X, Y, 0, IntPtr.Zero);
                //mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.Absolute), X, Y, 0, IntPtr.Zero);

                //mouse_event((int)(MouseEventFlags.LeftUp | MouseEventFlags.Absolute), X, Y, 0, IntPtr.Zero);
                //mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.Absolute), X, Y, 0, IntPtr.Zero);

        }
    }
}
