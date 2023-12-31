﻿using Microsoft.EntityFrameworkCore;

using Sample.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Infrastructure
{
    public class MovieDBContext: DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options): base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}
