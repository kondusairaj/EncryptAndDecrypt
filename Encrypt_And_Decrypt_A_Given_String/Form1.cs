using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encrypt_And_Decrypt_A_Given_String
{
    public partial class FormEncryptAndDecrypt : Form
    {
        public FormEncryptAndDecrypt()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            EncryptFields();
            string userText = encryptTxtBox.Text.Trim();
            if (userText != string.Empty)
            {
                Encrypt obj1 = new Encrypt();
                string encryptedText = obj1.DoEncrypt(userText);
                lblEncryptedText.Text = @"Encrypted Text :";
                lblFinalEncryptedTxt.Text = encryptedText;
            }
            else
            {
                lblEncryptError.Text = @"Please enter text to encrypt";
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            DecryptFields();
            string userText = decryptTxtBox.Text.Trim();
            if (userText != string.Empty)
            {
                if (userText.Contains("numsp"))
                {
                    Decrypt obj2 = new Decrypt();
                    string decryptedText = obj2.DoDecrypt(userText);
                    if (decryptedText.Trim() != String.Empty)
                    {
                        if (decryptedText == "ERROR")
                        {
                            lblDecryptError.Text = @"*Invalid input";
                        }
                        else
                        {
                            lblDecryptedText.Text = @"Decrypted Text :";
                            lblFinalDecryptedTxt.Text = decryptedText;
                        }
                    }
                }
                else
                {
                    lblDecryptError.Text = @"*Invalid input";
                }
            }
        }

        private void EncryptFields()
        {
            lblEncryptError.Text = string.Empty;
            lblEncryptedText.Text = String.Empty;
            lblFinalEncryptedTxt.Text = String.Empty;
        }

        private void DecryptFields()
        {
            lblDecryptError.Text = string.Empty;
            lblDecryptedText.Text = String.Empty;
            lblFinalDecryptedTxt.Text = String.Empty;
        }

        private void btnEncryptUnitTest_Click(object sender, EventArgs e)
        {
            string givenText = @"if man was meant to stay on the ground god would have given us roots";
            Encrypt objEncrypt = new Encrypt();
            string encryptedText = objEncrypt.DoEncrypt(givenText);

            lblUnitNameGivenText.Text = @"Given text : ";
            lblUnitTestGivenText.Text = givenText;
            lblUnitNameResult.Text = @"Encrypted text : ";
            lblUnitTestResult.Text = encryptedText;
        }

        private void btnDecryptUnitTest_Click(object sender, EventArgs e)
        {
            string givenText = @"imtgdvs fearwer mayoogo anouuio ntnnlvt wttddes aohghn sseoau numsp 3 6 9 14 16 20 22 25 31 34 39 43 48 50";
            Decrypt objDecrypt = new Decrypt();
            string decryptedText = objDecrypt.DoDecrypt(givenText);

            lblUnitNameGivenText.Text = @"Given text : ";
            lblUnitTestGivenText.Text = givenText;
            lblUnitNameResult.Text = @"Decrypted text : ";
            lblUnitTestResult.Text = decryptedText;
        }

        private void decryptTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblDecryptError.Text = string.Empty;
        }


    }
}
