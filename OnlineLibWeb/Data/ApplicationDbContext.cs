using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineLibWeb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineLibWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<CategoryDocument> Categories_Documents { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
    }
}
