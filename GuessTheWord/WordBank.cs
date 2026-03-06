namespace GuessTheWord;

public class WordBank
{
    private List<Word> _words;

    public WordBank()
    {
        _words = new List<Word>
        {
            new("ide"),
            new("dog"),
            new("cat"),
            new("home"),
            new("cold"),
            new("unity"),
            new("laptop"),
            new("family"),
            new("teacher"),
            new("computer")
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