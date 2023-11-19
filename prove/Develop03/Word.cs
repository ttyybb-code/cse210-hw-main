using System.Net;

public class Word
{
    private bool _isHidden = false;
    private string _text;
    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public void ShowText()
    {
        if (_isHidden)
        {
            Console.Write("______ ");
        }
        else
        {
            Console.Write($"{_text} ");
        }
    }

}
