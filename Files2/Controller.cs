using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files2
{
    class Controller
    {
        Model model;
        
        public Controller(Model model)
        {
            this.model = model;

        }

        public void showAllWords()
        {
            List<string> wordsList = this.model.getWordsList();

            foreach (string s in wordsList)
            {
                Console.WriteLine(s);
            }
        }

        public void addWord()
        {
            Console.WriteLine("Write the word you want to add : ");
            string word = Console.ReadLine();
            this.model.addWord(word);
        }

        public void removeWordAtGivenIndex()
        {
            Console.WriteLine("Pass the index on which you want to remove the word");
            string sIndex = Console.ReadLine();
            try
            {
                uint index = uint.Parse(sIndex);
                this.model.removeWordAtIndex(index);
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Index is not number");
                return;
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Passed index out of bounds");
                return;
            }
        }

        public void saveToFile()
        {
        }

        public void quit()
        {
            if (this.changesSaved)
            {
                File.WriteAllText(Directory.GetCurrentDirectory() + @"\isSaved.txt", "1");
            }
            else
            {
                File.WriteAllText(Directory.GetCurrentDirectory() + @"\isSaved.txt", "0");
            }
        }

        public void interact()
        {
            string enteredString;
            do
            {
                Console.WriteLine("1. Show words");
                Console.WriteLine("2. Add word");
                Console.WriteLine("3. Remove word at give index");
                Console.WriteLine("4. Save Words to the file");
                enteredString = Console.ReadLine();
                switch (enteredString)
                {
                    case "1": this.showAllWords();
                        break;
                    case "2": this.addWord();
                        break;
                    case "3": this.removeWordAtGivenIndex();
                        break;
                    case "4": this.saveToFile();
                        break;
                    case "5": this.quit();
                        break;

                }
            } while (enteredString != "q");
        }
    }
}
