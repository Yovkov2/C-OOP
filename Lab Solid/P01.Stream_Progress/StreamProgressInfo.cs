namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private readonly IStream stream;

        private File file;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStream stream)
        {
            this.stream = stream;
        }

        public double CalculateCurrentPercent()
        {
            return (double)this.stream.BytesSent / this.stream.Length * 100;
        }
    }
}
