using BattleShip.Models;
using System;
using System.Threading.Tasks;

namespace BattleShip.Services
{
    public interface IShipService
    {
        Task<Ship> CreateShip(ShipRequest shipRequest);
        Task<Ship> GetShip(Guid shipId);
        Task AddShipOnBoard(Guid boardId, Ship ship, AddShipRequest addShipRequest);
        Guid GetShipByBoardId(Guid boardId);
    }
}