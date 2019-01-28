using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistBackend
{
    class Program
    {
        static Server _server = new Server();
        static async Task Main(string[] args)
        {
            Console.WriteLine("Add room" + RoomManager.AddRoom(new Room("room")));
            var testRoom = RoomManager.GetRoom("room");
            testRoom.AddSong("https://youtu.be/HNZLTMqCdf4");
            testRoom.AddSong("https://youtu.be/3A8_sP--cQU");
            Console.WriteLine(testRoom.NextSong());
            
            
            await _server.RunServer();
        }
    }
}