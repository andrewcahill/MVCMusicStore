using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //ViewData["Message"] = "ViewData.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Search(int id)
        {
            IEnumerable<Models.Album> models = null;




            if (ModelState.IsValid)
            {

                List<Models.Album> albums = new List<Models.Album>();

                for (int i = 0; i < 10; i++)
                {
                    //albums.Add(new MVCMusicStore.Models.Album { AlbumId = i, Name = "Name " + i });
                }

                models = from a in albums where a.AlbumId.Equals(id) select a;
            }

            return View(models);
        }
    }
}