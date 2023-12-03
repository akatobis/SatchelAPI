﻿using System.Drawing;
using Microsoft.EntityFrameworkCore;
using Satchel.Application.Models;

namespace Satchel.Infrastructure;

public class SatchelDbContext : DbContext
{
    public SatchelDbContext(DbContextOptions<SatchelDbContext> options)
        : base(options)
    {
    }

    public DbSet<BrandType> BrandTypes { get; set; }
    public DbSet<Favourites> Favourites { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<GenderType> GenderTypes { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderStatusType> OrderStatusTypes { get; set; }
    public DbSet<PaymentType> PaymentTypes { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }
    public DbSet<ShippingType> ShippingTypes { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<SizeType> SizeTypes { get; set; }
    public DbSet<SizeTypeToProductType> SizeTypeToProductTypes { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<UserType> UserTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}