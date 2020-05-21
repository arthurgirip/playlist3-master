using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace playlistgenerator.Models
{
    public class DBContext : DbContext
    {

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Playlist> Playlists { get; set; }

        //protected override void OnModelCreating(DbModelBuilder)

    }

    public class configMe : IEntityTypeConfiguration<Song>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Song> builder)
        {
            throw new NotImplementedException();
        }
    }
}
