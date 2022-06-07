// ! REPOSITORY PATTERN: TESTING ex:
using Xunit;
using StreamingContent_Repository;

namespace StreamingContent_Tests;

public class StreamingContentTests
{
    [Fact]
    public void IsFamilyFriendlyAccurate()
    {
        // Arrange
        // Act
        StreamingContent scarfaceEx = new StreamingContent("Scarface", "Cuban immigrant comes to Miami and takes over the drug game.", 4.6, MaturityRating.R, GenreType.Thriller);

        // Assert
        // Assert.Equal(expected, actual)
        bool expected = false;
        bool actual = scarfaceEx.IsFamilyFriendly;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TitleShouldSetCorrectString()
    {
        StreamingContent betterCallSaulEx = new StreamingContent("Better Call Saul", "Lawyer turns to criminal lawyer!!!", 5.0, MaturityRating.R, GenreType.Drama);

        // * should fail
        string expected = "better call saul";
        string actual = betterCallSaulEx.Title;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldAddContentToDirectory()
    {
        // Arrange
        StreamingContentRepository repository = new StreamingContentRepository();
        StreamingContent betterCallSaulEx = new StreamingContent("Better Call Saul", "Lawyer turns to criminal lawyer!!!", 5.0, MaturityRating.R, GenreType.Drama);

        // Act
        repository.AddContentToDirectory(betterCallSaulEx);

        // Assert
        int expected = 1;
        int actual = repository._contentDirectory.Count;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldGetContentBasedOnTitle()
    {
        // Arrange
        StreamingContentRepository repository = new StreamingContentRepository();
        StreamingContent scarfaceEx = new StreamingContent("Scarface", "Cuban immigrant comes to Miami and takes over the drug game.", 4.6, MaturityRating.R, GenreType.Thriller);

        // Act
        repository.AddContentToDirectory(scarfaceEx);

        // Assert
        string expected = "Scarface";
        string actual = repository.GetContentByTitle("Scarface").Title;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldUpdateContentBasedOnTitle()
    {
        // Arrange
        StreamingContentRepository repository = new StreamingContentRepository();
        StreamingContent scarfaceEx = new StreamingContent("Scarface", "Cuban immigrant comes to Miami and takes over the drug game.", 4.6, MaturityRating.R, GenreType.Thriller);

        // Act
        repository.AddContentToDirectory(scarfaceEx);

        StreamingContent newContent = new StreamingContent("Finding Nemo", "A father loses touch with his son and goes on a journey of rediscovery", 5, MaturityRating.G, GenreType.Drama);

        // Assert
        bool expected = true;
        bool actual = repository.UpdateExistingContent("Scarface", newContent);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldUpdateContentAndShowNewTitle()
    {
        // Arrange
        StreamingContentRepository repository = new StreamingContentRepository();
        StreamingContent scarfaceEx = new StreamingContent("Scarface", "Cuban immigrant comes to Miami and takes over the drug game.", 4.6, MaturityRating.R, GenreType.Thriller);

        // Act
        repository.AddContentToDirectory(scarfaceEx);

        StreamingContent newContent = new StreamingContent("Finding Nemo", "A father loses touch with his son and goes on a journey of rediscovery", 5, MaturityRating.G, GenreType.Drama);

        repository.UpdateExistingContent("Scarface", newContent);

        // Assert
        string expected = "Finding Nemo";
        string actual =  repository.GetContentByTitle("Finding Nemo").Title;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldDeleteContent()
    {
        // Arrange
        StreamingContentRepository repository = new StreamingContentRepository();
        StreamingContent scarfaceEx = new StreamingContent("Scarface", "Cuban immigrant comes to Miami and takes over the drug game.", 4.6, MaturityRating.R, GenreType.Thriller);

        // Act
        repository.AddContentToDirectory(scarfaceEx);

        // Assert
        bool expected = true;
        bool actual =  repository.DeleteExistingContent("Scarface");

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MovieTest()
    {
        Movie trainingDay = new Movie("Training Day", "denzel corrupts a solid training officer", 4.6, MaturityRating.R, GenreType.Drama, 2.02, "Antoine Fuqua");

        string expected = "Training Day: directed by Antoine Fuqua";
        string actual = $"{trainingDay.Title}: directed by {trainingDay.Director}";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShowTest()
    {
        Show regularShow = new Show("Regular Show", "mordecai and rigby slack off and go on adventures", 5, MaturityRating.PG13, GenreType.Action, 16);

        string expected = "Regular Show: avg run time is 16 mins";
        string actual = $"{regularShow.Title}: avg run time is {regularShow.AvgRunTimeMins} mins";

        Assert.Equal(expected, actual);
    }
}