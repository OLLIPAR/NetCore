﻿using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    public class AddDbContent : DbContext
    {
        public AddDbContent(DbContextOptions<AddDbContent> options) : base(options) { }
        public DbSet<Car>Car{get; set;}
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
    }
}
