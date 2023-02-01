using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace UpSchoolHomework1
{
    public class Password
    {
   
        private int passwordLength;

        public Password(int passwordLength)
        { 
            this.passwordLength = passwordLength;
        }

 
public static string CreatePassword(bool includeNumbers, bool includeLowerCase, bool includeUpperCase, bool includeSpecial, int passwordLength, Options options)
        {
            StringBuilder password = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                int asciiTableValue = rnd.Next(33,127);
              
                switch (options)
                {
                    case Options.NUMBERS:
                        if (includeNumbers && asciiTableValue >=48 && asciiTableValue<=57)
                        {
      
                           password.Append((char)asciiTableValue);
                        }
        
                    break;
                    case Options.LOWERCASE:
                        if (includeLowerCase && asciiTableValue >= 97 && asciiTableValue <= 122)
                        {
                            password.Append((char)asciiTableValue);

                        }

                    break;
                    case Options.UPPERCASE:
                        if (includeUpperCase && asciiTableValue >= 65 && asciiTableValue <= 90)
                        {
                           password.Append((char)asciiTableValue);

                        }
                    break;
                    case Options.SPECIAL:
                        if (includeSpecial && (asciiTableValue >= 33 && asciiTableValue <= 47) || (asciiTableValue >= 58 && asciiTableValue <= 64) || (asciiTableValue >= 91 && asciiTableValue <= 96) || (asciiTableValue >= 123 && asciiTableValue <= 126))
                        {
                            password.Append((char)asciiTableValue);
                        }
  
                   break;
                   default:
                        i--;
                   break;
                }
                
            }
            return password.ToString();
        }


    }
}

 

