using BattleShip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Services
{
    public class BoardService : IBoardService
    {
        public BoardService()
        {
            //Use for DI
        }
        public async Task<Board> CreateBoard(BoardRequest createBoardRequest)
        {
            var boardId = Guid.NewGuid();
            //Save the board in the database which is not done as part of this excerise 
            return new Board
            {
                Id = boardId,
                RowSize = createBoardRequest.RowSize,
                ColumnSize = createBoardRequest.ColumnSize
            };
        }

        public async Task<Board> GetBoard(Guid boardId)
        {
            //Get the board details from database and send it back
            return new Board
            {
                Id = boardId,
                RowSize = 10,
                ColumnSize = 10
            };
        }
    }
}
