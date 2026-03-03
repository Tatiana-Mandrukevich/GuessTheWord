namespace GuessTheWord;

public class ConsoleUI
{
    public char InputLetter()
    {
        string result = ReadLetter();
        
        while (!IsInputLetterValid(result))
        {
            result = ReadLetter();
        }
        
        return result[0];
    }

    private string ReadLetter()
    {
        Console.Write("Enter a letter: ");
        return Console.ReadLine();
    }

    private bool IsInputLetterValid(string inputLetter)
    {
        if (inputLetter.Length == 1 && char.IsLetter(inputLetter[0]))
        {
            return true;
        }
        else
        {
            Console.WriteLine($"Invalid letter: {inputLetter}");
            return false;
        }
    }

    public DifficultyType ChooseDifficulty()
    {
        while (true)
        {
            string result = ReadDifficulty();

            switch (result)
            {
                case "1":
                    return DifficultyType.Easy;
                case "2":
                    return DifficultyType.Normal;
                case "3":
                    return DifficultyType.Hard;
                default:
                    Console.WriteLine($"Invalid difficulty: {result}");
                    break;
            }
        }
    }

    private string ReadDifficulty()
    {
        Console.WriteLine("Choose difficulty:\n" +
                          "1 - Easy\n" +
                          "2 - Normal\n" +
                          "3 - Hard");
        return Console.ReadLine();
    }

    public void ShowUsedLetters(char[] letters)
    {
        Console.WriteLine("Used letters:");
            
        foreach (char letter in letters)
        {
            Console.Write($"{letter} ");
        }
        
        Console.WriteLine();
    }

    public void ShowWord(string word)
    {
        Console.WriteLine($"Word: {word}");
    }
    
    public void ShowLeftAttempts(int leftAttempts)
    {
        Console.WriteLine($"Left attempts: {leftAttempts}");
    }

    public void ShowGameResult(bool isWin)
    {
        Console.WriteLine(isWin ? "You won!" : "You lost!");
    }
}