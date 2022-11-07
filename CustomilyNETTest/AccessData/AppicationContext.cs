using CustomilyNETTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomilyNETTest.AccessData
{
    [DbConfigurationType(typeof(NpgSqlConfiguration))]
    public class AppicationContext : DbContext
    {
        public AppicationContext() : base("name=AppicationContext") { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Texts> Texts { get; set; }

    }
}