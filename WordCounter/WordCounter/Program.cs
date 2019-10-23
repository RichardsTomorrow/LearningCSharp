using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //string example = "Hello World!, it is I a word count program.";
            //Console.WriteLine(example.WordCount());
            Console.WriteLine($"Hello and welcome to word counter! Please enter some words below:\n");
            string input = Console.ReadLine();
            if(input == "") // word logic
            {
                Console.WriteLine($"\nI am sorry but there wasn't anything to count.");
            }
            else if (input.WordCount() == 1)
            {
                Console.WriteLine($"\nThere was only one word.");
            }
            else
            {
                Console.WriteLine($"\nThere were {input.WordCount()} words.");
            }
            
            if (input == "") // sentence logic
            {
                Console.WriteLine();
            }
            else if (input.SentenceCount() == 1)
            {
                Console.WriteLine($"\nThere was only one sentence");
            }
            else if (input.SentenceCount() > 1)
            {
                Console.WriteLine($"\nThere were {input.SentenceCount()} sentences.");
            }
            else
            {
                Console.WriteLine();
            }

            if (input == "") // paragraph logic
            {
                Console.WriteLine();
            }
            else if (input.ParagraphCount() == 1)
            {
                Console.WriteLine($"\nThere was one paragraph.");
            }
            else if (input.ParagraphCount() > 1)
            {
                Console.WriteLine($"\nThere were {input.ParagraphCount()} paragraphs.");
            }
            else
            {
                Console.WriteLine();
            }

        }
                
    }
    static class Extensions
    {
        public static int WordCount(this string text)
        {
            string[] indivWords = text.Split(' ');
            return indivWords.Length;
        }
        public static int SentenceCount(this string text)
        {
            string[] indivSentences = text.Split(new char[] {'.','!','?' });
            int sentenceCount = indivSentences.Length;
            if (indivSentences[indivSentences.Length - 1] == "") { sentenceCount -= 1; }

            return sentenceCount;
        }
        public static int ParagraphCount(this string text)
        {
            string[] indivParagraphs = text.Split('\n');
            int paragraphCount = indivParagraphs.Length;
            if (indivParagraphs[indivParagraphs.Length - 1] == "") { paragraphCount -= 1; }

            return paragraphCount;

        }
    }
}
