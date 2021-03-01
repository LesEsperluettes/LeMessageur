using Le_Messageur.Data;
using Le_Messageur.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Le_Messageur.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string username)
        {
            var messages = _context.Messages.OrderByDescending(m => m.date_envoi).ToList();

            var messages_user = new List<Message>();

            foreach(var message in messages)
            {
                if (message.user.Split("@")[0].Equals(username))
                {
                    messages_user.Add(message);
                }
            }

            ViewBag.Username = username;
            ViewBag.Messages = messages_user;
            return View();
        }
    }
}
