namespace MainApp;

public class GuessEvaluator
{
    private int _guessCount;

    public enum GuessResult
    {
        TooLow,
        TooHigh,
        Correct
    }
    public static GuessResult CheckGuess(int secretNumber, int guess)
    {
        if (guess > secretNumber) return GuessResult.TooHigh;

        if (guess < secretNumber) return GuessResult.TooLow;

        else return GuessResult.Correct;

    }

    public int GetGuessCount()
    {
        _guessCount++;
        return _guessCount;
    }
}
