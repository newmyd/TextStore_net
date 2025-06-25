
namespace TextStore
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
            this.upload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.pswdU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileId = new System.Windows.Forms.TextBox();
            this.pswdD = new System.Windows.Forms.TextBox();
            this.download = new System.Windows.Forms.Button();
            this.resU = new System.Windows.Forms.TextBox();
            this.resD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(106, 142);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 23);
            this.upload.TabIndex = 1;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PassWord";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(106, 16);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(145, 21);
            this.txt.TabIndex = 3;
            // 
            // pswdU
            // 
            this.pswdU.Location = new System.Drawing.Point(106, 63);
            this.pswdU.Name = "pswdU";
            this.pswdU.Size = new System.Drawing.Size(145, 21);
            this.pswdU.TabIndex = 4;
            this.pswdU.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "PassWord";
            // 
            // fileId
            // 
            this.fileId.Location = new System.Drawing.Point(106, 185);
            this.fileId.Name = "fileId";
            this.fileId.Size = new System.Drawing.Size(145, 21);
            this.fileId.TabIndex = 7;
            // 
            // pswdD
            // 
            this.pswdD.Location = new System.Drawing.Point(106, 229);
            this.pswdD.Name = "pswdD";
            this.pswdD.Size = new System.Drawing.Size(145, 21);
            this.pswdD.TabIndex = 8;
            this.pswdD.UseSystemPasswordChar = true;
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(106, 305);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(75, 23);
            this.download.TabIndex = 9;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // resU
            // 
            this.resU.Location = new System.Drawing.Point(67, 101);
            this.resU.Name = "resU";
            this.resU.Size = new System.Drawing.Size(139, 21);
            this.resU.TabIndex = 12;
            this.resU.Text = "Result";
            this.resU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resD
            // 
            this.resD.Location = new System.Drawing.Point(67, 266);
            this.resD.Name = "resD";
            this.resD.Size = new System.Drawing.Size(139, 21);
            this.resD.TabIndex = 13;
            this.resD.Text = "Result";
            this.resD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 355);
            this.Controls.Add(this.resD);
            this.Controls.Add(this.resU);
            this.Controls.Add(this.download);
            this.Controls.Add(this.pswdD);
            this.Controls.Add(this.fileId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pswdU);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TextStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox pswdU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileId;
        private System.Windows.Forms.TextBox pswdD;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.TextBox resU;
        private System.Windows.Forms.TextBox resD;
    }
}

