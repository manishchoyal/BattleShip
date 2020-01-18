using BattleShip.Models;
using System;
using System.Threading.Tasks;

namespace BattleShip.Services
{
    public interface IBoardService
    {
        Task<Board> CreateBoard(BoardRequest createBoardRequest);
        Task<Board> GetBoard(Guid boardId);
    }
}
