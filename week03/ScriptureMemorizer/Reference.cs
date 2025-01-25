public class Reference
{
    public string Book { get; private set; }
    public int StartChapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    public Reference(string book, int startChapter, int startVerse, int? endVerse = null)
    {
        Book = book;
        StartChapter = startChapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse.HasValue
            ? $"{Book} {StartChapter}:{StartVerse}-{EndVerse}"
            : $"{Book} {StartChapter}:{StartVerse}";
    }
}