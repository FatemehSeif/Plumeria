
using Admin.Endpoint.MappingProfiles;
using Application.Banners;
using Application.BasketsService;
using Application.Catalogs.CatalogItems.AddNewCatalogItem;
using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Application.Catalogs.CatalogItems.GetCatalogItemPLP;
using Application.Catalogs.CatalogItems.UriComposer;
using Application.Catalogs.CatalogTypes;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Discounts;
using Application.Discounts.AddNewDiscountServices;
using Application.Interfaces.Contexts;
using Application.Visitors.GetToDayReport;
using Application.Visitors.SaveVisitorInfo;
using Application.Visitors.VisitorOnine;
using Domain.Visitors;
using FluentValidation;
using Infrastructure.ExternalApi.ImageServer;
using Infrastructure.MappingProfile;
using Microsoft.EntityFrameworkCore;
using Presistance.Context;
using Presistance.Context.MongoContext;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IDataBaseContext, DataBaseContext>();
var Connection = builder.Configuration.GetConnectionString("DefaultConnection"); //, b => b.MigrationsAssembly("Presistance")
builder.Services.AddDbContext<DataBaseContext>(option => option.UseSqlServer(Connection, b => b.MigrationsAssembly("Presistance")));
builder.Services.AddDistributedSqlServerCache(option =>
{
	option.ConnectionString = Connection;
	option.SchemaName = "dbo";
	option.TableName = "CacheData"; 
});
builder.Services.AddTransient(typeof(IMongoDBContext<>), typeof(MongoDBContext<>));
builder.Services.AddAutoMapper(typeof(CatalogMappingProfile));
builder.Services.AddAutoMapper(typeof(CatalogVMMappingProfile));
builder.Services.AddTransient<IAddNewCatalogItemService, AddNewCatalogItemService>();
builder.Services.AddTransient<ICatalogItemService, CatalogItemService>();
builder.Services.AddTransient<IGetCatalogIItemPLPService,  GetCatalogIItemPLPService>();
builder.Services.AddTransient<IUriComposerService, UriComposerService>();	
builder.Services.AddTransient<IGetCatalogItemPDPService, GetCatalogItemPDPService>();	
builder.Services.AddTransient<IValidator<AddNewCatalogItemDto>, AddNewCatalogItemDtoValidator> ();
builder.Services.AddTransient<ICatalogTypeService, CatalogTypeService>();	
builder.Services.AddTransient(typeof(IMongoDBContext<Visitor>), typeof(MongoDBContext<Visitor>));
builder.Services.AddScoped<IGetTodayReportService, GetTodayReportService>();
builder.Services.AddTransient<ISaveVisitorInfoService, SaveVisitorInfoService>();
builder.Services.AddTransient<IVisitorOnlineService , VisitorOnlineService>();
builder.Services.AddTransient<IBasketService, BasketService>();	
builder.Services.AddTransient<IAddNewDiscountService, AddNewDiscountService>();
builder.Services.AddTransient<IDiscountService, DiscountService>();
var apiKey = builder.Configuration.GetValue<string>("mysecretkey");
builder.Services.AddSingleton<string>(apiKey);
builder.Services.AddTransient<IImageUploadService, ImageUploadService>();	

builder.Services.AddTransient<IBannersService, BannersService>();

builder.Services.AddTransient<IDiscountHistoryService, DiscountHistoryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
