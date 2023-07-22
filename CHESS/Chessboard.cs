using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    public class Chessboard
    {
        private Piece[,] board;
        public Chessboard()
        {
            board = new Piece[8,8];

            initialiseBoard();
        }
        private void initialiseBoard()
        {
            //////sarbaz//////////////////////
            for (int col = 0; col < 8; col++)
            {
                board[1, col] = new Sarbaz(PieceColor.Black);
                board[6,col] = new Sarbaz(PieceColor.White);
            }
            ////////////////Rokh//////////////
            board[0, 0] = new Rokh(PieceColor.Black);
            board[0, 7] = new Rokh(PieceColor.Black);
            board[7, 0] = new Rokh(PieceColor.White);
            board[7, 7] = new Rokh(PieceColor.White);
            /////////////////Asb///////////////
            board[0, 1] = new Asb(PieceColor.Black);
            board[0, 6] = new Asb(PieceColor.Black);
            board[7, 1] = new Asb(PieceColor.White);
            board[7, 6] = new Asb(PieceColor.White);
            /////////////Fil//////////////////
            board[0, 2] = new Fil(PieceColor.Black);
            board[0, 5] = new Fil(PieceColor.Black);
            board[7, 2] = new Fil(PieceColor.White);
            board[7, 5] = new Fil(PieceColor.White);
            /////////////Queen///////////////
            board[0, 3] = new Queen(PieceColor.Black);
            board[7, 3] = new Queen(PieceColor.White);
            ////////////King////////////////
            board[0, 4] = new King(PieceColor.Black);
            board[7, 4] = new King(PieceColor.White);
        }
        public void PrintBoard()
        {
            for (int row = 0; row < 8; row++)
            {
                for(int col = 0; col < 8; col++)
                {
                    Piece piece = board[row, col];
                    if (piece != null)
                    {
                        Console.WriteLine(piece.Symbol + "");
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
