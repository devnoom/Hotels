﻿using Hotels.Domain.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Namaste> Namastes { get; set; }
        public DbSet<NamasteNumber> NamasteNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Namaste>().HasData(new Namaste
            {
                Id = 1,
                Name = "Namaste Tbilisi",
                Description = "Namaste tbilis one of the best hotel",
                ImgUrl = "https://placehold.co/600x400",
                Occupancy = 6,
                Price = 300,
                Sqft = 550,
            }, new Namaste
            {
                Id = 2,
                Name = "Namaste Batumi",
                Description = "Namaste Batumi one of the best hotel",
                ImgUrl = "https://placehold.co/600x401",
                Occupancy = 8,
                Price = 400,
                Sqft = 650,
            },new Namaste
            {
                Id = 3,
                Name = "Namaste Yazbegi",
                Description = "Namaste Yazbegi one of the best hotel",
                ImgUrl = "https://placehold.co/600x402",
                Occupancy = 12,
                Price = 700,
                Sqft = 850,
            });

            modelBuilder.Entity<NamasteNumber>().HasData(
                new NamasteNumber
                {
                    Namaste_Number = 101,
                    NamasteId = 15,
                },new NamasteNumber
                {
                    Namaste_Number = 102,
                    NamasteId = 15,
                }, new NamasteNumber
                {
                    Namaste_Number = 103,
                    NamasteId = 15,
                }, new NamasteNumber
                {
                    Namaste_Number = 201,
                    NamasteId = 16,
                }, new NamasteNumber
                {
                    Namaste_Number = 202,
                    NamasteId = 16,
                }, new NamasteNumber
                {
                    Namaste_Number = 203,
                    NamasteId = 16,
                }, new NamasteNumber
                {
                    Namaste_Number = 301,
                    NamasteId = 17,
                }, new NamasteNumber
                {
                    Namaste_Number = 302,
                    NamasteId = 17,
                }, new NamasteNumber
                {
                    Namaste_Number = 303,
                    NamasteId = 17,
                }


                );
        
        }
    }
}
