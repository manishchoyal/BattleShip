using BattleShip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Services
{
    public class AttackService : IAttackService
    {
        public async Task<List<AttackPosition>> GetAttackPositions(Guid boardId)
        {

            var attackPositions = new List<AttackPosition>();

            return attackPositions.ToList();
        }
        public async Task<AttackStatus> AttackShip(Guid boardId, Guid? shipId, AttackRequest attackRequest)
        {
            //Write database logic to update, which is not part of this challenge 
            return AttackStatus.Hit;
        }
    }
}
