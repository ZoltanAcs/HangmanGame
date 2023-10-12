using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hang
{
    public class Target
    {
        public string Word;
        public string HashedWord;

        public void SetWords(string word)
        {

            Word = word;
            for (int i = 0; i < word.Length; i++) ;
            {
                HashedWord = HashedWord + '*';
            }
        }

        public void CheckCharacter(string characterForSearch)
        { 
        for string i = 
        }

    }
}
