using Application.Catalogs.CatalogItems.AddNewCatalogItem;
using Application.Catalogs.CatalogItems.GetMenuItem;
using Application.Catalogs.CatalogTypes;
using Application.Catalogs.CatalohItems.CatalogItemServices;
using Application.Dtos;
using AutoMapper;
using Domain.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MappingProfile
{
    public class CatalogMappingProfile : Profile
    {
        public CatalogMappingProfile()
        {
            CreateMap<CatalogType, CatalogTypeDto>().ReverseMap();

            CreateMap<CatalogType, CatalogTypeListDto>()
                .ForMember(dest => dest.SubTypeCount, option =>
                 option.MapFrom(src => src.SubType.Count));

            CreateMap<CatalogType, MenuItemDto>()
                .ForMember(dest => dest.Name, opt =>
                 opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.ParentId, opt =>
                 opt.MapFrom(src => src.ParentCatalogTypeId))
                .ForMember(dest => dest.SubMenu, opt =>
                opt.MapFrom(src => src.SubType));
            //----------------------
            // پروفایل مپ افزودن مورد جدید



                // 1. Map Feature DTO to Entity
                CreateMap<AddNewCatalogItemFeature_dto, CatalogItemFeature>()
                        .ReverseMap();

                    // 2. Map Image DTO to Entity
                    CreateMap<AddNewCatalogItemImage_Dto, CatalogItemImage>()
                        .ReverseMap();

                    // 3. Map AddNewCatalogItemDto to CatalogItem
                    CreateMap<AddNewCatalogItemDto, CatalogItem>()
                        // Map Features separately
                        .ForMember(dest => dest.CatalogItemFeatures, opt => opt.MapFrom(src => src.Features))
                        // Map Images separately
                        .ForMember(dest => dest.CatalogItemImages, opt => opt.MapFrom(src => src.Images));

                    // 4. Map CatalogItem to AddNewCatalogItemDto
                    CreateMap<CatalogItem, AddNewCatalogItemDto>()
                        // Map Features separately
                        .ForMember(dest => dest.Features, opt => opt.MapFrom(src => src.CatalogItemFeatures))
                        // Map Images separately
                        .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.CatalogItemImages));
            



            //CreateMap<CatalogItemFeature, AddNewCatalogItemFeature_dto>().ReverseMap();
            //CreateMap<CatalogItemImage, AddNewCatalogItemImage_Dto>().ReverseMap();
            // CreateMap<AddNewCatalogItemDto, CatalogItem>()
            //.ForMember(dest => dest.CatalogItemFeatures, opt => opt.MapFrom(src => src.Features))
            //.ForMember(dest => dest.CatalogItemImages, opt => opt.MapFrom(src => src.Images))
            //   .ReverseMap();
            // CreateMap<CatalogItem, AddNewCatalogItemDto>()
            //     .ForMember(dest => dest.Features, opt =>
            //     opt.MapFrom(src => src.CatalogItemFeatures))
            //      .ForMember(dest => dest.Images, opt =>
            //      opt.MapFrom(src => src.CatalogItemImages)).ReverseMap();

            //-------------------
            CreateMap<CatalogBrand, CatalogBrandDto>().ReverseMap();
            CreateMap<CatalogType, CatalogTypeDto>().ReverseMap();
        }
    }
}