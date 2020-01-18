using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BattleShip.Models;
using BattleShip.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BattleShip.Controllers
{
    [ApiController]
    public class ShipController : ControllerBase
    {
        private readonly IShipService _shipService;
        private readonly IBoardService _boardService;

        public ShipController(IShipService shipService, IBoardService boardService)
        {
            _shipService = shipService;
            _boardService = boardService;
        }
        [HttpPost("ship/create")]
        [ProducesResponseType(typeof(Ship), (int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CreateShip(ShipRequest createShipRequest)
        {
            var ship = await _shipService.CreateShip(createShipRequest);
            var shipUri = new Uri($"/ProducesResponseType/{ship.Id}", UriKind.Relative);
            return Created(shipUri, ship);
        }
        [HttpPost("boards/{boardId}/ships/{shipId}/add")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> AddShip(Guid boardId, Guid shipId, AddShipRequest addShipRequest)
        {
            var boardTask = _boardService.GetBoard(boardId);
            var shipTask = _shipService.GetShip(shipId);
            var board = await boardTask;
            var ship = await shipTask;
            await _shipService.AddShipOnBoard(boardId, ship, addShipRequest);

            return NoContent();
        }
    }
}