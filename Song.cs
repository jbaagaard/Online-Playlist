namespace PlaylistBackend
{
    public class Song
    {
        public Song(string url)
        {
            Url = url;
            VotesToSkip = 0;
            Votes = 0;
            Skipped = false;
        }

        public string Url;
        public int Votes;
        public bool Skipped;
        public int VotesToSkip;
    }
}