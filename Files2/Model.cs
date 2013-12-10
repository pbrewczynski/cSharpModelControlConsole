using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files2
{
    class Model
    {
        private List<string> wordsList = new List<string>();
        bool changesSaved;

        public List<string> getWordsList () {
            return this.wordsList;
        }

        public void addWord(string word)
        {
            this.wordsList.Add(word);
            this.changesSaved = true;
        }
        public void removeWordAtIndex(uint index)
        {
            this.wordsList.RemoveAt((int)index);
            this.changesSaved = true;
        }

        public void saveToFile()
        {
            this.changesSaved = true;
            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\myDatabase.txt", this.wordsList);
        }

        public void notifyThatProgramEnd()
        {

        }


    }
}
