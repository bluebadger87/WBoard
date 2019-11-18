using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBoard.Models;

namespace WBoard.DataContext
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options) { }
        public DbSet<Note> Notes { get; set; }
        public DbSet<NoteComment> NoteComments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
