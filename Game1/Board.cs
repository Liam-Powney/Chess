using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;


namespace Game1
{

    public class BoardSquare
    {
        public const int TILE_SIZE = 128;
        public int x;
        public int y;
        public Texture2D squareTexture;
        public ChessPiece PieceOnSquare;

        public BoardSquare(int x, int y, bool theme, Texture2D[] textureArray)
        {
            this.x = x;
            this.y = y;
            if (theme == true)
            {
                if (((x + y) / 2) % 2 != 0)
                {
                    this.squareTexture = textureArray[0];
                }
                else
                {
                    squareTexture = textureArray[1];
                }
            }
            else
            {
                if (((x + y) / 2) % 2 != 0)
                {
                    squareTexture = textureArray[2];
                }
                else
                {
                    squareTexture = textureArray[3];
                }
            }
        }

        public void SquareTextureAllocation(bool theme, Texture2D[] textureArray)
        {
            if (theme == true)
            {
                if ((x + y) % 2 == 0)
                {
                    squareTexture = textureArray[0];
                }
                else
                {
                    squareTexture = textureArray[1];
                }
            }
            else
            {
                if ((x + y) % 2 == 0)
                {
                    squareTexture = textureArray[2];
                }
                else
                {
                    squareTexture = textureArray[3];
                }
            }
        }

        public void DrawBoardSquare(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(squareTexture, new Rectangle(x * TILE_SIZE, y * TILE_SIZE, TILE_SIZE, TILE_SIZE), Color.White);
        }

    }



    public class Board
    {

        private const int TILE_SIZE = 128;

        public BoardSquare[,] boardArray = new BoardSquare[8, 8];
        public bool boardTheme = true;

        public void BoardCreation(bool theme, Texture2D[] textureList)
        {
            for (int i = 0; i < 8; i++ )
            {
                for (int j = 0; j < 8; j++ )
                {
                    boardArray[i, j] = new BoardSquare(i, j, theme, textureList);
                }
            }
        }

        //sets up currentPieces list with all new pieces for start of game and makes it white's turn
        public void setupNewGame(Board board)
        {
            foreach(BoardSquare square in board.boardArray)
            {
                square.PieceOnSquare = null;
            }

            Rook whiteRook1 = new Rook(0, 7, true, board);
            Rook whiteRook2 = new Rook(7, 7, true, board);
            Rook blackRook1 = new Rook(0, 0, false, board);
            Rook blackRook2 = new Rook(7, 0, false, board);
            Knight whiteKnight1 = new Knight(1, 7, true, board);
            Knight whiteKnight2 = new Knight(6, 7, true, board);
            Knight blackKnight1 = new Knight(1, 0, false, board);
            Knight blackKnight2 = new Knight(6, 0, false, board);
            Bishop whiteBishop1 = new Bishop(2, 7, true, board);
            Bishop whiteBishop2 = new Bishop(5, 7, true, board);
            Bishop blackBishop1 = new Bishop(2, 0, false, board);
            Bishop blackBishop2 = new Bishop(5, 0, false, board);
            Queen whiteQueen = new Queen(3, 7, true, board);
            Queen blackQueen = new Queen(3, 0, false, board);
            King whiteKing = new King(4, 7, true, board);
            King blackKing = new King(4, 0, false, board);
            Pawn whitePawn1 = new Pawn(0, 6, true, board);
            Pawn whitePawn2 = new Pawn(1, 6, true, board);
            Pawn whitePawn3 = new Pawn(2, 6, true, board);
            Pawn whitePawn4 = new Pawn(3, 6, true, board);
            Pawn whitePawn5 = new Pawn(4, 6, true, board);
            Pawn whitePawn6 = new Pawn(5, 6, true, board);
            Pawn whitePawn7 = new Pawn(6, 6, true, board);
            Pawn whitePawn8 = new Pawn(7, 6, true, board);
            Pawn blackPawn1 = new Pawn(0, 1, false, board);
            Pawn blackPawn2 = new Pawn(1, 1, false, board);
            Pawn blackPawn3 = new Pawn(2, 1, false, board);
            Pawn blackPawn4 = new Pawn(3, 1, false, board);
            Pawn blackPawn5 = new Pawn(4, 1, false, board);
            Pawn blackPawn6 = new Pawn(5, 1, false, board);
            Pawn blackPawn7 = new Pawn(6, 1, false, board);
            Pawn blackPawn8 = new Pawn(7, 1, false, board);

            Game1.whitesTurn = true;

        }



    }

}
