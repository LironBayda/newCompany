using System;
using System.Collections.Generic;
using System.Text;

namespace NewsCompany
{
    static class NewspaperCalculator
    {
        static int CalcNumberOfChars(newspaper newspaper)
        {
           Story[] stories = newspaper.GetStories();
            int chars = 0;
            for (int i = 0; i < stories.Length; i++)
            {
                string title = stories[i].GetTitle();
                string body = stories[i].GetBody();
                chars += title.Length + body.Length;
            }

            return chars;
        }
    }
}
