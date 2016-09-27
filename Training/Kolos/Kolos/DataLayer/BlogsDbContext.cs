using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DataLayer.Conventions;
using DataLayer.Initialiazer;
using DataLayer.Models;

namespace DataLayer
{
	public class BlogsDbContext : DbContext
	{
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<UserAdress> UserAddresses { get; set; }

		public BlogsDbContext() : base()
		{
			Database.SetInitializer(new BlogDbInitializer());
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Add<CustomTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}
	}
}
