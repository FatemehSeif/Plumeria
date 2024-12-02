using Admin.Endpoint.ViewModels.Catalogs;

using Application.Catalogs.CatalogTypes;
using Application.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Endpoint.MappingProfiles
{
    public class CatalogVMMappingProfile:Profile
    {
        public CatalogVMMappingProfile()
        {
            CreateMap<CatalogTypeDto, CatalogTypeViewModel>().ReverseMap();
        }
    }
}
