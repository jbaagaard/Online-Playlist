using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public bool AddSong(string url)
        {
            if (validSong(url))
            {
                SongQueue.Add(new Song(url));
                return true;
            }
            else
                return false;
        }

        public bool validSong(string url)
        {
            return true;
        }
        
        
    }
}