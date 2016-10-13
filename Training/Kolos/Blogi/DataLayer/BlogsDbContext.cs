﻿using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
	public class BlogsDbContext : DbContext
	{
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<UserAddress> UserAddresses { get; set; }
	}
}