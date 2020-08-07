using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {   
            //DomainToDto
            CreateMap<Command, CommandReadDto>();
            CreateMap<Command, CommandUpdateDto>();

            //DtoToDomain
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }    
}   