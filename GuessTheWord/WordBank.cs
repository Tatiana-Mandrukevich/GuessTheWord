namespace GuessTheWord;

public class WordBank
{
    private readonly HashSet<Word> _words;

    public WordBank()
    {
        _words = new HashSet<Word>
        {
            new("IDE"),
            new("DOG"),
            new("CAT"),
            new("HOME"),
            new("COLD"),
            new("UNITY"),
            new("LAPTOP"),
            new("FAMILY"),
            new("TEACHER"),
            new("COMPUTER")
        };
    }

    public Word Generate(Difficulty difficulty)
    {
        var words = _words.Where(word => word.Length >= difficulty.MinWordLenght && 
                                         word.Length <= difficulty.MaxWordLenght).ToArray();
        var random = new Random();
        int index = random.Next(words.Length);
        return words[index];
    }
}