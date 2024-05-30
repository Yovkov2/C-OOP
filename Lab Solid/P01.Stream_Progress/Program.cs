using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            IStream fileStream = new File("example.txt", 1000, 200);
            StreamProgressInfo fileProgress = new StreamProgressInfo(fileStream);
            Console.WriteLine($"File progress: {fileProgress.CalculateCurrentPercent()}%");

            IStream musicStream = new Music("Artist", "Album", 1000, 500);
            StreamProgressInfo musicProgress = new StreamProgressInfo(musicStream);
            Console.WriteLine($"Music progress: {musicProgress.CalculateCurrentPercent()}%");
        }
    }
}
