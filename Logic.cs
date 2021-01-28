using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace HangMan_games
{
    public class Logic
    {
        private int tryes = 0;
        private int quantitytryes;

        private string nullstr;
        public void Quantitytryes(int enter)
        {
            quantitytryes = enter;
        }

        private string[] NullWord()
        {
            Worde Word = new Worde();
            string word = Word.Words();
            string[] nullWord = new string[word.Length];
            int length = word.Length;
            for (int i = 0; i < length; i++)
            {
                nullWord[i] =  "_";
            }
            
            return nullWord;
        }

        private string[] Compare(string bukva)
        {
            Worde Word = new Worde();
            string word = Word.Words();
            string[] nullstri = new string[word.Length];
            if (tryes == quantitytryes)
            {
                EndGame();
            }
            if (tryes == 0)
            {
                nullstri = NullWord();
            }
            else
            {
                nullstri = ConvertArr(nullstr);
            }
            
            
            int d = 0;
            bool box = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (Convert.ToString(nullstri[i]) == "_")
                {
                    box = false;
                }
                if (bukva == Convert.ToString(word[i]))
                {
                    nullstri[i] = bukva;
                }
            }
            if (box)
            {
                WinGame();
            }
            tryes++;
            WorkingWithConsole wd = new WorkingWithConsole();
            nullstr = wd.ConvertStr(nullstri);
            return nullstri;
        }

        private string[] ConvertArr(string a)
        {
            string[] arr = new string[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = Convert.ToString(a[i]);
            }

            return arr;
        }

        private void WinGame()
        {
            System.Environment.FailFast("You Win!(Надеюсь Слава с Савелием смогут и дальше любить друг друга)");
        }

        private void EndGame()
        {
            System.Environment.FailFast("Художественный фильм СПИЗДИЛИ ПОБЕДУ!");
        }

        public string[] CallCompare(string bukva)
        {
            return Compare(bukva);
        }
    }
}