namespace GuesTheWord;

public class Game
{
    private int _attempts;
    private int _attemptsMax;
    private List<char> _usedLetters = new List<char>();
    private List<char> _guessedLetters = new List<char>();
    
    public  Game(int attemptsMax)
    {
        _attemptsMax = attemptsMax;
    }

    public void AddLetter(char letter, bool isGuessed)
    {
        _usedLetters.Add(letter);
        
        if (isGuessed)
        {
            _guessedLetters.Add(letter);
        }
    }
}