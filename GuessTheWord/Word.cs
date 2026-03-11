namespace GuessTheWord;

public class Word
{
    private readonly string _value;
    
    public Word(string value)
    {
        _value = value;
    }
    
    public int Length => _value.Length;
    
    public bool Contains(char letter)
    {
        return _value.Contains(letter.ToString());
    }

    public string GetMask(HashSet<char> guessedLetters)
    {
        string result = string.Empty;
        
        foreach (char letter in _value)
        {
            if (guessedLetters.Contains(letter))
            {
                result += letter;
            }
            else
            {
                result += "*";
            }
        }
        
        return result;
    }
    
    public bool IsGuessed(HashSet<char> guessedLetters)
    {
        foreach (char letter in _value)
        {
            if (!guessedLetters.Contains(letter))
            {
                return false;
            }
        }
        return true;
    }
    
    public override string ToString()
    {
        return _value;
    }
    
}