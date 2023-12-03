public class Comment
{
    private string _Author;
    private string _Comment;

    public Comment(string Author, string Comment)
    {
        _Author = Author;
        _Comment = Comment;
    }
    public string GetComment()
    {
        return _Comment;
    }

    public string GetAuthor()
    {
        return _Author;
    }
}