using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PlaylistBackend
{
    public static class RoomManager
    {
        public static List<Room> Rooms = new List<Room>();

        public static bool AddRoom(Room room)
        {
            if (CheckUrl(room.Url))
            {
                Rooms.Add(room);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        static bool CheckUrl(string url)
        {
            return Rooms.All(x => x.Url != url);
        }
        
    }
}