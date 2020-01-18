using BattleShip.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BattleShip.Services
{
    public interface IAttackService
    {
        Task<List<AttackPosition>> GetAttackPositions(Guid boardId);
        Task<AttackStatus> AttackShip(Guid boardId, Guid? shipId, AttackRequest attackRequest);
    }
}