using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Models
{
    public class ShipRequest
    {
        [Range(1, int.MaxValue)]
        public int Size { get; set; }
    }
}
