using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    public enum PieceColor
    {
        Black, White
    }
    public abstract class Piece
    {
        public PieceColor Color { get; protected set; }
        public abstract string Symbol { get; }
    }
    public class Sarbaz : Piece
    {
        public Sarbaz(PieceColor color)
        {
            Color = color;
        }
        public override string Symbol => Color == PieceColor.White ? "S" : "s";       
    }
    public class Rokh : Piece
    {
        public Rokh(PieceColor color)
        {
            Color = color;
        }
        public override string Symbol => Color == PieceColor.White ? "R" : "r";
    }
    public class Asb : Piece
    {
        public Asb(PieceColor color)
        {
            Color = color;
        }
        public override string Symbol => Color == PieceColor.White ? "A" : "a";
    }
    public class Fil : Piece
    {
        public Fil(PieceColor color)
        {
            Color = color;
        }
        public override string Symbol => Color == PieceColor.White ? "F" : "f";
    }
    public class Queen : Piece
    {
        public Queen(PieceColor color)
        {
            Color = color;
        }
        public override string Symbol => Color == PieceColor.White ? "Q" : "q";
    }
    public class King : Piece
    {
        public King(PieceColor color)
        {
            Color = color;
        }
        public override string Symbol => Color == PieceColor.White ? "K" : "k";
    }
}
