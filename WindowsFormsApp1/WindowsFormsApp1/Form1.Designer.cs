namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbn_Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_RefreshX = new System.Windows.Forms.TextBox();
            this.tbx_SelectX = new System.Windows.Forms.TextBox();
            this.tbx_ExaminX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_RefreshY = new System.Windows.Forms.TextBox();
            this.tbx_SelectY = new System.Windows.Forms.TextBox();
            this.tbx_ExaminY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbn_Select = new System.Windows.Forms.Button();
            this.tbn_examin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbn_Refresh
            // 
            this.tbn_Refresh.Location = new System.Drawing.Point(407, 94);
            this.tbn_Refresh.Name = "tbn_Refresh";
            this.tbn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.tbn_Refresh.TabIndex = 1;
            this.tbn_Refresh.Text = "刷新";
            this.tbn_Refresh.UseVisualStyleBackColor = true;
            this.tbn_Refresh.Click += new System.EventHandler(this.Tbn_Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "刷新：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "全选：";
            // 
            // tbx_RefreshX
            // 
            this.tbx_RefreshX.Location = new System.Drawing.Point(128, 94);
            this.tbx_RefreshX.Name = "tbx_RefreshX";
            this.tbx_RefreshX.Size = new System.Drawing.Size(100, 21);
            this.tbx_RefreshX.TabIndex = 4;
            // 
            // tbx_SelectX
            // 
            this.tbx_SelectX.Location = new System.Drawing.Point(128, 158);
            this.tbx_SelectX.Name = "tbx_SelectX";
            this.tbx_SelectX.Size = new System.Drawing.Size(100, 21);
            this.tbx_SelectX.TabIndex = 5;
            // 
            // tbx_ExaminX
            // 
            this.tbx_ExaminX.Location = new System.Drawing.Point(128, 215);
            this.tbx_ExaminX.Name = "tbx_ExaminX";
            this.tbx_ExaminX.Size = new System.Drawing.Size(100, 21);
            this.tbx_ExaminX.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "审核：";
            // 
            // tbx_RefreshY
            // 
            this.tbx_RefreshY.Location = new System.Drawing.Point(266, 94);
            this.tbx_RefreshY.Name = "tbx_RefreshY";
            this.tbx_RefreshY.Size = new System.Drawing.Size(100, 21);
            this.tbx_RefreshY.TabIndex = 8;
            // 
            // tbx_SelectY
            // 
            this.tbx_SelectY.Location = new System.Drawing.Point(266, 158);
            this.tbx_SelectY.Name = "tbx_SelectY";
            this.tbx_SelectY.Size = new System.Drawing.Size(100, 21);
            this.tbx_SelectY.TabIndex = 9;
            // 
            // tbx_ExaminY
            // 
            this.tbx_ExaminY.Location = new System.Drawing.Point(266, 215);
            this.tbx_ExaminY.Name = "tbx_ExaminY";
            this.tbx_ExaminY.Size = new System.Drawing.Size(100, 21);
            this.tbx_ExaminY.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // tbn_Select
            // 
            this.tbn_Select.Location = new System.Drawing.Point(407, 159);
            this.tbn_Select.Name = "tbn_Select";
            this.tbn_Select.Size = new System.Drawing.Size(75, 23);
            this.tbn_Select.TabIndex = 12;
            this.tbn_Select.Text = "全选";
            this.tbn_Select.UseVisualStyleBackColor = true;
            this.tbn_Select.Click += new System.EventHandler(this.Tbn_Select_Click);
            // 
            // tbn_examin
            // 
            this.tbn_examin.Location = new System.Drawing.Point(407, 213);
            this.tbn_examin.Name = "tbn_examin";
            this.tbn_examin.Size = new System.Drawing.Size(75, 23);
            this.tbn_examin.TabIndex = 13;
            this.tbn_examin.Text = "审核";
            this.tbn_examin.UseVisualStyleBackColor = true;
            this.tbn_examin.Click += new System.EventHandler(this.Tbn_examin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "使用说明：";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(137, 301);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(321, 91);
            this.label5.TabIndex = 15;
            this.label5.Text = "先将鼠标放到相应位置，再按相应的键获取鼠标位置，再按开始按钮开始审信";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(128, 392);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(492, 91);
            this.label6.TabIndex = 17;
            this.label6.Text = "刷新：1 全选：2   审核：3  （非小键盘数字键）";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "键位说明：";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(407, 45);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 18;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(567, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 97);
            this.textBox1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbn_examin);
            this.Controls.Add(this.tbn_Select);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_ExaminY);
            this.Controls.Add(this.tbx_SelectY);
            this.Controls.Add(this.tbx_RefreshY);
            this.Controls.Add(this.tbx_ExaminX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_SelectX);
            this.Controls.Add(this.tbx_RefreshX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbn_Refresh);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbn_Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_RefreshX;
        private System.Windows.Forms.TextBox tbx_SelectX;
        private System.Windows.Forms.TextBox tbx_ExaminX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_RefreshY;
        private System.Windows.Forms.TextBox tbx_SelectY;
        private System.Windows.Forms.TextBox tbx_ExaminY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tbn_Select;
        private System.Windows.Forms.Button tbn_examin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox textBox1;
    }
}

