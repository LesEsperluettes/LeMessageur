using Le_Messageur.Data;
using Le_Messageur.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Le_Messageur.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MessageController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MessageController/Create
        [HttpPost]
        [Route("message/create_message")]
        public ActionResult Create(string contenu_message)
        {
            if(User.Identity.IsAuthenticated == false)
            {
                return Unauthorized();
            }

            Message message = new Message();
            message.message = contenu_message;
            message.user = User.Identity.Name;
            message.date_envoi = DateTime.Now;

            _context.Messages.Add(message);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
