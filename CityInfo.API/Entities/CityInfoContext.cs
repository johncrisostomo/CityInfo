﻿using System;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Entities
{
    public class CityInfoContext : DbContext
    {

        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<City> Cities { get; set; }

        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        //protected override void onConfiguring(CityInfoContext instance, DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connectionstring");

        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
