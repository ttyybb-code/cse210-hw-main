public class Refrence
{
    private string _book;
    private string _refrenceStart;
    private string _refrenceEnd;
    private string _chapter;

    public Refrence(string book, string chapter, string verce)
    {
        _book = book;
        _refrenceStart = verce;
        _chapter = chapter;
        _refrenceEnd = verce;
    }

    public Refrence(string book, string chapter, string verceStart, string verceEnd)
    {
        _book = book;
        _chapter = chapter;
        _refrenceStart = verceStart;
        _refrenceEnd = verceEnd;
    }

    public void show()
    {
        if (_refrenceStart == _refrenceEnd)
        {
            Console.Write($"{_book}: {_refrenceStart} ");
        }
        else
        {
            Console.Write($"{_book}: {_refrenceStart} - {_refrenceEnd} ");
        }
    }
}