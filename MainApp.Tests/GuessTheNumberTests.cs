namespace MainApp.Tests;

public class GuessTheNumberTests
{

    [Fact]
    public void GuessHigherThanSecretNumber_ShouldReturnTooHigh()
    {

        //Arrange
        int secretNumber = 37;
        int guess = 66;

        //Act - anropa metoden, skicka in värden och spara resuktatet i variabel
        GuessEvaluator.GuessResult result = GuessEvaluator.CheckGuess(secretNumber, guess);


        //Assert
        Assert.Equal(GuessEvaluator.GuessResult.TooHigh, result);
        Console.WriteLine(result + "testar");
    }

    [Fact]
    public void GuessLowerThanSecretNumber_ShouldReturnTooLow()
    {
        //arrange
        int secretNumber = 89;
        int guess = 10;


        //act - metoden som ger ett resultat
        GuessEvaluator.GuessResult result = GuessEvaluator.CheckGuess(secretNumber, guess);

        //assert
        Assert.Equal(GuessEvaluator.GuessResult.TooLow, result);


    }

    [Fact]

    public void GuessCorrectSecretNumber_ShouldReturnCorrect()
    {
        //arrange
        int secretNumber = 50;
        int guess = 50;

        //act - get result
        GuessEvaluator.GuessResult result = GuessEvaluator.CheckGuess(secretNumber, guess);

        //assert
        Assert.Equal(GuessEvaluator.GuessResult.Correct, result);
    }

    //förväntat utfall: 
    [Fact]
    public void CountGuesses_ShouldReturn3()
    {
        //arrange
        GuessEvaluator guessEvaluator = new GuessEvaluator();

        //act
        guessEvaluator.GetGuessCount();
        guessEvaluator.GetGuessCount();
        int result = guessEvaluator.GetGuessCount();

        //assert
        Assert.Equal(3, result);
    }
}
