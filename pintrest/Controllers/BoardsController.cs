using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pintrest.Models;

namespace Pinterst.Controllers
{

    [Route("/api/boards")]
    public class BoardsController : Controller
    {
        public List<Board> Boards { get; set; }
        public List<Board> Get()
        {
          return Boards;
        }

        [HttpGet("{id}")]
        public Board Get(int id)
        {
          return Boards.Find(x => x.Id == id);
        }

        [HttpPost]
        public Board Post(Board board){
          Boards.Add(board);
          return board;
        }

        public BoardsController()
        {
            Boards = new List<Board>();
            var board1 = new Board
            {
                Id = 1,
                Title = "Board 1",
                Description = "Board 1 Description"
            };
            var board2 = new Board
            {
                Id = 2,
                Title = "Board 2",
                Description = "Board 2 Description"
            };
            var board3 = new Board
            {
                Id = 3,
                Title = "Board 3",
                Description = "Board 3 Description"
            };

            Boards.Add(board1);
            Boards.Add(board2);
            Boards.Add(board3);
        }
    }
}