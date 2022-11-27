using HomeWork_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_2.Controllers
{
    public class FriendController : Controller
    {
        List<Friend>  Friends;
        
        String StateObject = "";
        
        public IActionResult Index()
        {
            Friends = new List<Friend>
            {
                new Friend() { FriendId = 1, FriendName = "User 1", Place = "close friend"},
                new Friend() { FriendId = 1, FriendName = "User 2", Place = "close friend"},
                new Friend() { FriendId = 1, FriendName = "User 3", Place = "Making friend"},

            };
            
            return View(Friends);
        }

        public IActionResult Create()
        {
            return View();
        }

       
        public IActionResult Edit(Friend friend)
        {
            return View(friend);
        }

        [HttpPost]
        public string SaveChangeFriend(Friend friend)
        {
            //change item in bd
            StateObject = "Object was has saved";
            return StateObject;
        }
        [HttpGet]
        public IActionResult Delete(Friend friend)
        {
            return View(friend);
        }
        
    }
}
