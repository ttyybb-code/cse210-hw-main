public class Scripture
{
    private List<Word> _words = new List<Word>();
    private List<int> _usedIndex = new List<int>();

    public void addWord(Word word)
    {
        _words.Add(word);
    }

    public void hideWords()
    {
        Random random = new Random();
        for (int i = 0; i<3; i++ )
        {
            int randomIndex;
            do
            {randomIndex = random.Next(0, _words.Count);
            } while (_usedIndex.Contains(randomIndex));
            Word word = _words[randomIndex];
            word.Hide();
            _usedIndex.Add(randomIndex);
        }
    }

    public void Show(Refrence refrence)
    {
        Console.Clear();
        refrence.show();
        for (int i = 0; i< _words.Count; i ++)
        {
            Word word = _words[i];
            word.ShowText();
        }
        
    }
}