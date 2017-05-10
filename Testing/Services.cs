using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Services
    {
        public static Dictionary<char, bool> CreateDictionary()
        {
            var dictionary = new Dictionary<char, bool>();

            dictionary.Add('a', false);
            dictionary.Add('b', false);
            dictionary.Add('c', false);
            dictionary.Add('d', false);
            dictionary.Add('e', false);
            dictionary.Add('f', false);
            dictionary.Add('g', false);
            dictionary.Add('h', false);
            dictionary.Add('i', false);
            dictionary.Add('j', false);
            dictionary.Add('k', false);
            dictionary.Add('l', false);
            dictionary.Add('m', false);
            dictionary.Add('n', false);
            dictionary.Add('o', false);
            dictionary.Add('p', false);
            dictionary.Add('q', false);
            dictionary.Add('r', false);
            dictionary.Add('s', false);
            dictionary.Add('t', false);
            dictionary.Add('u', false);
            dictionary.Add('v', false);
            dictionary.Add('w', false);
            dictionary.Add('x', false);
            dictionary.Add('y', false);
            dictionary.Add('z', false);

            return dictionary;
        }

        public static Dictionary<char, bool> CompareSentenceToDictionary(Dictionary<char, bool> alphabetCounter, String str)
        {
            foreach (var character in str.ToLower())
            {
                switch (character)
                {
                    case 'a':
                        alphabetCounter['a'] = true;
                        break;
                    case 'b':
                        alphabetCounter['b'] = true;
                        break;
                    case 'c':
                        alphabetCounter['c'] = true;
                        break;
                    case 'd':
                        alphabetCounter['d'] = true;
                        break;
                    case 'e':
                        alphabetCounter['e'] = true;
                        break;
                    case 'f':
                        alphabetCounter['f'] = true;
                        break;
                    case 'g':
                        alphabetCounter['g'] = true;
                        break;
                    case 'h':
                        alphabetCounter['h'] = true;
                        break;
                    case 'i':
                        alphabetCounter['i'] = true;
                        break;
                    case 'j':
                        alphabetCounter['j'] = true;
                        break;
                    case 'k':
                        alphabetCounter['k'] = true;
                        break;
                    case 'l':
                        alphabetCounter['l'] = true;
                        break;
                    case 'm':
                        alphabetCounter['m'] = true;
                        break;
                    case 'n':
                        alphabetCounter['n'] = true;
                        break;
                    case 'o':
                        alphabetCounter['o'] = true;
                        break;
                    case 'p':
                        alphabetCounter['p'] = true;
                        break;
                    case 'q':
                        alphabetCounter['q'] = true;
                        break;
                    case 'r':
                        alphabetCounter['r'] = true;
                        break;
                    case 's':
                        alphabetCounter['s'] = true;
                        break;
                    case 't':
                        alphabetCounter['t'] = true;
                        break;
                    case 'u':
                        alphabetCounter['u'] = true;
                        break;
                    case 'v':
                        alphabetCounter['v'] = true;
                        break;
                    case 'w':
                        alphabetCounter['w'] = true;
                        break;
                    case 'x':
                        alphabetCounter['x'] = true;
                        break;
                    case 'y':
                        alphabetCounter['y'] = true;
                        break;
                    case 'z':
                        alphabetCounter['z'] = true;
                        break;
                }
            }

            return alphabetCounter;
        }

        public static int CheckNumberOfLettersUsed(Dictionary<char, bool> alphabetCounter)
        {
            var trueCounter = 0;

            foreach (KeyValuePair<char, bool> key in alphabetCounter)
            {
                if (key.Value == true)
                {
                    trueCounter++;
                }
            }

            return trueCounter;
        }

        public static string DeterminePangramStatus(int numberOfLettersUsed)
        {
            if (numberOfLettersUsed == 26)
            {
                return "pangram";
            }
            else
            {
                return "not pangram";
            }
        }

        public static string WomboCombo(string sentence)
        {
            return DeterminePangramStatus(
                CheckNumberOfLettersUsed(
                    CompareSentenceToDictionary(
                        CreateDictionary(), sentence)
                        ));
        }
    }
}
