
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using RentSite.Models;

namespace RentSite.Models
{
    public class RentContext : DbContext
    {
        public DbSet<Item> items { get; set; }
    }
}