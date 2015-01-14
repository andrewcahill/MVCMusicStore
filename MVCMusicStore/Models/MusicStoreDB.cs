using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models
{
    public class MusicStoreDB : DbContext
    {
        public DbSet<Models.Album> Albums { get; set; }

        public DbSet<Models.Artist> Artists { get; set; }

        public DbSet<Models.Genre> Genres { get; set; }
    }
}