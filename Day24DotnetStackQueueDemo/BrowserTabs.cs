public class BrowserTabs
{
    private int position;
    public int Position
    {
        get { return position; }
        private set { position = value; }
    }
    
    private string title;
    public string Title
    {
        get { return title; }
        private set { title = value; }
    }
    
    public BrowserTabs(int position, string title)
    {
        Position = position;
        Title = title;
    }

    public override string ToString()
    {
        return $"Position: {position} - {title}";
    }
}