using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class Iban
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter IBAN number, the exact designated intervals in it:");
        string Iban = Console.ReadLine();

        string number="";
        int count = 0,maskcount=0;
        foreach (var item in Iban)
        {            
            if (item==' ') count++;
        }
        string[] iban = new string[Iban.Length-count];
        string[] finIban = new string[Iban.Length - count];
        if (Iban.Length-count != 22)
        {
            Console.WriteLine("false");
        }
        else
        {
            string countryCode = Iban.Substring(0, 2);
            string bankCode = Iban.Substring(5, 4);
            string num = Iban.Substring(2, 2);
            string toEnd = Iban.Substring(0, Iban.Length-1);
            
            bool IB = true;
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(countryCode);
            byte[] ASCIIValuesNum = Encoding.ASCII.GetBytes(num);
            byte[] ASCIIValuesToEnd = Encoding.ASCII.GetBytes(num);
            byte[] ASCIIValuesBankCode = Encoding.ASCII.GetBytes(bankCode);
            foreach (var item in Iban)
            {
                if (item != ' ')
                {
                    iban[maskcount] =Convert.ToString(item);
                    maskcount++;
                }
            }

            for (int i = 4; i < finIban.Length; i++)
            {
                    finIban[i - 4] = iban[i];
            }

            for (int i = 0; i < 4; i++)
            {
                finIban[finIban.Length - 4 + i] = iban[i];
            }
            for (var i = 0; i < finIban.Length; i++)
            {
                if (Char.IsLetter(char.Parse(finIban[i])))
                {
                    switch (char.Parse(finIban[i]))
                    {
                        case 'A': finIban[i] = Convert.ToString(10); break;
                        case 'B': finIban[i] = Convert.ToString(11); break;
                        case 'C': finIban[i] = Convert.ToString(12); break;
                        case 'D': finIban[i] = Convert.ToString(13); break;
                        case 'E': finIban[i] = Convert.ToString(14); break;
                        case 'F': finIban[i] = Convert.ToString(15); break;
                        case 'G': finIban[i] = Convert.ToString(16); break;
                        case 'H': finIban[i] = Convert.ToString(17); break;
                        case 'I': finIban[i] = Convert.ToString(18); break;
                        case 'J': finIban[i] = Convert.ToString(19); break;
                        case 'K': finIban[i] = Convert.ToString(20); break;
                        case 'L': finIban[i] = Convert.ToString(21); break;
                        case 'M': finIban[i] = Convert.ToString(22); break;
                        case 'N': finIban[i] = Convert.ToString(23); break;
                        case 'O': finIban[i] = Convert.ToString(24); break;
                        case 'P': finIban[i] = Convert.ToString(25); break;
                        case 'Q': finIban[i] = Convert.ToString(26); break;
                        case 'R': finIban[i] = Convert.ToString(27); break;
                        case 'S': finIban[i] = Convert.ToString(28); break;
                        case 'T': finIban[i] = Convert.ToString(29); break;
                        case 'U': finIban[i] = Convert.ToString(30); break;
                        case 'V': finIban[i] = Convert.ToString(31); break;
                        case 'W': finIban[i] = Convert.ToString(32); break;
                        case 'X': finIban[i] = Convert.ToString(33); break;
                        case 'Y': finIban[i] = Convert.ToString(34); break;
                        case 'Z': finIban[i] = Convert.ToString(35); break;
                    }
                }
                number += finIban[i];
            }

            decimal numb = decimal.Parse(number);
            if (numb % 97 != 1)
            {
                IB = false;
            }
            foreach (byte b in ASCIIValues)
            {
                if (b < 65 || b > 90)
                {
                    IB = false;
                    
                }
            }
            foreach (byte b in ASCIIValuesBankCode)
            {
                if (b < 65 || b > 90)
                {
                    IB = false;
                   
                }
            }
            foreach (byte b in ASCIIValuesNum)
            {
                if (b < 48 || b > 57)
                {
                    IB = false;
                    
                }
            }
            foreach (byte b in ASCIIValuesToEnd)
            {
                if (b != ' ')
                {
                    if ((b < 65 && b > 57) ||
                        (b < 48) || (b > 90))
                    {
                        IB = false;
                        
                    }
                }
            }
            Console.WriteLine(IB);
            Console.ReadLine();
        }
    }
}
