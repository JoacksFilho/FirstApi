using FirstAPI.Data.Dtos;
using FirstAPI.Models;
using AutoMapper;

namespace FirstAPI.Profiles;

public class FilmeProfile : Profile
{
	public FilmeProfile()
	{
		CreateMap<CreateFilmeDto, Filme>();
		CreateMap<UpdateFilmeDto, Filme>();
		CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();
    }
}
