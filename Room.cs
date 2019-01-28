using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PlaylistBackend
{
    public class Room
    {

        public string Url { get;}
        public List<Song> SongQueue = new List<Song>();
        public List<Song> History = new List<Song>();

        public Room(string url)
        {
            Url = url;
        }
    }
}