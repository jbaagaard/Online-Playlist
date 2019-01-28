using System.Collections.Generic;

namespace PlaylistBackend
{
    public class Song
    {
        public Song(string url)
        {
            Url = url;
            VotesToSkip = new List<string>();
            Votes = new List<string>();
            Skipped = false;
        }

        public string Url;
        public List<string> Votes;
        public bool Skipped;
        public List<string> VotesToSkip;
    }
}