using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Models
{
    public class BoardRequest
    {
        [Range(1, int.MaxValue)]
        public int RowSize { get; set; }

        [Range(1, int.MaxValue)]
        public int ColumnSize { get; set; }
    }
}
