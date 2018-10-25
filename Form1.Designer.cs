namespace ime
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
            this.txt = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(153, 49);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(113, 21);
            this.txt.TabIndex = 1;
            this.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt.DoubleClick += new System.EventHandler(this.txt_DoubleClick);
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl.Location = new System.Drawing.Point(12, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(250, 24);
            this.lbl.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 92);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(254, 28);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(10, 49);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(125, 24);
            this.lblTip.TabIndex = 4;
            this.lblTip.Text = "确保文本框打开输入法\r\n后双击文本框";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTip.Click += new System.EventHandler(this.lblTip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblTip;
    }
}

