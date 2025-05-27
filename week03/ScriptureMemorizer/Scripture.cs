public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random rand = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public int HideRandomWords(int numberToHide)
    {
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }

        }

        int toHide = Math.Min(numberToHide, visibleIndexes.Count);

        for (int i = 0; i < toHide; i++)
        {
            int randomIndex = rand.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randomIndex];
            _words[wordIndex].Hide();
            visibleIndexes.RemoveAt(randomIndex);
        }
        return toHide;
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }
        return display.Trim();
    }

    public bool IsCompleteyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
