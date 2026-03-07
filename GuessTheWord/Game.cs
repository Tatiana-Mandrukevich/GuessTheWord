namespace GuessTheWord;

public class Game
{
    public int LeftAttempts { get; private set; }
    public List<char> UsedLetters { get; } = new();

    public bool HasLeftAttempts => LeftAttempts > 0;
    public bool IsGeneratedWordGuessed => _generatedWord.IsGuessed(_guessedLetters);

    private readonly Difficulty _difficulty;
    private readonly WordBank _wordBank = new();
    private readonly HashSet<char> _guessedLetters = new();

    private Word _generatedWord;

    public Game(Difficulty difficulty)
    {
        _difficulty = difficulty;
        LeftAttempts = difficulty.Attempts;
    }

    public void GenerateWord()
    {
        _generatedWord = _wordBank.Generate(_difficulty);
    }

    public void AddLetter(char letter)
    {
        UsedLetters.Add(letter);

        if (_generatedWord.Contains(letter))
        {
            _guessedLetters.Add(letter);
        }
    }

    public void MinusAttempt()
    {
        if (LeftAttempts > 0)
        {
            LeftAttempts--;
        }
    }

    public string GetMask()
    {
        return _generatedWord.GetMask(_guessedLetters);
    }
}