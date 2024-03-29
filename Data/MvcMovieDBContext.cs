using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

    public class MvcMovieDBContext : DbContext
    {
        public MvcMovieDBContext (DbContextOptions<MvcMovieDBContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }

        public DbSet<MvcMovie.Models.Test> Test { get; set; }

        public DbSet<MvcMovie.Models.Employee> Employee { get; set; }

        public DbSet<MvcMovie.Models.Person> Person { get; set; }

        public DbSet<MvcMovie.Models.Product> Product { get; set; }

        public DbSet<MvcMovie.Models.Student> Student { get; set; }
    }
