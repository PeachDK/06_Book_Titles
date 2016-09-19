using System;
using System.Globalization;

namespace _06_Book_Titles
{
    internal class Book
    {
        private string v = "";
        public string Title
        {


            get
            {
                return v;
            }

            set
            {

                v = value;
                CultureInfo cultureInfo = new CultureInfo("en-US");
                TextInfo textInfo = cultureInfo.TextInfo;
                //Array contains word that should not be capitalized.
                string[] fy = { "and", "over", "the", "an", "a", "in", "of" };

                //inputs string v into a array. Using build in method spilt.
                string[] s = v.Split();

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[0] != null)
                    {
                        s[0] = textInfo.ToTitleCase(s[0]);
                    }

                    bool a = Array.Exists(fy, element => element == s[i]);
                    if (a == false)
                    {
                        s[i] = textInfo.ToTitleCase(s[i]);
                    }


                }
                v = string.Join(" ", s);

            }
        }
    }
}