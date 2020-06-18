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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_RefreshX = new System.Windows.Forms.TextBox();
            this.tbx_ExaminX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_RefreshY = new System.Windows.Forms.TextBox();
            this.tbx_ExaminY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.cbbSpanTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "刷新：";
            // 
            // tbx_RefreshX
            // 
            this.tbx_RefreshX.Enabled = false;
            this.tbx_RefreshX.Location = new System.Drawing.Point(128, 94);
            this.tbx_RefreshX.Name = "tbx_RefreshX";
            this.tbx_RefreshX.Size = new System.Drawing.Size(121, 21);
            this.tbx_RefreshX.TabIndex = 4;
            // 
            // tbx_ExaminX
            // 
            this.tbx_ExaminX.Enabled = false;
            this.tbx_ExaminX.Location = new System.Drawing.Point(128, 168);
            this.tbx_ExaminX.Name = "tbx_ExaminX";
            this.tbx_ExaminX.Size = new System.Drawing.Size(121, 21);
            this.tbx_ExaminX.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "审核：";
            // 
            // tbx_RefreshY
            // 
            this.tbx_RefreshY.Enabled = false;
            this.tbx_RefreshY.Location = new System.Drawing.Point(275, 94);
            this.tbx_RefreshY.Name = "tbx_RefreshY";
            this.tbx_RefreshY.Size = new System.Drawing.Size(109, 21);
            this.tbx_RefreshY.TabIndex = 8;
            // 
            // tbx_ExaminY
            // 
            this.tbx_ExaminY.Enabled = false;
            this.tbx_ExaminY.Location = new System.Drawing.Point(275, 168);
            this.tbx_ExaminY.Name = "tbx_ExaminY";
            this.tbx_ExaminY.Size = new System.Drawing.Size(109, 21);
            this.tbx_ExaminY.TabIndex = 10;
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
            this.label5.Location = new System.Drawing.Point(137, 300);
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
            this.label6.Location = new System.Drawing.Point(128, 389);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(492, 91);
            this.label6.TabIndex = 17;
            this.label6.Text = "R：刷新      S：审核";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.btn_start.Location = new System.Drawing.Point(471, 92);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 18;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // cbbSpanTime
            // 
            this.cbbSpanTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSpanTime.FormattingEnabled = true;
            this.cbbSpanTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10"});
            this.cbbSpanTime.Location = new System.Drawing.Point(128, 31);
            this.cbbSpanTime.Name = "cbbSpanTime";
            this.cbbSpanTime.Size = new System.Drawing.Size(121, 20);
            this.cbbSpanTime.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "间隔时间：";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(471, 168);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "暂停";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbSpanTime);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_ExaminY);
            this.Controls.Add(this.tbx_RefreshY);
            this.Controls.Add(this.tbx_ExaminX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_RefreshX);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_RefreshX;
        private System.Windows.Forms.TextBox tbx_ExaminX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_RefreshY;
        private System.Windows.Forms.TextBox tbx_ExaminY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ComboBox cbbSpanTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStop;
    }
}

