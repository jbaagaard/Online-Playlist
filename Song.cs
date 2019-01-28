namespace PlaylistBackend
{
    public class Song
    {
        public string Url { get; set; }
        public int Votes{ get; set; }
        public bool Skipped { get; set; }
    }
}