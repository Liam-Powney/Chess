using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Game1
{

    public class ChessPiece
    {
        public const int TILE_SIZE = 128;
        public bool isWhite;
        public int xCoord;
        public int yCoord;
        public Texture2D pieceTexture;
        public bool hasMoved = false;
        public bool isSelected = false;
        public BoardSquare CurrentSquare;
        public List<BoardSquare> availableTiles = new List<BoardSquare>();
        
        public ChessPiece(int x, int y, bool white, Board board, List<ChessPiece> currentPieces)
        {
            board.boardArray[x, y].x = this.xCoord = x;
            board.boardArray[x, y].y = this.yCoord = y;
            board.boardArray[x, y].pieceOnSquare = this;
            board.currentPieces.Add(this);
            this.isWhite = white;
            CurrentSquare = board.boardArray[x, y];
            currentPieces.Add(this);
        }

        // Assigns the correct texture for a piece
        public void PieceTextureAllocation(Texture2D[] textureArray)
        {
            if (this is Rook == true)
            {
                if (isWhite == true)
                {
                    pieceTexture = textureArray[4];
                }
                else
                {
                    pieceTexture = textureArray[5];
                }
            }
            if (this is Knight == true)
            {
                if (isWhite == true)
                {
                    pieceTexture = textureArray[6];
                }
                else
                {
                    pieceTexture = textureArray[7];
                }
            }
            if (this is Bishop == true)
            {
                if (isWhite == true)
                {
                    pieceTexture = textureArray[8];
                }
                else
                {
                    pieceTexture = textureArray[9];
                }
            }
            if (this is Queen == true)
            {
                if (isWhite == true)
                {
                    pieceTexture = textureArray[10];
                }
                else
                {
                    pieceTexture = textureArray[11];
                }
            }
            if (this is King == true)
            {
                if (isWhite == true)
                {
                    pieceTexture = textureArray[12];
                }
                else
                {
                    pieceTexture = textureArray[13];
                }
            }
            if (this is Pawn == true)
            {
                if (isWhite == true)
                {
                    pieceTexture = textureArray[14];
                }
                else
                {
                    pieceTexture = textureArray[15];
                }
            }
            
        }

        // Draws the piece
        public void DrawPiece(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.pieceTexture, new Rectangle(this.xCoord* 128, this.yCoord * 128, 128, 128), Color.White);
        }


        //Finds Available Moves for a Selected Piece
        public List<BoardSquare> availableMoves(Board board)
        {
            List<BoardSquare> availableMoves = new List<BoardSquare>();
            if (this != null)
            {
                if (this is Pawn == true)
                {
                    if (this.isWhite == true)
                    {
                        if (board.boardArray[this.xCoord,this.yCoord].pieceOnSquare == null)
                        {
                            availableMoves.Add(board.boardArray[this.xCoord, this.yCoord - 1]);
                        }
                        if (this.hasMoved == false)
                        {
                            if (board.boardArray[this.xCoord, this.yCoord - 2].pieceOnSquare == null)
                            {
                                availableMoves.Add(board.boardArray[this.xCoord, this.yCoord - 2]);
                            }
                        }
                        else {  }
                    }
                    else
                    {
                        if (board.boardArray[this.xCoord, this.yCoord + 1].pieceOnSquare != null)
                        {
                            availableMoves.Add(board.boardArray[this.xCoord, this.yCoord - 1]);
                        }
                        else { }
                        if (this.hasMoved == false)
                        {
                            if (board.boardArray[this.xCoord, this.yCoord + 2].pieceOnSquare != null)
                            {
                                availableMoves.Add(board.boardArray[this.xCoord, this.yCoord - 2]);
                            }
                            else { }
                        }
                    }
                }
            }
            return availableMoves;
        }
    }


    ////////////////////
    // Types of Pieces//
    ////////////////////
  
    public class Rook : ChessPiece
    {
        public Rook(int x, int y, bool white, Board board, List<ChessPiece> currentPieces)
            : base(x, y, white, board, currentPieces)
        {
        }

    }

    public class Knight : ChessPiece
    {
        public Knight(int x, int y, bool white, Board board, List<ChessPiece> currentPieces)
            : base(x, y, white, board, currentPieces)
        {
        }
    }

    public class Bishop : ChessPiece
    {
        public Bishop(int x, int y, bool white, Board board, List<ChessPiece> currentPieces)
            : base(x, y, white, board, currentPieces)
        {
        }
    }

    public class King : ChessPiece
    {
        public King(int x, int y, bool white, Board board, List<ChessPiece> currentPieces)
            : base(x, y, white, board, currentPieces)
        {
        }
    }

    public class Queen : ChessPiece
    {
        public Queen(int x, int y, bool white, Board board, List<ChessPiece> currentPieces)
            : base(x, y, white, board, currentPieces)
        {
        }
    }

    public class Pawn : ChessPiece
    {
        public Pawn(int x, int y, bool white, Board board, List<ChessPiece> currentPieces)
            : base(x, y, white, board, currentPieces)
        {
        }

    }
}
