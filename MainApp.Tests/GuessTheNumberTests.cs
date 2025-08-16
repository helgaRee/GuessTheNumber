namespace MainApp.Tests;

public class GuessTheNumberTests
{

    //Skriv ett test som beskriver vad vi vill att koden ska göra, men som just nu inte kan passera


    //Om det slumpade talet är 42 och jag gissar 50 ska resultatet vara "För högt".
    //Hur ska metoden heta?

    //Vilka parametrar behöver den ta emot?

    //Vilken datatyp ska den returnera? (Text? Enum?)


    //Metoden ska jämföra användarens gissning med det hemliga talet.
    // vilka möjliga utfall? för högt, för lågt och rätt.
    //ska returnera en string
    //metoden ska jämföra det hemliga värdet + gissningen

    //EX: Det hemliga talet är 42 och gissningen är 50, ska resultatet vara för högt.
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
}
