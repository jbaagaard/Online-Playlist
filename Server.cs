using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading.Tasks;
using Red;

namespace PlaylistBackend
{
    public class Server
    {
        public async Task RunServer()
        {
            var server = new RedHttpServer(5000,"public")  {
                RespondWithExceptionDetails = true
            };
            
            server.Post("/api/create-room", async (req, res) =>
            {
                var form = await req.GetFormDataAsync();
                string url = form["url"];
                if (RoomManager.AddRoom(new Room(url)))
                {
                    await res.SendStatus(HttpStatusCode.Created);   
                }
                else
                {
                    
                    await res.SendStatus(HttpStatusCode.BadRequest);
                }
            });
            
            
            await server.RunAsync();
        }
    }
}