using Domain;
using Domain.Banners;
using Domain.Baskets;
using Domain.Catalogs;
using Domain.Discounts;
using Domain.Order;
using Domain.Payments;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Contexts
{
	public interface IDataBaseContext
	{
        DbSet<CatalogItemComment> CatalogItemComments { get; set; }
        DbSet<Banner> Banners { get; set; }
        DbSet<CatalogItemFavourite> CatalogItemFavourites { get; set; }
        DbSet<Discount> Discount { get; set; }
        DbSet<Payment> Payments { get; set; }
        DbSet<UserAddress> UserAddresses { get; set; }
        DbSet<BasketItem> BasketItems { get; set; }
        DbSet<Basket> Baskets { get; set; }
        DbSet<CatalogItem> CatalogItems { get; set; }	
         DbSet<CatalogBrand> CatalogBrands { get; set; }
		 DbSet<CatalogType> CatalogTypes { get; set; }
         DbSet<Order> Orders { get; set; }
         DbSet<OrderItem> OrderItems { get; set; }
        DbSet<DiscountUsageHistory> DiscountUsageHistories { get; set; }
        EntityEntry Entry([NotNull] object entity);
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
      
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());

    }

}
