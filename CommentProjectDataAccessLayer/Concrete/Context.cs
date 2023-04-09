using CommentProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CommentProjectDataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-L7LL5EMD;initial catalog =DbComment; integrated security=true;");
        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
