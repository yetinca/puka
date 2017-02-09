using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using puka.Models;
using puka.Models.DBModels;


namespace puka.App_Start
{
    public partial class Startup
    {
        public void ConfigureAuth()
        {
            MapperInitialize();
        }
         static void MapperInitialize()
    {
        Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AuthorsDBModel, AuthorsModel>();
                cfg.CreateMap<BranchTypesDBModels, BranchTypesModel>();
                cfg.CreateMap<ReportsContentDBModels, ReportsContentModel>().ForMember(m => m.author, mapper => mapper.MapFrom(b=> b.AuthorsDBModel.nickname));
                cfg.CreateMap<ReportsDBModels, ReportsModel>().ForMember(m=> m.type, mapper => mapper.MapFrom(b=> b.TypesOfRepDBModel.type));
                cfg.CreateMap<TagRepAllocationDBModels, TagRepAllocationModel>();
                cfg.CreateMap<TagTypesDBModel, TagTypesModel>().ForMember(m=> m.BranchTypesID, mapper => mapper.MapFrom(b=> b.BranchTypesDBModels.branch));
                cfg.CreateMap<TypesOfRepDBModel, TypesOfRepModel>();


            }
            );
    }
    }
   
}