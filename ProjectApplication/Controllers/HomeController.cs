using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectApplication.Data.Interfaces;
using ProjectApplication.Data.Models;
using ProjectApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using ProjectApplication.Data;
using ProjectApplication.Hub;
using ProjectApplication.Models;

namespace ProjectApplication.Controllers
{
    public class HomeController: Controller
    {
        private appDBcontent db;
        private UserManager<UserModel> _userManager;
        private readonly IAllMilks _milkRep;
        public HomeController(appDBcontent context, UserManager<UserModel> userManager, IAllMilks milkRep)
        {
            _milkRep = milkRep;
            db = context;
            _userManager = userManager;
            
        }

        public ViewResult Index()
        {
            var homeMilks = new HomeViewModel
            {
                favMilks=_milkRep.getFavMilks
            };
            return View(homeMilks);
        }

        public ViewResult Production()
        {
            return View();
        }
        
        [Authorize]
        public async Task<IActionResult> SendMessage(int roomId, string message, [FromServices] IHubContext<ChatHub> chat)
        {
            var Message = new Comment()
            {
               message = message,
               MilkProdId = roomId,
               owner = _userManager.GetUserAsync(User).Result.Email
            };
            
            await db.Comments.AddAsync(Message);
            await db.SaveChangesAsync();
            await chat.Clients.Group(roomId.ToString()).SendAsync("RecieveMessage", new
            {
                Text = Message.message,
                Name = Message.owner,
            });

            return Ok();
        }
    }
}
