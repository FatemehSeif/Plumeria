using Microsoft.EntityFrameworkCore;
using Presistance.Context;
using Microsoft.Extensions.Configuration;
using Infrastructure.IdentityConfigs;
using Application.Interfaces.Contexts;
using Presistance.Context.MongoContext;
using Application.Visitors.SaveVisitorInfo;
using Endpoint.Utilities.Filters;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core.Configuration;
using Domain.Visitors;
using Application.Visitors.GetToDayReport;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using Endpoint.Hubs;
using Endpoint.Utilities.MiddleWares;
using Infrastructure.MappingProfile;
using Endpoint.Models.ViewComponents;
using Application.Catalogs.CatalogItems.GetMenuItem;
using Application.Catalogs.CatalogItems.AddNewCatalogItem;
using Infrastructure.ExternalApi.ImageServer;
using Application.Catalogs.CatalogItems.GetCatalogItemPLP;
using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Application.Catalogs.CatalogItems.UriComposer;
using Application.BasketsService;
using Application.Orders;
using Application.Payments;
using Application.Discounts.AddNewDiscountServices;
using Application.Discounts;
using Application.Orders.CustomerOrdersServices;
using Application.Banners;
using Application.HomePageService;
using WebSite.EndPoint.Midlewares;
using Application.Commetns.Commands;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Application.Users;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Domain;
using Endpoint.Models.ViewModels.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IDataBaseContext, DataBaseContext>();
builder.Services.AddTransient<IIdentityDatabaseContext, IdentityDataBaseContext>();
builder.Services.AddTransient<IGetMenuItemService, GetMenuItemService>();

builder.Services.AddAutoMapper(typeof(CatalogMappingProfile));
builder.Services.AddAutoMapper(typeof(UserMappingProfile));	
builder.Services.AddTransient(typeof(IMongoDBContext<OnlineVisitor>), typeof(MongoDBContext<OnlineVisitor>));
builder.Services.AddScoped<IGetTodayReportService, GetTodayReportService>();	
builder.Services.AddTransient(typeof(IMongoDBContext<Visitor>), typeof(MongoDBContext<Visitor>));
builder.Services.AddTransient<ISaveVisitorInfoService, SaveVisitorInfoService>();
builder.Services.AddScoped<ICatalogItemService, CatalogItemService>();
builder.Services.AddTransient<IGetCatalogIItemPLPService, GetCatalogIItemPLPService>();
builder.Services.AddTransient<IGetCatalogItemPDPService, GetCatalogItemPDPService>();
builder.Services.AddTransient<IUriComposerService, UriComposerService>();	
builder.Services.AddTransient<IBasketService, BasketService>();	
builder.Services.AddTransient<IAddNewCatalogItemService, AddNewCatalogItemService>();	
builder.Services.AddScoped<SaveVisitorFilter>(); 
builder.Services.AddTransient<IOrderService , OrderService>();
builder.Services.AddTransient<IPaymentService, PaymentService>();
builder.Services.AddTransient<IDiscountService, DiscountService>();	
builder.Services.AddScoped<IDiscountHistoryService, DiscountHistoryService>();	
builder.Services.AddTransient<ICustomerOrdersService, CustomerOrdersService>();	
builder.Services.AddTransient<IHomePageService, HomePageService>();
builder.Services.AddTransient<IUserAddressService, UserAddressService>();	
builder.Services.AddTransient<IImageUploadService , ImageUploadService>();	
builder.Services.AddMediatR(typeof(SendCommentCommand).Assembly);

builder.Configuration.AddJsonFile("appsettings.json",
 optional: false, reloadOnChange: true);

builder.Services.AddSignalR();

builder.Services.AddScoped<IMongoDBContext<Visitor> , MongoDBContext<Visitor>>();

var Connection = builder.Configuration.GetConnectionString("DefaultConnection"); //, b => b.MigrationsAssembly("Presistance")
builder.Services.AddDbContext<DataBaseContext>(option => option.UseSqlServer(Connection, b => b.MigrationsAssembly("Presistance")));
builder.Services.AddIdentity<User , IdentityRole>(p =>
{
    p.User.RequireUniqueEmail = false;

    p.SignIn.RequireConfirmedEmail = false;
}).AddEntityFrameworkStores<IdentityDataBaseContext>()
.AddDefaultTokenProviders();    
builder.Services.AddDbContext<IdentityDataBaseContext>(option => option.UseSqlServer(Connection, a=> a.MigrationsAssembly("Presistance")));

builder.Services.AddDistributedSqlServerCache(option =>
{
    option.ConnectionString = Connection;
    option.SchemaName = "dbo";
    option.TableName = "CacheData";
});
//builder.Services.AddIdentityService(builder.Configuration);

builder.Services.AddAuthorization();
builder.Services.ConfigureApplicationCookie(option =>
{
	option.ExpireTimeSpan = TimeSpan.FromMinutes(10);
	option.LoginPath = "/Account/Login";
	option.AccessDeniedPath = "/Account/AccessDenied";
	option.SlidingExpiration = true;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
app.UseCustomExceptionHandler();	
app.UseSetVisitorId(); 
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
		  name: "areas",
		  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "FilterByCategory",
        pattern: "product/FilterByCategory/",
        defaults: new { controller = "Product", action = "FilterByCategory" }
        );

    endpoints.MapControllerRoute(
		name: "ProductDetails",
		pattern: "product/Details",
		defaults : new {controller= "Product" , action = "Details" }
		);
    endpoints.MapControllerRoute(
      name: "BasketQuantity",
      pattern: "Basket/setQuantity",
      defaults: new { controller = "Basket", action = "setQuantity" }
      );

    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

	endpoints.MapHub<OnlineVisitorHub>("/chathub");
});

app.Run();
