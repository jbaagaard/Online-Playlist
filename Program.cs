using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlaylistBackend
{
    class Program
    {
        static Server _server = new Server();
        static async Task Main(string[] args)
        {
            Console.WriteLine(RoomManager.AddRoom(new Room("room")));
            Console.WriteLine(RoomManager.AddRoom(new Room("room")));
            var testRoom = RoomManager.GetRoom("room");
            var testRoom2 = RoomManager.GetRoom("room2");
                   
            
            
            await _server.RunServer();
        }
    }
}