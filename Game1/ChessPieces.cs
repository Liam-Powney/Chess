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
        public Texture2D pieceTexture;
        public bool pieceIsSelected = false;
        public bool hasMoved = false;
        public List<BoardSquare> availableTiles = new List<BoardSquare>();
        
        public ChessPiece(int x, int y, bool white, Board board)
        {
            board.boardArray[x, y].x = x;
            board.boardArray[x, y].y = y;
            this.isWhite = white;
            board.boardArray[x, y].PieceOnSquare = this;
        }

        // Assigns the correct texture for a piece
        public void PieceTextureAllocation(BoardSquare square ,Texture2D[] textureArray)
        {
            if (square.PieceOnSquare is Rook == true)
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
            if (square.PieceOnSquare is Knight == true)
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
            if (square.PieceOnSquare is Bishop == true)
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
            if (square.PieceOnSquare is Queen == true)
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
            if (square.PieceOnSquare is King == true)
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
            if (square.PieceOnSquare is Pawn == true)
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
        public void DrawPiece(SpriteBatch spriteBatch, BoardSquare square)
        {
            spriteBatch.Draw(square.PieceOnSquare.pieceTexture, new Rectangle(square.x* 128, square.y * 128, 128, 128), Color.White);
        }

        public void DrawAvailableSquares(SpriteBatch spriteBatch, ContentManager c, BoardSquare square)
        {
            spriteBatch.Draw(c.Load<Texture2D>("select_circle"), new Rectangle( ((square.x * TILE_SIZE) + TILE_SIZE/10), ((square.y * TILE_SIZE) + TILE_SIZE/10) , TILE_SIZE*8/10, TILE_SIZE*8/10), Color.White*0.6f);
        }

        /*public void availableSquares(Board board)
        {
            if ()
        }*/

    }


    ////////////////////
    // Types of Pieces//
    ////////////////////
  
    public class Rook : ChessPiece
    {
        public Rook(int x, int y, bool white, Board board)
            : base(x, y, white, board)
        {
        }

    }

    public class Knight : ChessPiece
    {
        public Knight(int x, int y, bool white, Board board)
            : base(x, y, white, board)
        {
        }
    }

    public class Bishop : ChessPiece
    {
        public Bishop(int x, int y, bool white, Board board)
            : base(x, y, white, board)
        {
        }
    }

    public class King : ChessPiece
    {
        public King(int x, int y, bool white, Board board)
            : base(x, y, white, board)
        {
        }
    }

    public class Queen : ChessPiece
    {
        public Queen(int x, int y, bool white, Board board)
            : base(x, y, white, board)
        {
        }
    }

    public class Pawn : ChessPiece
    {
        public Pawn(int x, int y, bool white, Board board)
            : base(x, y, white, board)
        {
        }

        /* public void findAvailableTiles(BoardSquare[,] boardArray)
        {
            if (this.isWhite == true)
            {
                if (boardArray[this.pieceCoord.x, this.pieceCoord.y - 1].PieceOnTile == null)
                {
                    BoardCoord pawnAvailableSquare1 = new BoardCoord();
                    this.availableTiles.Add(pawnAvailableSquare1);

                    if (this.hasMoved == false)
                    {
                        if (boardArray[this.pieceCoord.x, this.pieceCoord.y - 2].PieceOnTile == null)
                        {
                            BoardCoord pawnAvailableSquare2 = new BoardCoord();
                            this.availableTiles.Add(pawnAvailableSquare2);
                        }
                    }
                }
            }
            else
            {
                if (boardArray[this.pieceCoord.x, this.pieceCoord.y + 1] == 0)
                {
                    BoardCoord pawnAvailableSquare1 = new BoardCoord();
                    this.availableTiles.Add(pawnAvailableSquare1);

                    if (this.hasMoved == false)
                    {
                        if (boardArray[this.pieceCoord.x, this.pieceCoord.y + 2] == 0)
                        {
                            BoardCoord pawnAvailableSquare2 = new BoardCoord();
                            this.availableTiles.Add(pawnAvailableSquare2);
                        }
                    }
                }
            }

        } */

    }
}
