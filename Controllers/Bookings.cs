using Microsoft.AspNetCore.Mvc;
using C__Day_3_ASP.NET_MVC.Models;

namespace C__Day_3_ASP.NET_MVC.Controllers
{
    public class BookingsController : Controller
    {
        [HttpGet]
        public IActionResult Booking(string hall)
        {
            ViewBag.Hall = hall;
            return View();
        }

        [HttpPost]
        public IActionResult Booking(string hall, string name, string email)
        {
            var tickets = TicketsStore.Tickets;

            if (tickets[hall] > 0)
            {
                tickets[hall]--; // Scala un biglietto
                TempData["SuccessMessage"] = $"Booking confirmed for {hall}! Remaining tickets: {tickets[hall]}";
            }
            else
            {
                TempData["SuccessMessage"] = $"{hall} is sold out!";
            }

            return RedirectToAction("Conferma", "Home");
        }


    }
}
