const string MOVIES_FILE_PATH = "movies.txt";
const string STACK_FILE_OUTPUT_PATH = "stack_results.txt";
const string QUEUE_FILE_OUTPUT_PATH = "queue_results.txt";

IPlayListMedia<Video> playListMediaStack = new PlayListMediaStack<Video>();
IPlayListMedia<Video> playListMediaQueue = new PlayListMediaQueue<Video>();

if(File.Exists(MOVIES_FILE_PATH))
{
    StreamReader reader = new(MOVIES_FILE_PATH);
    bool skipHeader = true;

    while(!reader.EndOfStream) 
    {
        if(skipHeader)
        {
            skipHeader = false;
            continue;
        }

        string[] movieInfo = reader.ReadLine().Split(",");
        Video video = new Video(movieInfo[0], movieInfo[1], movieInfo[2]);
        
        playListMediaStack.Add(video);
        Console.WriteLine($"Added {video} to the stack");

        playListMediaQueue.Add(video);
        Console.WriteLine($"Added {video} to the queue");

        Console.WriteLine();
    }

    reader.Close();
    Console.WriteLine("All video(s) are loaded in the stack and queue playlists\n");

    StreamWriter writer = new(STACK_FILE_OUTPUT_PATH);
    writer.WriteLine("Stack\n===============");
    for(int i = 0; i < playListMediaStack.GetTotalMedia(); i++)
    {
        writer.WriteLine($"Next: {playListMediaStack.ShowNextMedia()}");
        writer.WriteLine($"Play: {playListMediaStack.Play()}");
    }

    writer.Close();

    StreamWriter queueWriter = new(QUEUE_FILE_OUTPUT_PATH);
    queueWriter.WriteLine("Queue\n===============");
    for(int i = 0; i < playListMediaQueue.GetTotalMedia(); i++)
    {
        queueWriter.WriteLine($"Next: {playListMediaQueue.ShowNextMedia()}");
        queueWriter.WriteLine($"Play: {playListMediaQueue.Play()}");
    }

    queueWriter.Close();
}
else
{
    Console.WriteLine($"Could not locate file path {MOVIES_FILE_PATH}");
}