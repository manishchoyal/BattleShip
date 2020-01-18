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
    public class BoardController : ControllerBase
    {
        private readonly IBoardService _boardService;
        private readonly IShipService _shipService;
        private readonly IAttackService _attackService;

        public BoardController(IBoardService boardService, IShipService shipService, IAttackService attackService)
        {
            _boardService = boardService;
            _shipService = shipService;
            _attackService = attackService;
        }

        [HttpGet("boards")]
        public async Task<IActionResult> Welcome()
        {
            return Ok("Welcome to the battle field");
        }
        [HttpGet("boards/{boardId}")]
        [ProducesResponseType(typeof(Board), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetBoard(Guid boardId)
        {
            var boardTask = _boardService.GetBoard(boardId);
            var attackPositionsTask = _attackService.GetAttackPositions(boardId);
            var board = await boardTask;

            return Ok(board);
        }

        [HttpPost("boards/create")]
        [ProducesResponseType(typeof(Board), (int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateBoard(BoardRequest boardRequest)
        {
            var board = await _boardService.CreateBoard(boardRequest);
            var boardUri = new Uri($"/boards/{board.Id}", UriKind.Relative);
            return Created(boardUri, board);
        }
    }
}