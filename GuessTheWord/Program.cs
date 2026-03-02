using System;

namespace GuesTheWord
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char[] guessedLetters = new[] {'h', 'a', 'e', 'i', 'o', 'u'};
            
            var easyMood = new Difficulty(DifficultyType.Easy);
            var normalMood = new Difficulty(DifficultyType.Normal);
            var hardMood = new Difficulty(DifficultyType.Hard);
            
            var wordBank = new WordBank();
            var generatedWord = wordBank.Generate(easyMood);
            Console.WriteLine($"{generatedWord.GetMask(guessedLetters)}");
            
            /*Console.WriteLine($"{easyMood.Attempts}, " +
                              $"{easyMood.MinWordLenght}, " +
                              $"{easyMood.MaxWordLenght}");*/
        }
    }
}