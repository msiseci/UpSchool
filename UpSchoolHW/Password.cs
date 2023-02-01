using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchoolHW
{
    public class Password
    {

        public static string CreatePassword(string includeNumbers, string includeLowerCase, string includeUpperCase, string includeSpecial, int passwordLength, Options options)
        {
            string password = "";
            Random rnd = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                char element = ' ';
                // var options = new Options();
                switch (options)
                {
                    case Options.NUMBERS:
                        if (includeNumbers == "y")
                        {
                            element = (char)rnd.Next(48, 58);
                        }

                        break;
                    case Options.LOWERCASE:
                        if (includeLowerCase == "y")
                        {
                            element = (char)rnd.Next(97, 123);

                        }

                        break;
                    case Options.UPPERCASE:
                        if (includeUpperCase == "y")
                        {
                            element = (char)rnd.Next(65, 91);

                        }
                        break;
                    case Options.SPECIAL:
                        if (includeSpecial == "y")
                        {
                            element = (char)rnd.Next(33, 48);
                        }

                        break;

                }
                password = password + element;
            }
            return password;
        }


    }
}