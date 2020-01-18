using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Models
{
    public class Board
    {
        public Guid Id { get; set; }
        public int RowSize { get; set; }
        public int ColumnSize { get; set; }
        public IList<Ship> Ships { get; set; }
        public IList<AttackPosition> Attacks { get; set; }
    }
}
