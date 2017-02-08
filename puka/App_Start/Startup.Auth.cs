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
                cfg.CreateMap<ReportsDBModels, ReportsModel>();
                cfg.CreateMap<TagRepAllocationDBModels, TagRepAllocationModel>();
                cfg.CreateMap<TagTypesDBModel, TagTypesModel>();
                cfg.CreateMap<TypesOfRepDBModel, TypesOfRepModel>();


            }
            );
    }
    }
   
}