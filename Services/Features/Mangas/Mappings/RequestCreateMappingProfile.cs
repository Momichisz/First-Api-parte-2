using AutoMapper;
using manga.Domain.Dtos;
// using JaveragesLibrary.Domain.Entities;
using mangas.Domain.Entities;

namespace manga.Services.Mappings;

public class RequestCreateMappingProfile : Profile
{
    public RequestCreateMappingProfile()
    {
        CreateMap<MangaCreateDTO, Manga>()
            .AfterMap(
                (src, dest) =>
                {
                    dest.PublicationDate = DateTime.Now;
                });
    }
}
