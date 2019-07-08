using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KharkivPhotoes.Entities;

namespace KharkivPhotoes.DB
{
    public class PicturesContext : DbContext
    {
        public PicturesContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<PictureType> PictureTypes { get; set; }
    }
}
