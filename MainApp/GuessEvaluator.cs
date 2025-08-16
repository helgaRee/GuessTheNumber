namespace MainApp;

public class GuessEvaluator
{
    public static string CheckGuess(int secretNumber, int guess)
    {
        //If guess > secret = return “För högt”
        if (guess > secretNumber)
        {
            return "För Högt";
        }
        else if (guess < secretNumber)
        {
            return "För Lågt";
        }
        else
        {
            return "Rätt";
        }

    }
}
