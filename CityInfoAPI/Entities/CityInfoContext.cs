﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CityInfoAPI.Entities
{
    public class CityInfoContext : DbContext
    {

        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterests { get; set; }


    }
}