using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;

namespace PlaylistBackend
{
    public class Room
    {

        public string Url { get;}
        private List<Song> _songQueue = new List<Song>();
        private List<Song> _history = new List<Song>();

        public Room(string url)
        {
            Url = url;
        }

        
        public bool AddSong(string url)
        {
            if (ValidSong(url))
            {
                _songQueue.Add(new Song(url));
                return true;
            }
            else
                return false;
        }

        public bool NextSong()
        {
            if (_songQueue.Count > 0)
            {
                _history.Add(_songQueue.First());
                _songQueue.RemoveAt(0);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpvoteSong(string url, string userId)
        {
            if (SongExists(url))
            {
                _songQueue.Find(x => x.Url == url).Votes.Add(userId);
                return true;
            }
            else
                return false;
        }
        
        public bool VoteToSkip(string url, string userId)
        {
            if (SongExists(url))
            {
                _songQueue.Find(x => x.Url == url).VotesToSkip.Add(userId);
                return true;
            }
            else
                return false;
        }

        bool ValidSong(string url)
        {
            return true;
        }
        
        bool SongExists(string url)
        {
            return _songQueue.All(x => x.Url == url);
        }
        
        
    }
}