using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase    
    {
        //private readonly MockCommanderRepository _repository = new MockCommanderRepository();
        private readonly ICommanderRepository _repository;
        public CommandsController(ICommanderRepository repository)
        {
            _repository = repository;
        }

        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }


        //GET api/commands/5
        [HttpGet("{id}")]        
        public ActionResult <Command> GetCommandById(int id)
        {
            var command = _repository.GetCommandById(id);

            return Ok(command);
        }
    }
}