// ! REPOSITORY PATTERN: REPOSITORY ex:
// "repositries" are used for implementing CRUD (create, read, update, delete) methodologies 
// for interacting with data source (database)

namespace StreamingContent_Repository;

public class StreamingContentRepository
{
    public readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

    // CREATE
    public void AddContentToDirectory(StreamingContent content)
    {
        _contentDirectory.Add(content);
    }

    // READ - allows you to view content of "database"
    public List<StreamingContent> GetAllContent()
    {
        return _contentDirectory;
    }

    public StreamingContent GetContentByTitle(string title)
    {
        // .Find() docs:
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=net-6.0
        return _contentDirectory.Find(content => content.Title == title);
    }
    // can build out get by rating
    // can build out get by genre
    // can build out get by family friendly
        
    // UPDATE
    public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
    {
        StreamingContent contentToUpdate = GetContentByTitle(originalTitle);

        // "default" keyword will return default value of whatever type being compared
        if (contentToUpdate != default)
        {
            contentToUpdate.Title = newContent.Title;
            contentToUpdate.Description = newContent.Description;
            contentToUpdate.StarRating = newContent.StarRating;
            contentToUpdate.Rating = newContent.Rating;
            contentToUpdate.TypeOfGenre = newContent.TypeOfGenre;
            return true;
        } else
        {
            return false;
        }
    }

    // DELETE
    public bool DeleteExistingContent(string title)
    {
        StreamingContent contentToDelete = GetContentByTitle(title);

        // "default" keyword will return default value of whatever type being compared
        if (contentToDelete != default)
        {
            return _contentDirectory.Remove(contentToDelete);
        } else
        {
            return false;
        }
    }
}