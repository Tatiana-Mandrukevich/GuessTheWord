namespace GuessTheWord;

public class Difficulty
{
    private readonly DifficultyType _type;

    public Difficulty(DifficultyType type)
    {
        _type = type;

        switch (type)
        {
            case DifficultyType.Easy:
                Attempts = 14;
                MinWordLenght = 3;
                MaxWordLenght = 4;
                break;
            case DifficultyType.Normal:
                Attempts = 12;
                MinWordLenght = 5;
                MaxWordLenght = 6;
                break;
            case DifficultyType.Hard:
                Attempts = 10;
                MinWordLenght = 7;
                MaxWordLenght = 8;
                break;
        }
    }
    
    public int Attempts { get; private set; }
    public int MinWordLenght { get; private set; } 
    public int MaxWordLenght { get; private set; }
}

public enum DifficultyType
{
    Easy,
    Normal,
    Hard
}