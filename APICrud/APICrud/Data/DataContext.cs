﻿using APICrud.Models;
using Microsoft.EntityFrameworkCore;

namespace APICrud.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Products> Products { get; set; }
    }
}
