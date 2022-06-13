﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Assignment2.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("name=Tickets")
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}






