using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {   
            //ModelToDto
            CreateMap<Command, CommandReadDto>();
            CreateMap<Command, CommandUpdateDto>();

            //DtoToModel
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }    
}   