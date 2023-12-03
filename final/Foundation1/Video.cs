public class Video
{
    private string _Title;
    private string _Author;
    private int _Length;
    private List<Comment> _Comments = new List<Comment>();

    public Video(string Title, string Author, int Length)
    {
        _Author = Author;
        _Title = Title;
        _Length = Length;
    }
    public string GetAuthor()
    {
        return _Author;
    }
    public string GetTitle()
    {
        return _Title;
    }
    public int GetLength()
    {
        return _Length;
    }
    public int GetNumberOfComments()
    {
        return _Comments.Count();
    }

    public void ShowAllComments()
    {
        foreach (Comment comment in _Comments)
        {
            Console.WriteLine($"{comment.GetAuthor()}: {comment.GetComment()}");
        }
    }
    public void AddComment(Comment comment)
    {
        _Comments.Add(comment);
    }
}