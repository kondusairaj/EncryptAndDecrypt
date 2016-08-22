using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encrypt_And_Decrypt_A_Given_String
{
    class Encrypt
    {
        public string DoEncrypt(string inputText)
        {
            string userText = inputText;
            string encryptedText = string.Empty;

            string[] seperatedStringsArr = userText.Split(' ');
            int[] spaceIndexesArr = new int[seperatedStringsArr.Length - 1];

            //To find out space indexes between strings in given text
            int length = 0;
            for (int i = 0; i < seperatedStringsArr.Length - 1; i++)
            {
                string str = seperatedStringsArr[i];
                length = length + (str.Length);
                spaceIndexesArr[i] = length + 1;
            }

            //To find out rows and columns
            string stringWithoutSpaces = userText.Replace(" ", String.Empty);
            int stringWithoutSpacesLn = stringWithoutSpaces.Length;
            double sqrtOfStrWithoutSpacesLength = Math.Sqrt(stringWithoutSpacesLn);

            //bool isInt = sqrtOfStrWithoutSpacesLength % 1 == 0;
            int roundToNearestVal = Convert.ToInt32(Math.Round(sqrtOfStrWithoutSpacesLength));

            int valAfterTruncatingDecimal =
                Convert.ToInt32(decimal.Truncate(Convert.ToDecimal(sqrtOfStrWithoutSpacesLength)));

            int rows, cols;
            if (roundToNearestVal > valAfterTruncatingDecimal)
            {
                rows = roundToNearestVal;
                cols = roundToNearestVal;
            }
            else
            {
                rows = valAfterTruncatingDecimal;
                cols = rows + 1;
            }

            //To store the spaces removed text in rows*cols grid
            int lastStrLn = stringWithoutSpacesLn%cols;
            string[] stringsArrGrid = new string[rows];
            int from = 0;
            int iteration = 1;
            for (int g = 0; g < stringsArrGrid.Length; g++)
            {
                if (iteration == rows && lastStrLn != 0)
                {
                    stringsArrGrid[g] = stringWithoutSpaces.Substring(from, lastStrLn);
                }
                else
                {
                    stringsArrGrid[g] = stringWithoutSpaces.Substring(from, cols);
                    iteration++;
                }
                from = from + cols;
            }

            //Create encrypted string using stringsArrGrid
            string[] encryptedStringArr = new string[cols];
            for (int gd = 0; gd < stringsArrGrid.Length; gd++)
            {
                string gdWd = stringsArrGrid[gd];
                for (int st = 0; st < gdWd.Length; st++)
                {
                    encryptedStringArr[st] = encryptedStringArr[st] + gdWd[st];
                }
            }
            foreach (string enc in encryptedStringArr)
            {
                encryptedText = encryptedText + enc + " ";
            }
            encryptedText = encryptedText + "numsp ";
            foreach (int indexes in spaceIndexesArr)
            {
                encryptedText = encryptedText + indexes.ToString() + " ";
            }
            if (spaceIndexesArr.Length == 0)
            {
                encryptedText = encryptedText + " 0";
            }

            return encryptedText;
        }
    }
}
