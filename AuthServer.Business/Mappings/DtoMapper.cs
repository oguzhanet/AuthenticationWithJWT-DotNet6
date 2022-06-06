using AuthServer.Core.DTOs;
using AuthServer.Core.Models;
using AutoMapper;

namespace AuthServer.Business.Mappings
{
    public class DtoMapper:Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto,Product>().ReverseMap();
            CreateMap<UserAppDto,UserApp>().ReverseMap();
        }
    }
}
