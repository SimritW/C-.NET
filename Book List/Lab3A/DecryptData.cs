/**
 * I, Simrit Waraich 000774535, certify that this material is my original
 * work. No other person's work has been used without due acknowledgement and I have
 * not made my work available to anyone else.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    /// <summary>
    /// Decrpt Data extends IEncryptable
    /// </summary>
    class DecryptData : IEncryptable
    {
        public string Summary;
        /// <summary>
        /// Constructor loading for the summary string 
        /// </summary>
        /// <param name="Summary"></param>
        public DecryptData(string Summary)
        {
            this.Summary = Summary;
        }
        /// <summary>
        /// Does nothing as of yet
        /// </summary>
        /// <returns></returns>
        public string Encrypt()
        {
            return "";
        }
        /// <summary>
        /// Decrpts the ROT13 text
        /// </summary>
        /// <returns>the array of the decrypted text</returns>
        public string Decrypt()
        {
            char[] array = Summary.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;   //moves the number 13 spaces back
                    }
                    else
                    {
                        number += 13;   //moves the number 13 spaces forward
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13; //moves the number 13 spaces back
                    }
                    else
                    {
                        number += 13;   //moves the number 13 spaces forward
                    }
                }
                array[i] = (char)number;    //sets the array to the new numbers for the new characters 
            }
            return new string(array);   //sending the decrypted data back

        }
    }
}
