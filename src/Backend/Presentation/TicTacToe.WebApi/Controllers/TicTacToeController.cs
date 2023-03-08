using Microsoft.AspNetCore.Mvc;
using TicTacToe.App.TicTacToes.Commands.Create;
using TicTacToe.App.TicTacToes.Commands.Delete;
using TicTacToe.App.TicTacToes.Commands.Update;
using TicTacToe.App.TicTacToes.Queries.GetDetails;
using TicTacToe.Domain;

namespace TicTacToe.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TicTacToeController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<TicTacToeModel>> Get(Guid id){
            var query = await Mediator.Send(new GetDetailsQuery(){SessionId = id});
            return Ok(query);
        }

        [HttpPost]
        public async Task<ActionResult<TicTacToeModel>> Post([FromBody] CreateCommand createCommand){
            var query = await Mediator.Send(createCommand);
            return Ok(query);
        }

        [HttpPut]
        public async Task<ActionResult<TicTacToeModel>> Put([FromBody] UpdateCommand updateCommand){
            var query = await Mediator.Send(updateCommand);
            return Ok(query);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id){
            await Mediator.Send(new DeleteCommand(){SessionId = id});
            return NoContent();
        }
    }
}