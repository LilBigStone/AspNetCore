using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ProjectApplication.Hub
{
    
    public class ChatHub : Microsoft.AspNetCore.SignalR.Hub
    {
        public Task JoinRoom(string roomId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, roomId);
        }

        public Task LeaveRoom(string roomId)
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, roomId);
        }
    }
 
}