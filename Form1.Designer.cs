namespace CultureApp
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
            this.btnCurrent = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFindById = new System.Windows.Forms.Button();
            this.txtLcid = new System.Windows.Forms.TextBox();
            this.btnFindByName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCurrent
            // 
            this.btnCurrent.Location = new System.Drawing.Point(1, 12);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(106, 23);
            this.btnCurrent.TabIndex = 0;
            this.btnCurrent.Text = "获取当前语言";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(1, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(595, 337);
            this.textBox1.TabIndex = 1;
            // 
            // btnFindById
            // 
            this.btnFindById.Location = new System.Drawing.Point(141, 12);
            this.btnFindById.Name = "btnFindById";
            this.btnFindById.Size = new System.Drawing.Size(117, 23);
            this.btnFindById.TabIndex = 2;
            this.btnFindById.Text = "根据LCID获取语言信息";
            this.btnFindById.UseVisualStyleBackColor = true;
            this.btnFindById.Click += new System.EventHandler(this.btnFindById_Click);
            // 
            // txtLcid
            // 
            this.txtLcid.Location = new System.Drawing.Point(387, 13);
            this.txtLcid.Name = "txtLcid";
            this.txtLcid.Size = new System.Drawing.Size(100, 21);
            this.txtLcid.TabIndex = 3;
            this.txtLcid.Text = "zh-CHT";
            // 
            // btnFindByName
            // 
            this.btnFindByName.Location = new System.Drawing.Point(264, 12);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(117, 23);
            this.btnFindByName.TabIndex = 4;
            this.btnFindByName.Text = "根据Name获取语言信息";
            this.btnFindByName.UseVisualStyleBackColor = true;
            this.btnFindByName.Click += new System.EventHandler(this.btnFindByName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 382);
            this.Controls.Add(this.btnFindByName);
            this.Controls.Add(this.txtLcid);
            this.Controls.Add(this.btnFindById);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCurrent);
            this.Name = "Form1";
            this.Text = "系统语言检测";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFindById;
        private System.Windows.Forms.TextBox txtLcid;
        private System.Windows.Forms.Button btnFindByName;
    }
}

