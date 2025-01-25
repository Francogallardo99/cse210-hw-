public class ScriptureWord
{
    public string Word { get; private set; }
    public bool IsHidden { get; private set; }

    public ScriptureWord(string word)
    {
        Word = word;
        IsHidden = false;
    }

    public string GetDisplayedWord()
    {
        return IsHidden ? new string('_', Word.Length) : Word;
    }

    public void HideWord()
    {
        IsHidden = true;
    }
}
