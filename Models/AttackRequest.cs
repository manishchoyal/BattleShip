using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Models
{
    public class AttackRequest
    {
        [Range(1, int.MaxValue)]
        public int RowPosition { get; set; }
        [Range(1, int.MaxValue)]
        public int ColumnPosition { get; set; }
    }
}
