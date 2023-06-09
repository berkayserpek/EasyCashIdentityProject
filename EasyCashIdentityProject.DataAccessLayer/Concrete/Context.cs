﻿using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NJJC3PI;user=sa;password=berkay345..;initial catalog=EasyCashDB");
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountProcess> AccountProcesses { get; set; }
    }
}
