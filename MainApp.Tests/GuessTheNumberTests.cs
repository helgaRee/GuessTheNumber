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
        string result = GuessEvaluator.CheckGuess(secretNumber, guess);


        //Assert
        Assert.Equal("För Högt", result);
        Console.WriteLine(result + "testar");
    }

    [Fact]
    public void GuessLowerThanSecretNumber_ShouldReturnTooLow()
    {
        //arrange
        int secretNumber = 89;
        int guess = 10;


        //act - metoden som ger ett resultat
        string result = GuessEvaluator.CheckGuess(secretNumber, guess);

        //assert
        Assert.Equal("För Lågt", result);


    }

    [Fact]

    public void GuessCorrectSecretNumber_ShouldReturnCorrect()
    {
        //arrange
        int secretNumber = 50;
        int guess = 50;

        //act - get result
        string result = GuessEvaluator.CheckGuess(secretNumber, guess);

        //assert
        Assert.Equal("Rätt", result);
    }

    //förväntat utfall: 
    [Fact]
    public void CountGuesses_ShouldReturn3()
    {
        //arrange
        GuessEvaluator guessEvaluator = new GuessEvaluator();

        //act
        guessEvaluator.CountGuesses();
        guessEvaluator.CountGuesses();
        int result = guessEvaluator.CountGuesses();

        //assert
        Assert.Equal(3, result);
    }
}
