using BattleShip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Services
{
    public class ShipService : IShipService
    {
        public async Task<Ship> CreateShip(ShipRequest shipRequest)
        {
            var shipId = Guid.NewGuid();

            return new Ship
            {
                Id = shipId,
                Size = shipRequest.Size,
                Status = ShipStatus.Active,
                Positions = new List<ShipPosition>() { new ShipPosition
                {
                    
                } }
                
            };
        }

        public async Task<Ship> GetShip(Guid shipId)
        {
            //This should be calling a backen like database to get ship with ShipId
            return new Ship
            {
                Id = shipId,
                Size = 2,
                Status = ShipStatus.Active
            };
        }

        public async Task AddShipOnBoard(Guid boardId, Ship ship, AddShipRequest addShipRequest)
        {
            var shipPositions = new List<object>();
            var index = 0;
            //Write code to place a ship in backend(database)
        }
        public Guid GetShipByBoardId(Guid boardId)
        {
            //This should be calling backend like database to get the BoardId
            return new Guid();
        }
    }
}
