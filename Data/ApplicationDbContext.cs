using AutoMapper.Configuration;
using capstone.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.Data
{

    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public IConfiguration Configuration { get; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<BillBoardMusicListMember> BillBoardMusicListMembers { get; set; }
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }

        public ApplicationDbContext() : base(new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite("Data Source=app.db").Options,null)
        {
               
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<BillBoardMusicListMember>()
            .HasData(
                new BillBoardMusicListMember 
                { 
                    Id = 1, Artist = "Real McCoy",
                    Song = "Another night", 
                    Duration = "1995", 
                    Genre = "Eurodance", 
                    Membersince = new DateTime(1993, 07, 12),
                    IsActiveMember = true
                    },
                    new BillBoardMusicListMember 
                    {
                       Id = 2, Artist = "Boyz 2 Men",
                       Song = "I'll Make Love to You",
                       Duration = "1995", 
                       Genre = "R&B", 
                       Membersince = new DateTime(1994, 07, 26),
                       IsActiveMember = true
                      },
                      new BillBoardMusicListMember
                      {
                          Id = 3, Artist = "All for one",
                          Song = "I can love you like that",
                          Duration = "1995",
                          Genre = "R&B", 
                          Membersince = new DateTime(1995, 02, 27),
                          IsActiveMember = true
                      },
                      new BillBoardMusicListMember
                      {
                         Id = 4, Artist = "Blessed Union of Souls",
                         Song = "I believe",
                         Duration = "1995", 
                         Genre = "Alternative Rock", 
                         Membersince = new DateTime(1995, 02, 18),
                         IsActiveMember = true
                      },
                      new BillBoardMusicListMember
                      {
                         Id = 5, Artist = "Melissa Etheridge",
                         Song = "I'm the Only One",
                         Duration = "1995", 
                         Genre = "Rock", 
                         Membersince = new DateTime(1993, 09, 21),
                         IsActiveMember = true
                      },
                      new BillBoardMusicListMember
                      {
                         Id = 6, Artist = "4 P.M.",
                         Song = "Sukiyaki",
                         Duration = "1995", 
                         Genre = "Pop", 
                         Membersince = new DateTime(1994, 09, 06),
                         IsActiveMember = true
                      },
                      new BillBoardMusicListMember
                      {
                         Id = 7, Artist = "Groove Theory",
                         Song = "Tell Me",
                         Duration = "1995", 
                         Genre = "R&B", 
                         Membersince = new DateTime(1995, 09, 05),
                         IsActiveMember = true
                      }
                      );
                 base.OnModelCreating(builder);
        }
    }
}
