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
    public class AttackController : ControllerBase
    {
        private readonly IShipService _shipService;
        private readonly IBoardService _boardService;
        private readonly IAttackService _attackService;

        public AttackController(IShipService shipService, IBoardService boardService, IAttackService attackService)
        {
            _shipService = shipService;
            _boardService = boardService;
            _attackService = attackService;
        }
        [HttpPost("boards/{boardId}/attack")]
        [ProducesResponseType(typeof(AttackResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Attack(Guid boardId, AttackRequest attackRequest)
        {
            var boardTask = _boardService.GetBoard(boardId);
            var shipId = _shipService.GetShipByBoardId(boardId);
            var resultTask = _attackService.AttackShip(boardId, shipId, attackRequest);
            var response = await resultTask;
            return Ok(response.ToString());
        }
    }
}