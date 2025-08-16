namespace MainApp;

public class GuessEvaluator
{
    public static string CheckGuess(int secretNumber, int guess)
    {
        if (guess > secretNumber)
        {
            return "För Högt";
        }
        if (guess < secretNumber)
        {
            return "För Lågt";
        }
        return "Rätt";
    }
}
