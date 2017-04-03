using System;

namespace PasswordGenerator
{
    class Password
    {
        Random thisRandom = new Random();
        const int LENGTH = 12;

        public string getPassword(Boolean pronouncable)
        {
            int count = 0;

            // A digit, an uppercase letter, lowercase characers, 
            // and ending with a special character.
            // Total lenght is 15 to 19 characters

            string result = "";

            result += getDigit();
            result += getUpperCase();

            if (pronouncable)
            {
                //english phonemes
                string english = string.Empty;
                while (english.Length < LENGTH)
                {
                    english += getPhoneme();
                    count++;
                }

                result += english;
            }
            else
            {
                // any old characters
                for (int x = 0; x < LENGTH; x++)
                {
                    result += getLowerCase();
                }
            }
            result += getSpecial();
        
            if (pronouncable)
            {
                System.Windows.Forms.MessageBox.Show(count.ToString() + " phonemes");
            }
            return result;
        }

        string getUpperCase()
        {
            // unambigious characters (no 'I' or 'O')
            string upper = "ABCDEFGHJKLMNPQRSTUVWXYZ";
            return chooser(upper);
        }

        string getLowerCase()
        {
            // unambigious characters (no 'i', 'l', or 'o')
            string lower = "abcdefghjknmpqrstuvwxyz";
            return chooser(lower);
        }

        string getDigit()
        {
            // unambigious characters (no 1 or 0)
            string digits = "23456789";
            return chooser(digits);
        }

        string getSpecial()
        {
            // shifted numbers from QWERTY keyboard
            string special = "!@#$%^&*()";
            return chooser(special);
        }

        string getPhoneme()
        {
            // Phonemes (actaully 138 graphemes) from http://www.dyslexia-reading-well.com/44-phonemes-in-english.html

            string[] phoneme =
            {
                "a", "ae", "ai", "aigh", "ar", "au", "augh", "augur", "aw", "ay", "ayer",
                "b", "bb", "be", "beau", "c", "cc", "ce", "centre", "ch", "ci", "ck", "d",
                "dd", "dge", "di", "e", "ea", "eau", "ed", "ee", "eer", "ei", "eigh", "eir",
                "er", "ere", "et", "eu", "eue", "eur", "ew", "ey", "f", "ff", "g", "ge",
                "gg", "gh", "gn", "gu", "gue", "h", "ho", "i", "ie", "ier", "ieu", "iew",
                "igh", "ir", "is", "it", "j", "k", "kn", "l", "lf", "lk", "ll", "lm", "m",
                "mb", "mm", "mn", "n", "nn", "o", "oa", "oe", "oew", "of", "oi", "oo",
                "oor", "or", "ore", "ou", "ough", "ow", "oy", "p", "ph", "pn", "pp", "ps",
                "qu", "quay", "r", "re", "rh", "rr", "s", "sc", "sci", "se", "sh", "si",
                "ss", "st", "t", "tch", "te", "th", "ti", "tt", "tu", "u", "ue", "ui",
                "ul", "uoy", "ur", "ure", "uy", "v", "ve", "w", "wh", "wr", "x", "y",
                "ye", "yr", "yu", "z", "ze", "zz"
            };

            return chooser(phoneme);
        }

        string chooser(string input)
        {
            int length = input.Length;
            int choice = thisRandom.Next(0, length);
            return input.Substring(choice, 1);
        }

        string chooser(string[] input)
        {
            int length = input.Length;
            int choice = thisRandom.Next(0, length);
            return input[choice];
        }


    }
}

