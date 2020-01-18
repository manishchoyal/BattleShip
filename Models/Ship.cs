using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Models
{
    public class Ship
    {
        public Guid Id { get; set; }
        public int Size { get; set; }
        public ShipStatus Status { get; set; }
        public IList<ShipPosition> Positions { get; set; }
    }

    public enum ShipStatus
    {
        Active,
        Sunk
    }
}
