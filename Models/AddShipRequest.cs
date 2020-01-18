using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Models
{
    public class AddShipRequest
    {
        [Range(1, int.MaxValue)]
        public int RowStartPosition { get; set; }
        [Range(1, int.MaxValue)]
        public int ColumnStartPosition { get; set; }
        public PositionStyle PositionStyle { get; set; }
    }

    public enum PositionStyle
    {
        Horizontal,
        Vertical
    }
}
