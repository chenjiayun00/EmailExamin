using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        public static extern void keybd_event(Keys bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int x = MousePosition.X;
            //int y = MousePosition.Y;
            //tbx_RefreshX.Text = x.ToString() + "," + y.ToString();
            //this.KeyUp += Form1_KeyUp;
            this.KeyUp += new KeyEventHandler(this.Form1_KeyUp);
        }

       
        /// <summary>
        /// 按键按下事件
        /// 1：获取刷新位置
        /// 2：获取全选位置
        /// 3：获取审核位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string MousePoint = "";
                MousePoint = GetMousePoint();
                if (e.KeyCode.ToString() == "D1")
                {
                    tbx_RefreshX.Text = MousePoint.Split(',')[0];
                    tbx_RefreshY.Text = MousePoint.Split(',')[1];
                }

                if (e.KeyCode.ToString() == "D2")
                {
                    tbx_SelectX.Text = MousePoint.Split(',')[0];
                    tbx_SelectY.Text = MousePoint.Split(',')[1];
                }

                if (e.KeyCode.ToString() == "D3")
                {
                    tbx_ExaminX.Text = MousePoint.Split(',')[0];
                    tbx_ExaminY.Text = MousePoint.Split(',')[1];
                }
            }
            catch(Exception E)
            {
                MessageBox.Show("获取鼠标位置信息失败！" + E.Message);
                return;

            }
            
        }
      
        public string  GetMousePoint()
        {
            int x = MousePosition.X;
            int y = MousePosition.Y;
            string p = x.ToString() + "," + y.ToString();
            return p;
            //tbx_Refresh.Text = x.ToString() + "," + y.ToString();
        }

        private void Button1_Click_1(object sender, EventArgs e)//线程实验
        {
            ThreadDemo.Threa();
        }

        private void Tbn_Select_Click(object sender, EventArgs e)
        {
            textBox1.Text = "SALFIJSOTALFJLAGA\na;gjdasgadjlg";
            //textBox1.Focus();
            SelectALL();
        }

        private void Tbn_examin_Click(object sender, EventArgs e)//读取审核位置坐标，并执行鼠标单击事件
        {
            try
            {
                int x = int.Parse(tbx_ExaminX.Text.Trim());
                int y = int.Parse(tbx_ExaminX.Text.Trim());

                Class1.AutoClick(x, y);
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
                return;
            }
            
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Action));
            thread.IsBackground=true;
            thread.Start();
        }
        public void Action()
        {
            while(true)
            {
                Refreshed();//刷新
                Thread.Sleep(5000);

                SelectALL();
                Thread.Sleep(2000);

                Examin();
                Thread.Sleep(5000);


            }
        }
        public void Refreshed()//刷新
        {
            try
            {
                int x = int.Parse(tbx_RefreshX.Text.ToString());
                int y = int.Parse(tbx_RefreshY.Text.ToString());
                Class1.AutoClick(x, y);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }
        public void SelectALL()//全选
        {
            //SendKeys.SendWait("^{A}");
            keybd_event(Keys.ControlKey, 0, 0, 0);
            keybd_event(Keys.A, 0, 0, 0);
            keybd_event(Keys.ControlKey, 0, 2, 0);

        }

        public void Examin()//审核
        {
            try
            {
                int x = int.Parse(tbx_ExaminX.Text.ToString());
                int y = int.Parse(tbx_ExaminY.Text.ToString());
                Class1.AutoClick(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }

        private void Tbn_Refresh_Click(object sender, EventArgs e)
        {
            Refreshed();
           
        }
    }

}

