namespace CompressionSharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompress = new System.Windows.Forms.TextBox();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.btnUnCompress = new System.Windows.Forms.Button();
            this.txtUnCompress = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkPass = new System.Windows.Forms.CheckBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn file hoặc folder để nén";
            // 
            // txtCompress
            // 
            this.txtCompress.Location = new System.Drawing.Point(32, 66);
            this.txtCompress.Name = "txtCompress";
            this.txtCompress.Size = new System.Drawing.Size(562, 27);
            this.txtCompress.TabIndex = 1;
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(613, 70);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(107, 29);
            this.btnCompress.TabIndex = 2;
            this.btnCompress.Text = "Tạo File Nén";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(497, 108);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(110, 29);
            this.btnChooseFile.TabIndex = 3;
            this.btnChooseFile.Text = "Chọn File ";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(613, 108);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(110, 29);
            this.btnChooseFolder.TabIndex = 4;
            this.btnChooseFolder.Text = "Chọn Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // btnUnCompress
            // 
            this.btnUnCompress.Location = new System.Drawing.Point(616, 190);
            this.btnUnCompress.Name = "btnUnCompress";
            this.btnUnCompress.Size = new System.Drawing.Size(104, 29);
            this.btnUnCompress.TabIndex = 7;
            this.btnUnCompress.Text = "Bung file nén";
            this.btnUnCompress.UseVisualStyleBackColor = true;
            this.btnUnCompress.Click += new System.EventHandler(this.btnUnCompress_Click);
            // 
            // txtUnCompress
            // 
            this.txtUnCompress.Location = new System.Drawing.Point(28, 192);
            this.txtUnCompress.Name = "txtUnCompress";
            this.txtUnCompress.Size = new System.Drawing.Size(562, 27);
            this.txtUnCompress.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(171, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(320, 27);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkPass
            // 
            this.chkPass.AutoSize = true;
            this.chkPass.Location = new System.Drawing.Point(493, 152);
            this.chkPass.Name = "chkPass";
            this.chkPass.Size = new System.Drawing.Size(101, 24);
            this.chkPass.TabIndex = 10;
            this.chkPass.Text = "Check Pass";
            this.chkPass.UseVisualStyleBackColor = true;
            this.chkPass.CheckedChanged += new System.EventHandler(this.chkPass_CheckedChanged);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(171, 145);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.ReadOnly = true;
            this.txtPassword2.Size = new System.Drawing.Size(316, 27);
            this.txtPassword2.TabIndex = 12;
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 242);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnCompress);
            this.Controls.Add(this.txtUnCompress);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.txtCompress);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(752, 289);
            this.MinimumSize = new System.Drawing.Size(752, 289);
            this.Name = "Form1";
            this.Text = "CompressionSharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtCompress;
        private Button btnCompress;
        private Button btnChooseFile;
        private Button btnChooseFolder;
        private Button btnUnCompress;
        private TextBox txtUnCompress;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label label2;
        private TextBox txtPassword;
        private CheckBox chkPass;
        private TextBox txtPassword2;
        private Label label3;
    }
}