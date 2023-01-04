using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Programming_test
{
    public class Program
    {

        static string ReverseString(string text)
        {
            if (text == null) return null;
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

         static void NextLetter(string s, int k)
        {

            String newS = "";

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    int val = s[i];
                    int dup = k;
                    if (val + k > 122)
                    {
                        k -= (122 - val);
                        k = k % 26;

                        newS += (char)(96 + k);

                        if (newS[i] == 'a' || newS[i] == 'e' ||
                           newS[i] == 'i' || newS[i] == 'o' ||
                           newS[i] == 'u')
                        {
                            char c = char.ToUpperInvariant(newS[i]);
                            StringBuilder newString = new StringBuilder(newS);
                            newString[i] = c;
                            newS = newString.ToString();
                        }

                    }
                    else
                    {
                        newS += (char)(96 + k);

                        if (newS[i] == 'a' || newS[i] == 'e' ||
                          newS[i] == 'i' || newS[i] == 'o' ||
                          newS[i] == 'u')
                        {
                            char c = char.ToUpperInvariant(newS[i]);
                            StringBuilder newString = new StringBuilder(newS);
                            newString[i] = c;
                            newS = newString.ToString();
                        }
                    }

                    k = dup;

                }
                else if (s[i] >= 'A' && s[i] <= 'Z'){
                    int val = s[i];
                    int dup = k;
                    if (val + k > 90)
                     {
                     k -= (90 - val);
                     k = k % 26;

                     newS += (char)(64 + k);

                     }
                    else
                     {
                      newS += (char)(64 + k);

                      }

                k = dup;

                }
                else
                {
                    newS += (char) (s[i]);
                }
            }
            Console.Write(newS);
        }

        static void StarredLetters(string s)
        {
            
            var list = new List<int>();


            for (int i = 1; i+1 < s.Length; ++i)
            {
                if (s[i] >= 'a' && s[i] <= 'z' || s[i] >= 'A' && s[i] <= 'Z')
                {
                    if (s[i - 1] == '*' && s[i + 1] == '*')
                    {
                        list.Add(1);
                    }

                    else
                    {
                        list.Add(0);
                    }
                }
            }
            var array = list.ToArray();
            bool exists = Array.Exists(array, element => element == 0);

           if (exists == true)
                {
                    Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
            

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string Input = Console.ReadLine();
            string Output = ReverseString(Input);
            Console.WriteLine("Reserved string is - " + Output);
            Console.WriteLine("Enter second string:");
            String str = Console.ReadLine();
            int k = 28;
            NextLetter(str, k);
            Console.WriteLine("Enter third string:");
            string Input1 = Console.ReadLine();
            StarredLetters(Input1);

        }

    }
}
