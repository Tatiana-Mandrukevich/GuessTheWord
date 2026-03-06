namespace GuessTheWord
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var ui = new ConsoleUI();
            ui.ShowGameWelcomeMessage();
            
            DifficultyType difficultyType = ui.ChooseDifficulty();
            Difficulty difficulty = new Difficulty(difficultyType);
            var game = new Game(difficulty);

            ui.ShowDifficulty(difficultyType);
            ui.ShowLeftAttempts(game.LeftAttempts);
            
            game.GenerateWord();
            Word generatedWord = game.GeneratedWord;
            string generatedWordLikeMask = generatedWord.GetMask(game.GuessedLetters);
            ui.ShowWord(generatedWordLikeMask);

            while (game.HasLeftAttempts)
            {
                char inputLetter = ui.InputLetter();
                game.AddLetter(inputLetter);
                game.MinusAttempt();
                ui.ShowUsedLetters(game.UsedLetters);
                string generatedWordWithMask = generatedWord.GetMask(game.GuessedLetters);
                ui.ShowWord(generatedWordWithMask);
                
                game.CheckIsGeneratedWordGuessed();
                if (game.IsGeneratedWordGuessed)
                {
                    break;
                }
                
                ui.ShowLeftAttempts(game.LeftAttempts);
            }
            
            ui.ShowGameResult(game.IsGeneratedWordGuessed);
        }
    }
}