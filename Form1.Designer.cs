
namespace AESEncryption
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEncryptPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDcryptPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEncryptedOutput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDecryptOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInput.Location = new System.Drawing.Point(7, 36);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(660, 23);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxInput_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter plain input text";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(596, 389);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(82, 22);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Provide password to use for encryption (16 chars)";
            // 
            // textBoxEncryptPassword
            // 
            this.textBoxEncryptPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEncryptPassword.Location = new System.Drawing.Point(7, 86);
            this.textBoxEncryptPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEncryptPassword.MaxLength = 16;
            this.textBoxEncryptPassword.Name = "textBoxEncryptPassword";
            this.textBoxEncryptPassword.Size = new System.Drawing.Size(342, 23);
            this.textBoxEncryptPassword.TabIndex = 3;
            this.textBoxEncryptPassword.TextChanged += new System.EventHandler(this.textBoxEncryptPassword_TextChanged);
            this.textBoxEncryptPassword.Leave += new System.EventHandler(this.textBoxEncryptPassword_Leave);
            this.textBoxEncryptPassword.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEncryptPassword_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxEncryptPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxInput);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(11, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(678, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxDcryptPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxEncrypted);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(11, 200);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(678, 172);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Provide password to use for decryption (16 chars)";
            // 
            // textBoxDcryptPassword
            // 
            this.textBoxDcryptPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDcryptPassword.Location = new System.Drawing.Point(7, 88);
            this.textBoxDcryptPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDcryptPassword.MaxLength = 16;
            this.textBoxDcryptPassword.Name = "textBoxDcryptPassword";
            this.textBoxDcryptPassword.Size = new System.Drawing.Size(342, 23);
            this.textBoxDcryptPassword.TabIndex = 3;
            this.textBoxDcryptPassword.TextChanged += new System.EventHandler(this.textBoxDcryptPassword_TextChanged);
            this.textBoxDcryptPassword.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDcryptPassword_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter encrypted text (base64 string)";
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEncrypted.Location = new System.Drawing.Point(7, 36);
            this.textBoxEncrypted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.Size = new System.Drawing.Size(660, 23);
            this.textBoxEncrypted.TabIndex = 0;
            this.textBoxEncrypted.TextChanged += new System.EventHandler(this.textBoxEncrypted_TextChanged);
            this.textBoxEncrypted.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEncrypted_MouseDoubleClick);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Enabled = false;
            this.buttonDecrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDecrypt.Location = new System.Drawing.Point(278, 389);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(82, 22);
            this.buttonDecrypt.TabIndex = 7;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Enabled = false;
            this.buttonEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEncrypt.Location = new System.Drawing.Point(18, 389);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(82, 22);
            this.buttonEncrypt.TabIndex = 8;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Encrypted text (base64 string)";
            // 
            // textBoxEncryptedOutput
            // 
            this.textBoxEncryptedOutput.Location = new System.Drawing.Point(20, 155);
            this.textBoxEncryptedOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEncryptedOutput.Name = "textBoxEncryptedOutput";
            this.textBoxEncryptedOutput.ReadOnly = true;
            this.textBoxEncryptedOutput.Size = new System.Drawing.Size(660, 23);
            this.textBoxEncryptedOutput.TabIndex = 9;
            this.textBoxEncryptedOutput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEncryptedOutput_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Decrypted text";
            // 
            // textBoxDecryptOutput
            // 
            this.textBoxDecryptOutput.Location = new System.Drawing.Point(19, 338);
            this.textBoxDecryptOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDecryptOutput.Name = "textBoxDecryptOutput";
            this.textBoxDecryptOutput.ReadOnly = true;
            this.textBoxDecryptOutput.Size = new System.Drawing.Size(660, 23);
            this.textBoxDecryptOutput.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 435);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDecryptOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEncryptedOutput);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Everything Embedded - Symmetric Encryption/Decryption";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEncryptPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDcryptPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEncryptedOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDecryptOutput;
    }
}

