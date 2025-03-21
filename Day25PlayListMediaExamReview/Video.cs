public class Video
{
    public string Title { get; }
    public string Duration { get; }
    public string Category { get; }

    public Video(string title, string duration, string category)
    {
        Title = title;
        Duration = duration;
        Category = category;
    }

    public override string ToString()
    {
        return $"{Title},{Category},{Duration} minutes";
    }
}