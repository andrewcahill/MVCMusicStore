using MVCMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = "Index.";
            return View();
        }

        public ActionResult Action()
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
        public ActionResult Search(int q)
        {
            IEnumerable<Models.Album> models = null;

            if (ModelState.IsValid)
            {
                List<Models.Album> albums = new List<Models.Album>();

                for (int i = 0; i < 10; i++)
                {
                    albums.Add(new MVCMusicStore.Models.Album {
                        AlbumId = i,
                        ArtistId = i,
                        GenreId = i,
                        Price = 1,
                        Title = "Title " + i,
                        AlbumArtUrl="www.test.com",
                        Artist = new Models.Artist{ ArtistId = i, Name = "Artist " + i},
                        Genre = new Models.Genre{ Description = "Description " + i, GenreId = i, Name = "Name " + i, Albums  = null},
                         
                         });
                }

                models = from a in albums where a.AlbumId.Equals(q) select a;
            }

            return View(models);
        }

        public PartialViewResult _DailyDeal()
        {
            var album = GetDailyDeal();

            return PartialView("_DailyDeal", album);
        }

        private Album GetDailyDeal()
        {
            MusicStoreDB md = new MusicStoreDB();
            return md.Albums.OrderBy(a => a.Price).First();
        }
    }
}