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
            string mask = game.GetMask();
            ui.ShowWord(mask);

            while (game.HasLeftAttempts)
            {
                char inputLetter = ui.InputLetter();
                game.AddLetter(inputLetter);
                game.MinusAttempt();
                ui.ShowUsedLetters(game.UsedLetters);
                mask = game.GetMask();
                ui.ShowWord(mask);
                
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