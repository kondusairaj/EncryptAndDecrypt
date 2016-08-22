using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encrypt_And_Decrypt_A_Given_String
{
    class Decrypt
    {
        public string DoDecrypt(string inputText)
        {
            string userText = inputText;
            string decryptedText = string.Empty;
            string finalDecryptedTxt = String.Empty;

            string words = userText.Substring(0, userText.IndexOf("numsp", StringComparison.Ordinal));          //Seperating text from space indexes
            string spaceIndexes = userText.Substring(userText.LastIndexOf("p", StringComparison.Ordinal) + 1);        //Seperating space indexes
            string[] seperatedStringsArr = words.Trim().Split(' ');

            //Decrypting seperated text
            string[] gridStrings = new string[seperatedStringsArr.Length];
            foreach (string str in seperatedStringsArr)
            {
                if (str.Length > gridStrings.Length)
                {
                    return "ERROR";
                }
                for (int w = 0; w < str.Length; w++)
                {
                    gridStrings[w] = gridStrings[w] + str[w];
                }
            }
            foreach (string str in gridStrings)
            {
                decryptedText = decryptedText + str;
            }

            int decryptTxtLn = decryptedText.Length;

            //Adding spaces using space indexes
            string[] spaceIndexesArr = spaceIndexes.Trim().Split(' ');
            int strtIndex = 0;
            for (int s = 0; s <= spaceIndexesArr.Length; s++)
            {
                if ((spaceIndexesArr.Length > 1 && s == spaceIndexesArr.Length) || spaceIndexesArr[s].Trim() == "" || Convert.ToInt32(spaceIndexesArr[s]) == 0)
                {
                    finalDecryptedTxt = finalDecryptedTxt + decryptedText.Substring(strtIndex);
                    if (spaceIndexesArr.Length == 1)
                    {
                        break;
                    }
                }
                else if (spaceIndexesArr[s].Trim() != "" && decryptTxtLn + 1 < Convert.ToInt32(spaceIndexesArr[s]))
                {
                    return "ERROR";
                }
                else
                {
                    int currentIndex = (s == 0)
                        ? Convert.ToInt32(spaceIndexesArr[s]) - 1
                        : Convert.ToInt32(spaceIndexesArr[s]) - Convert.ToInt32(spaceIndexesArr[s - 1]);

                    finalDecryptedTxt = finalDecryptedTxt + decryptedText.Substring(strtIndex, currentIndex) + " ";
                    strtIndex = Convert.ToInt32(spaceIndexesArr[s]) - 1;
                }

            }

            return finalDecryptedTxt;
        }
    }
}
