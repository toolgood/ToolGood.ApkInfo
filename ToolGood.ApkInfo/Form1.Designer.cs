namespace ToolGood.ApkInfo
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_apkPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pgName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_md5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sha1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_sha256 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_list = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "APK地址：";
            // 
            // tb_apkPath
            // 
            this.tb_apkPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_apkPath.Location = new System.Drawing.Point(85, 12);
            this.tb_apkPath.Name = "tb_apkPath";
            this.tb_apkPath.Size = new System.Drawing.Size(266, 21);
            this.tb_apkPath.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(357, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "包名：";
            // 
            // tb_pgName
            // 
            this.tb_pgName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pgName.Location = new System.Drawing.Point(85, 39);
            this.tb_pgName.Name = "tb_pgName";
            this.tb_pgName.Size = new System.Drawing.Size(314, 21);
            this.tb_pgName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "签名MD5：";
            // 
            // tb_md5
            // 
            this.tb_md5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_md5.Location = new System.Drawing.Point(85, 66);
            this.tb_md5.Name = "tb_md5";
            this.tb_md5.Size = new System.Drawing.Size(314, 21);
            this.tb_md5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "签名Sha1：";
            // 
            // tb_sha1
            // 
            this.tb_sha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_sha1.Location = new System.Drawing.Point(85, 93);
            this.tb_sha1.Name = "tb_sha1";
            this.tb_sha1.Size = new System.Drawing.Size(314, 21);
            this.tb_sha1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "签名Sha256：";
            // 
            // tb_sha256
            // 
            this.tb_sha256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_sha256.Location = new System.Drawing.Point(85, 120);
            this.tb_sha256.Name = "tb_sha256";
            this.tb_sha256.Size = new System.Drawing.Size(314, 21);
            this.tb_sha256.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lb_list);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 200);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详情：";
            // 
            // lb_list
            // 
            this.lb_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_list.FormattingEnabled = true;
            this.lb_list.ItemHeight = 12;
            this.lb_list.Location = new System.Drawing.Point(3, 17);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(384, 180);
            this.lb_list.TabIndex = 0;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_sha256);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_sha1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_md5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_pgName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_apkPath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APK信息察看(支持文件拖拽)";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_apkPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pgName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_md5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sha1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_sha256;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_list;
    }
}

