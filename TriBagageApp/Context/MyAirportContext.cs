﻿using System;
using Microsoft.EntityFrameworkCore;

namespace TriBagageApp.Context
{
    public class MyAirportContext: DbContext
    {
        public MyAirportContext()
        {
        }

        public DbSet<Bagage> Bagages { get; set; }

        public DbSet<Vol> Vols { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database=MyAirport.db");
        
    }
}
