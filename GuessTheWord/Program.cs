using System;

namespace GuesTheWord
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var ui = new ConsoleUI();
            ui.InputLetter();
            ui.ChooseDifficulty();
        }
    }
}