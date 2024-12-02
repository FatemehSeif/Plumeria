using Application.Catalogs.CatalogTypes;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Discounts;
using Application.Dtos;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Catalogs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalogs.CatalogItems.AddNewCatalogItem
{
    public interface IAddNewCatalogItemService
    {
        BaseDto<int> Execute(AddNewCatalogItemDto request);
        AddNewCatalogItemDto GetById(int id);
        BaseDto<int> Update(int id, AddNewCatalogItemDto request);
        BaseDto<int> Delete(int id);
    }
    public class AddNewCatalogItemService : IAddNewCatalogItemService
    {
        private readonly IDataBaseContext context; 
        private readonly IMapper mapper;
        public AddNewCatalogItemService(IDataBaseContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;   
        }
        public BaseDto<int> Execute(AddNewCatalogItemDto request)
        {
            var catalogItem = mapper.Map<CatalogItem>(request);
            context.CatalogItems.Add(catalogItem);
            try
            {
                context.SaveChanges();
                return new BaseDto<int>(true, new List<string> { "با موفقیت ثبت شد" }, catalogItem.Id);
            }
            catch (Exception ex)
            {
                // Handle the exception here (e.g., log the error, return an error message)
                // Consider specific exception types for more granular handling
                Console.WriteLine($"Error saving catalog item: {ex.Message}");
               return new BaseDto<int>(false, new List<string> { "خطا در ثبت اطلاعات" },0);  // Example error message
            }
        }
        public AddNewCatalogItemDto GetById(int id)
        {
            var catalogItem = context.CatalogItems.FirstOrDefault(c => c.Id == id);
            if (catalogItem == null)
            {
                return null;
            }
            return mapper.Map<AddNewCatalogItemDto>(catalogItem);
        }



        public BaseDto<int> Update(int id, AddNewCatalogItemDto request)
        {
            var existingCatalogItem = context.CatalogItems.FirstOrDefault(c => c.Id == id);
            if (existingCatalogItem == null)
            {
                return new BaseDto<int>(false, new List<string> { "کالا یافت نشد" }, 0);
            }
             mapper.Map(request, existingCatalogItem); // Update existing entity
            try
            {
                context.SaveChanges();
                return new BaseDto<int>(true, new List<string> { "با موفقیت به روز رسانی شد" }, existingCatalogItem.Id);
            }
            catch (Exception ex)
            {
                // Handle the exception 
                return new BaseDto<int>(false, new List<string> { "خطا در به روز رسانی اطلاعات" }, 0);
            }
        }

        public BaseDto<int> Delete(int id)
        {
            var catalogItem = context.CatalogItems.FirstOrDefault(c => c.Id == id);
            if (catalogItem == null)
            {
                return new BaseDto<int>(false, new List<string> { "کالا یافت نشد" }, 0);
            }
            context.CatalogItems.Remove(catalogItem);
            try
            {
                context.SaveChanges();
                return new BaseDto<int>(true, new List<string> { "با موفقیت حذف شد" }, catalogItem.Id);
            }
            catch (Exception ex)
            {
                // Handle the exception
                return new BaseDto<int>(false, new List<string> { "خطا در حذف اطلاعات" }, 0);
            }
        }
    }
    public class AddNewCatalogItemFeature_dto
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Group { get; set; }
    }

    public class AddNewCatalogItemImage_Dto
    {
        public string? Src { get; set; }
    }
}
