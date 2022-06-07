namespace StreamingContent_Repository;

// ! DERIVED "child" class
public class Movie : StreamingContent
{
    // * INHERITED PROPERTIES FROM "StreamingContent" class:
    // Title
    // Description
    // StarRating
    // Rating
    // TypeOfGenre
    public Movie() : base()
    {

    }
    public Movie(string title, string description, double starRating, MaturityRating rating, GenreType typeOfGenre, double runTime, string director) : base(title, description, starRating, rating, typeOfGenre)
    {
        RunTimeHours = runTime;
        Director = director;
    }

    public double RunTimeHours { get; set; }
    public string Director { get; set; }
}