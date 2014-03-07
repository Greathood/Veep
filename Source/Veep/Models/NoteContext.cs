using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Veep.Models
{
    public class NoteContext : DbContext
    {
        public DbSet<Note> Note { get; set; }
    }
}