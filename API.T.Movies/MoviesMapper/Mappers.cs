using API.T.Movies.DAL.Dtos.Category;
using API.T.Movies.DAL.Models;
using AutoMapper;

namespace API.J.Movies.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateUpdateDto>().ReverseMap();
        }
    }
}