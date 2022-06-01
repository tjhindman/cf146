// ! REPOSITORY PATTERN: POCO (Plain Old C# Object) ex:
namespace StreamingContent_Repository;

// POCO = "Plain Old C# Object" for data blueprint
// Streaming Content POCO:
public class StreamingContent
{
    public StreamingContent()
    {

    }
    public StreamingContent(string title, string description, double starRating, MaturityRating rating, GenreType typeOfGenre)
    {
        Title = title;
        Description = description;
        StarRating = starRating;
        Rating = rating;
        TypeOfGenre = typeOfGenre;
    }
    // title
    public string Title { get; set; }
    // description
    public string Description { get; set; }
    // star rating
    public double StarRating { get; set; }
    // maturity rating
    public MaturityRating Rating { get; set; }
    // genre type
    public GenreType TypeOfGenre { get; set; }
    // is family friendly?
    public bool IsFamilyFriendly {
        get {
            switch (Rating)
            {
                case MaturityRating.G:
                case MaturityRating.PG:
                    return true;
                default:
                    return false;
            }
    } 
    }
}

public enum MaturityRating
{
    G,
    PG,
    PG13,
    R
}
public enum GenreType {
    Horror,
    Western,
    Documentary,
    Thriller,
    Action,
    SciFi,
    Drama,
    RomCom
}
