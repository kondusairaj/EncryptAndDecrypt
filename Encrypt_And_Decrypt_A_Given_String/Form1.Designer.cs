namespace Encrypt_And_Decrypt_A_Given_String
{
    partial class FormEncryptAndDecrypt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEncryptError = new System.Windows.Forms.Label();
            this.lblFinalEncryptedTxt = new System.Windows.Forms.Label();
            this.lblEncryptedText = new System.Windows.Forms.Label();
            this.encryptTxtBox = new System.Windows.Forms.TextBox();
            this.lblEnterEncryptText = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDecryptError = new System.Windows.Forms.Label();
            this.lblFinalDecryptedTxt = new System.Windows.Forms.Label();
            this.lblDecryptedText = new System.Windows.Forms.Label();
            this.decryptTxtBox = new System.Windows.Forms.TextBox();
            this.lblEnterDecryptText = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblUnitTestResult = new System.Windows.Forms.Label();
            this.btnDecryptUnitTest = new System.Windows.Forms.Button();
            this.btnEncryptUnitTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUnitTestGivenText = new System.Windows.Forms.Label();
            this.lblUnitNameGivenText = new System.Windows.Forms.Label();
            this.lblUnitNameResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblEncryptError);
            this.panel1.Controls.Add(this.lblFinalEncryptedTxt);
            this.panel1.Controls.Add(this.lblEncryptedText);
            this.panel1.Controls.Add(this.encryptTxtBox);
            this.panel1.Controls.Add(this.lblEnterEncryptText);
            this.panel1.Controls.Add(this.btnEncrypt);
            this.panel1.Location = new System.Drawing.Point(160, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 146);
            this.panel1.TabIndex = 12;
            // 
            // lblEncryptError
            // 
            this.lblEncryptError.AutoSize = true;
            this.lblEncryptError.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblEncryptError.ForeColor = System.Drawing.Color.Red;
            this.lblEncryptError.Location = new System.Drawing.Point(205, 13);
            this.lblEncryptError.Name = "lblEncryptError";
            this.lblEncryptError.Size = new System.Drawing.Size(0, 18);
            this.lblEncryptError.TabIndex = 15;
            this.lblEncryptError.UseCompatibleTextRendering = true;
            // 
            // lblFinalEncryptedTxt
            // 
            this.lblFinalEncryptedTxt.AutoSize = true;
            this.lblFinalEncryptedTxt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFinalEncryptedTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFinalEncryptedTxt.Location = new System.Drawing.Point(205, 72);
            this.lblFinalEncryptedTxt.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblFinalEncryptedTxt.Name = "lblFinalEncryptedTxt";
            this.lblFinalEncryptedTxt.Size = new System.Drawing.Size(0, 20);
            this.lblFinalEncryptedTxt.TabIndex = 14;
            this.lblFinalEncryptedTxt.UseCompatibleTextRendering = true;
            // 
            // lblEncryptedText
            // 
            this.lblEncryptedText.AutoSize = true;
            this.lblEncryptedText.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblEncryptedText.ForeColor = System.Drawing.Color.Black;
            this.lblEncryptedText.Location = new System.Drawing.Point(97, 72);
            this.lblEncryptedText.Name = "lblEncryptedText";
            this.lblEncryptedText.Size = new System.Drawing.Size(0, 19);
            this.lblEncryptedText.TabIndex = 13;
            // 
            // encryptTxtBox
            // 
            this.encryptTxtBox.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.encryptTxtBox.Location = new System.Drawing.Point(204, 34);
            this.encryptTxtBox.Name = "encryptTxtBox";
            this.encryptTxtBox.Size = new System.Drawing.Size(484, 25);
            this.encryptTxtBox.TabIndex = 12;
            // 
            // lblEnterEncryptText
            // 
            this.lblEnterEncryptText.AutoSize = true;
            this.lblEnterEncryptText.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblEnterEncryptText.ForeColor = System.Drawing.Color.Black;
            this.lblEnterEncryptText.Location = new System.Drawing.Point(66, 35);
            this.lblEnterEncryptText.Name = "lblEnterEncryptText";
            this.lblEnterEncryptText.Size = new System.Drawing.Size(132, 19);
            this.lblEnterEncryptText.TabIndex = 11;
            this.lblEnterEncryptText.Text = "Enter text to encrypt";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnEncrypt.Location = new System.Drawing.Point(706, 34);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(74, 25);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblDecryptError);
            this.panel2.Controls.Add(this.lblFinalDecryptedTxt);
            this.panel2.Controls.Add(this.lblDecryptedText);
            this.panel2.Controls.Add(this.decryptTxtBox);
            this.panel2.Controls.Add(this.lblEnterDecryptText);
            this.panel2.Controls.Add(this.btnDecrypt);
            this.panel2.Location = new System.Drawing.Point(160, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 144);
            this.panel2.TabIndex = 13;
            // 
            // lblDecryptError
            // 
            this.lblDecryptError.AutoSize = true;
            this.lblDecryptError.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblDecryptError.ForeColor = System.Drawing.Color.Red;
            this.lblDecryptError.Location = new System.Drawing.Point(205, 10);
            this.lblDecryptError.Name = "lblDecryptError";
            this.lblDecryptError.Size = new System.Drawing.Size(0, 18);
            this.lblDecryptError.TabIndex = 16;
            this.lblDecryptError.UseCompatibleTextRendering = true;
            // 
            // lblFinalDecryptedTxt
            // 
            this.lblFinalDecryptedTxt.AutoSize = true;
            this.lblFinalDecryptedTxt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFinalDecryptedTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFinalDecryptedTxt.Location = new System.Drawing.Point(205, 73);
            this.lblFinalDecryptedTxt.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblFinalDecryptedTxt.Name = "lblFinalDecryptedTxt";
            this.lblFinalDecryptedTxt.Size = new System.Drawing.Size(0, 20);
            this.lblFinalDecryptedTxt.TabIndex = 19;
            this.lblFinalDecryptedTxt.UseCompatibleTextRendering = true;
            // 
            // lblDecryptedText
            // 
            this.lblDecryptedText.AutoSize = true;
            this.lblDecryptedText.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDecryptedText.ForeColor = System.Drawing.Color.Black;
            this.lblDecryptedText.Location = new System.Drawing.Point(97, 73);
            this.lblDecryptedText.Name = "lblDecryptedText";
            this.lblDecryptedText.Size = new System.Drawing.Size(0, 19);
            this.lblDecryptedText.TabIndex = 18;
            // 
            // decryptTxtBox
            // 
            this.decryptTxtBox.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.decryptTxtBox.Location = new System.Drawing.Point(204, 31);
            this.decryptTxtBox.Name = "decryptTxtBox";
            this.decryptTxtBox.Size = new System.Drawing.Size(484, 25);
            this.decryptTxtBox.TabIndex = 17;
            this.decryptTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decryptTxtBox_KeyPress);
            // 
            // lblEnterDecryptText
            // 
            this.lblEnterDecryptText.AutoSize = true;
            this.lblEnterDecryptText.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblEnterDecryptText.ForeColor = System.Drawing.Color.Black;
            this.lblEnterDecryptText.Location = new System.Drawing.Point(66, 32);
            this.lblEnterDecryptText.Name = "lblEnterDecryptText";
            this.lblEnterDecryptText.Size = new System.Drawing.Size(133, 19);
            this.lblEnterDecryptText.TabIndex = 16;
            this.lblEnterDecryptText.Text = "Enter text to decrypt";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnDecrypt.Location = new System.Drawing.Point(706, 30);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(74, 25);
            this.btnDecrypt.TabIndex = 15;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblUnitTestResult
            // 
            this.lblUnitTestResult.AutoSize = true;
            this.lblUnitTestResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitTestResult.ForeColor = System.Drawing.Color.Black;
            this.lblUnitTestResult.Location = new System.Drawing.Point(355, 522);
            this.lblUnitTestResult.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblUnitTestResult.Name = "lblUnitTestResult";
            this.lblUnitTestResult.Size = new System.Drawing.Size(0, 22);
            this.lblUnitTestResult.TabIndex = 26;
            this.lblUnitTestResult.UseCompatibleTextRendering = true;
            // 
            // btnDecryptUnitTest
            // 
            this.btnDecryptUnitTest.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptUnitTest.Location = new System.Drawing.Point(468, 411);
            this.btnDecryptUnitTest.Name = "btnDecryptUnitTest";
            this.btnDecryptUnitTest.Size = new System.Drawing.Size(212, 23);
            this.btnDecryptUnitTest.TabIndex = 25;
            this.btnDecryptUnitTest.Text = "Run unit test for decryption";
            this.btnDecryptUnitTest.UseVisualStyleBackColor = true;
            this.btnDecryptUnitTest.Click += new System.EventHandler(this.btnDecryptUnitTest_Click);
            // 
            // btnEncryptUnitTest
            // 
            this.btnEncryptUnitTest.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptUnitTest.Location = new System.Drawing.Point(235, 411);
            this.btnEncryptUnitTest.Name = "btnEncryptUnitTest";
            this.btnEncryptUnitTest.Size = new System.Drawing.Size(193, 23);
            this.btnEncryptUnitTest.TabIndex = 24;
            this.btnEncryptUnitTest.Text = "Run unit test for encryption";
            this.btnEncryptUnitTest.UseVisualStyleBackColor = true;
            this.btnEncryptUnitTest.Click += new System.EventHandler(this.btnEncryptUnitTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(233, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Unit test for Encryption :";
            // 
            // lblUnitTestGivenText
            // 
            this.lblUnitTestGivenText.AutoSize = true;
            this.lblUnitTestGivenText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitTestGivenText.Location = new System.Drawing.Point(328, 465);
            this.lblUnitTestGivenText.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblUnitTestGivenText.Name = "lblUnitTestGivenText";
            this.lblUnitTestGivenText.Size = new System.Drawing.Size(0, 22);
            this.lblUnitTestGivenText.TabIndex = 23;
            this.lblUnitTestGivenText.UseCompatibleTextRendering = true;
            // 
            // lblUnitNameGivenText
            // 
            this.lblUnitNameGivenText.AutoSize = true;
            this.lblUnitNameGivenText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitNameGivenText.ForeColor = System.Drawing.Color.Blue;
            this.lblUnitNameGivenText.Location = new System.Drawing.Point(245, 465);
            this.lblUnitNameGivenText.Name = "lblUnitNameGivenText";
            this.lblUnitNameGivenText.Size = new System.Drawing.Size(0, 19);
            this.lblUnitNameGivenText.TabIndex = 27;
            // 
            // lblUnitNameResult
            // 
            this.lblUnitNameResult.AutoSize = true;
            this.lblUnitNameResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitNameResult.ForeColor = System.Drawing.Color.Blue;
            this.lblUnitNameResult.Location = new System.Drawing.Point(245, 522);
            this.lblUnitNameResult.Name = "lblUnitNameResult";
            this.lblUnitNameResult.Size = new System.Drawing.Size(0, 19);
            this.lblUnitNameResult.TabIndex = 28;
            // 
            // FormEncryptAndDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1177, 584);
            this.Controls.Add(this.lblUnitNameResult);
            this.Controls.Add(this.lblUnitNameGivenText);
            this.Controls.Add(this.lblUnitTestResult);
            this.Controls.Add(this.btnDecryptUnitTest);
            this.Controls.Add(this.btnEncryptUnitTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUnitTestGivenText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEncryptAndDecrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt And Decrypt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFinalEncryptedTxt;
        private System.Windows.Forms.Label lblEncryptedText;
        private System.Windows.Forms.TextBox encryptTxtBox;
        private System.Windows.Forms.Label lblEnterEncryptText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFinalDecryptedTxt;
        private System.Windows.Forms.Label lblDecryptedText;
        private System.Windows.Forms.TextBox decryptTxtBox;
        private System.Windows.Forms.Label lblEnterDecryptText;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblEncryptError;
        private System.Windows.Forms.Label lblDecryptError;
        private System.Windows.Forms.Label lblUnitTestResult;
        private System.Windows.Forms.Button btnDecryptUnitTest;
        private System.Windows.Forms.Button btnEncryptUnitTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUnitTestGivenText;
        private System.Windows.Forms.Label lblUnitNameGivenText;
        private System.Windows.Forms.Label lblUnitNameResult;

    }
}

