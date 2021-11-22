using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialised the length of the new system generated password
            int Length = 10;
            
           Console.WriteLine( Auto_Password(Length));
        }
        static char[] Auto_Password(int len)
        {
            Console.WriteLine("Generate a random strong password for users ");
            Console.Write("Your new Password is:");

            //Initialised the type of characters we want in our password(upper case, lower case, digits, symbols)
            String Capital_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String Small_chars = "abcdefghijklmnopqrstuvwxyz";
            String Digits = "0123456789";
            String Symbols = "~@#$%^&*()_+{}:<>?";
            String values = Capital_chars + Small_chars+ Digits +Symbols;
            Random rndm_method = new Random();

            //created character array to store the new password of length 10
            char[] password = new char[len];
            for(int i=0; i<len;i++)
            {   // fill in the character array with random values which were initialised above
                password[i] = values[rndm_method.Next(values.Length)];
            }
            return password;
        }
    }
}
