using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Models
{
    public class AttackPosition
    {
        public int RowPosition { get; set; }
        public int ColumnPosition { get; set; }
        public AttackStatus Status { get; set; }
    }

    public enum AttackStatus
    {
        Miss,
        Hit
    }
}
