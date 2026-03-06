namespace GuessTheWord;

public class Game
{
    public int LeftAttempts { get; private set; }
    public Word GeneratedWord { get; private set; }
    public List<char> UsedLetters { get; private set; } = new();
    public HashSet<char> GuessedLetters { get; private set; } = new();
    public bool HasLeftAttempts { get; private set; } = true;
    public bool IsGeneratedWordGuessed { get; private set; } = false;
    
    private Difficulty _difficulty;
    private WordBank _wordBank = new();

    public Game(Difficulty difficulty)
    {
        _difficulty = difficulty;
        LeftAttempts = difficulty.Attempts;
    }

    public void GenerateWord()
    {
        GeneratedWord = _wordBank.Generate(_difficulty);
    }

    public void AddLetter(char letter)
    {
        UsedLetters.Add(letter);
        
        if (GeneratedWord.Contains(letter))
        {
            GuessedLetters.Add(letter);
        }
    }
    
    public void MinusAttempt()
    {
        if (LeftAttempts > 0)
        {
            LeftAttempts--;

            if (LeftAttempts == 0)
            {
                HasLeftAttempts = false;
            }
        }
        else
        {
            HasLeftAttempts = false;
        }
    }
    
    public void CheckIsGeneratedWordGuessed()
    {
        if (GeneratedWord.GetMask(GuessedLetters) == GeneratedWord.ToString())
        {
            IsGeneratedWordGuessed = true;
        }
    }
}