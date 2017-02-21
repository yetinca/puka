using puka.Models;
using puka.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace puka.App_Start
{
    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AuthorsDBModel, AuthorsModel>();
                cfg.CreateMap<BranchTypesDBModels, BranchTypesModel>();
                cfg.CreateMap<ReportsContentDBModels, ReportsContentModel>().ForMember(m => m.author, mapper => mapper.MapFrom(b => b.AuthorsDBModel.nickname))
                                                                    .ForMember(m => m.AuthorDropDown, mapper => mapper.Ignore());
                cfg.CreateMap<ReportsDBModels, ReportsModel>().ForMember(m => m.typestr, mapper => mapper.MapFrom(b => b.TypesOfRepDBModel.type))
                                                                   .ForMember(m => m.TypeOfRepDropDown, mapper => mapper.Ignore())
                .ForMember(m => m.TypesOfRepDBModelID, mapper => mapper.MapFrom(b => b.TypesOfRepDBModel.ID))
                .ForMember(m => m.TypesOfRepModel, mapper => mapper.MapFrom(b => b.TypesOfRepDBModel))
                .ForMember(m => m.AuthorsModel, mapper => mapper.MapFrom(b => b.AuthorsDBModel))
                .ForMember(m => m.author, mapper => mapper.MapFrom(b => b.AuthorsDBModel.ID));
                cfg.CreateMap<TagRepAllocationDBModels, TagRepAllocationModel>();
                cfg.CreateMap<TagTypesDBModel, TagTypesModel>().ForMember(m => m.BranchTypesID, mapper => mapper.MapFrom(b => b.BranchTypesDBModels.branch))
                                                                .ForMember(m => m.BranchTypesDropDown, mapper => mapper.Ignore()); ;
                cfg.CreateMap<TypesOfRepDBModel, TypesOfRepModel>();


            });
        }
    }
}