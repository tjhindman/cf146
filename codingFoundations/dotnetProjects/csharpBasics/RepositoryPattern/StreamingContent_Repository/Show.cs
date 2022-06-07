namespace StreamingContent_Repository;

// ! DERIVED "child" class
public class Show : StreamingContent
{
    // * INHERITED PROPERTIES FROM "StreamingContent" class:
    // Title
    // Description
    // StarRating
    // Rating
    // TypeOfGenre
    public Show() : base()
    {

    }
    public Show(string title, string description, double starRating, MaturityRating rating, GenreType typeOfGenre, double avgRunTimeMins) : base(title, description, starRating, rating, typeOfGenre)
    {
        AvgRunTimeMins = avgRunTimeMins;
    }

    public double AvgRunTimeMins { get; set; }
}