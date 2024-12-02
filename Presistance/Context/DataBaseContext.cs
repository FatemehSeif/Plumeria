using Application.Interfaces.Contexts;
using Domain;
using Domain.Attributes;
using Domain.Banners;
using Domain.Baskets;
using Domain.Catalogs;
using Domain.Discounts;
using Domain.Order;
using Domain.Payments;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Presistance.EntityConfigurations;
using Presistance.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presistance.Context
{
	public class DataBaseContext : DbContext , IDataBaseContext 
	{
		public DataBaseContext (DbContextOptions <DataBaseContext>options ) : base (options) 
		{
		}	

		public DbSet<Banner> Banners { get; set; }	
		public DbSet<Payment> Payments { get; set; }
		public DbSet<CatalogItemComment> CatalogItemComments { get; set; }
		public DbSet<CatalogBrand> CatalogBrands { get; set; }	 
		public DbSet<CatalogType> CatalogTypes { get; set; }	
		public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<Basket> Baskets { get; set; }	
		public DbSet<BasketItem> BasketItems { get; set; }	
        public DbSet<UserAddress> UserAddresses { get; set; }	
		public DbSet<Order> Orders { get; set; }	
		public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Discount> Discount { get; set; }
		public DbSet<DiscountUsageHistory> DiscountUsageHistories { get; set; }	
		public DbSet<CatalogItemFavourite> CatalogItemFavourites { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
		{
			foreach ( var EntityType in builder.Model.GetEntityTypes() ) 
			{
				if(EntityType.ClrType.GetCustomAttributes(typeof(AuditableAttribute),true) .Length > 0)
				{
					builder.Entity(EntityType.Name).Property<DateTime>("InsertTime").HasDefaultValue(DateTime.Now);
					builder.Entity(EntityType.Name).Property<DateTime?>("UpdateTime");
					builder.Entity(EntityType.Name).Property<DateTime?>("RemoveTime");
					builder.Entity(EntityType.Name).Property<bool>("IsRemoved").HasDefaultValue(false);


				}
			}
			builder.Entity<CatalogType>()
			  .HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);
            builder.Entity<BasketItem>()
               .HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);
            builder.Entity<Basket>()
                .HasQueryFilter(m => EF.Property<bool>(m, "IsRemoved") == false);




            builder.ApplyConfiguration(new CatalogBrandEntityTypeConfiguration());
			builder.ApplyConfiguration(new CatalogTypeEntityTypeConfiguration());

		  DataBaseContextSeed.CatalogSeed(builder); 
			base.OnModelCreating(builder);
			builder.Entity<Order>().OwnsOne(p => p.Address); 
		}
		public override int SaveChanges()
		{
			var modifiedEntries = ChangeTracker.Entries()
				.Where(p => p.State == EntityState.Modified ||
				p.State == EntityState.Added ||
				p.State == EntityState.Deleted
				);
			foreach ( var Entry in modifiedEntries )
			{ 
				var entityType= Entry.Context.Model.FindEntityType(Entry.Entity.GetType());
				var Inserted = entityType.FindProperty("InsertTime");
				var Updatetime = entityType.FindProperty("UpdateTime");
				var Removetime = entityType.FindProperty("RemoveTime");
				var Isremoved = entityType.FindProperty("IsRemoved");

				if (Entry.State== EntityState.Added && Inserted != null )
				{
					Entry.Property("InsertTime").CurrentValue= DateTime.Now;	
				}

				if (Entry.State == EntityState.Modified && Updatetime != null)
				{
					Entry.Property("UpdateTime").CurrentValue = DateTime.Now;
				}
				if (Entry.State == EntityState.Deleted && Removetime != null && Isremoved !=null)
				{
					Entry.Property("RemoveTime").CurrentValue = DateTime.Now;
					Entry.Property("IsRemoved").CurrentValue = true;
					Entry.State= EntityState.Modified;
				}
			}

			return base.SaveChanges();
		}



	}
}
