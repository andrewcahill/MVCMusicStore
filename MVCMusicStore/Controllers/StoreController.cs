using MVCMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello from Store.Index()";
        }

        public string Browse(string genre)
        {
            // sanitize user input - case of scripting
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;

            //var albums = new List<Album>();

            //for (int i = 0; i < 10; i++)
            //{
            //    albums.Add(new Album { Id = i, Name = "Album " + i });
            //}

            //return View(albums);

        }

        public string Details(int id)
        {
            string message = "Hello from Store.Details, ID = " + id;
            return message;
        }
    }
}