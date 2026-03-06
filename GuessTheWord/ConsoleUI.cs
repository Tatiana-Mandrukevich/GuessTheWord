using System.Reflection.Metadata.Ecma335;

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

        return result.ToUpper()[0];
    }

    private string ReadLetter()
    {
        Console.Write("Enter a letter: ");
        return Console.ReadLine();
    }

    private bool IsInputLetterValid(string inputLetter)
    {

        if (string.IsNullOrEmpty(inputLetter))
        {
            Console.WriteLine("Letter cannot be empty");
            return false;
        }

        if (inputLetter.Length != 1)
        {
            Console.WriteLine("Letter must contain exactly one letter");
            return false;
        }

        bool isLetter = char.IsLetter(inputLetter[0]);
                
        if (isLetter)
        {
            return true;
        }

        Console.WriteLine($"Invalid letter: {inputLetter}");
        return false;
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