using System;
using System.Collections.Generic;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary fruits = new Dictionary();

            fruits["apple"] = "A particularly delicious pomaceous fruit of the genus Malus.";
            fruits["dragonfruit"] = "Does anyone actually eat this textureless fruit?";
            Console.WriteLine($"Would you like to lookup(1) a fruit or add a definition(2)?\n");
            string option = Console.ReadLine();
            if (option == "1")
            {
                Console.WriteLine($"Please type in a fruit name:\n");
                string lookup = Console.ReadLine();
                Console.WriteLine($"\n{fruits[lookup]}");
            }
            else if (option == "2")
            {
                Console.WriteLine($"Please type in a fruit name:\n");
                string newWord = Console.ReadLine();
                Console.WriteLine($"\nPlease type in a definition for that fruit:\n");
                string newDef = Console.ReadLine();
                fruits.AddDefinition(newWord, newDef);
                Console.WriteLine($"\n{newWord}: {fruits[newWord]}");

            }


            
            //Console.WriteLine(fruits["apple"]);
            //Console.WriteLine(fruits["dragonfruit"]);
        }
    }
    class Dictionary
    {
        private List<string> words;
        private List<string> definitions;

        public Dictionary()
        {
            words = new List<string>();
            definitions = new List<string>();
        }

        public string this[string lookup]
        {
            get
            {
                string answer = Lookup(lookup);
                if (answer == null) { throw new Exception($"{lookup} was not found"); }
                return answer;
            }
            set
            {
                AddDefinition(lookup, value);
            }
        }

        public void AddDefinition(string word, string definition)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if ( words[i] == word) 
                {
                    definitions[i] = definition;
                }
            }
            words.Add(word);
            definitions.Add(definition);
        }

        private string Lookup(string input)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == input)
                {
                    return definitions[i];
                }                
            }
            return null;
        }
    }
}