using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;


namespace Game1
{
    public class Board
    {

        private const int TILE_SIZE = 128;

        private int[,] boardArray = new int[8, 8];

        private Texture2D boardTileLight;
        private Texture2D boardTileDark;


        //loads the light and dark board tile textures
        public void LoadBoard(ContentManager c, bool theme)
        {
            if (theme == true)
            {
                this.boardTileLight = c.Load<Texture2D>("square_light");
                this.boardTileDark = c.Load<Texture2D>("square_dark");
            }
            else
            {
                this.boardTileLight = c.Load<Texture2D>("square_brown_light");
                this.boardTileDark = c.Load<Texture2D>("square_brown_dark");
            }

        }
        
        //draws the board from the light and dark board tile textures
        public void DrawBoard(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < this.boardArray.GetLength(0) ; i++ )
            {
                for (int j = 0; j < this.boardArray.GetLength(1) ; j++ )
                {
                    if ((i + j)%2 != 0 )
                    {
                        spriteBatch.Draw(boardTileDark, new Rectangle(i * TILE_SIZE, j * TILE_SIZE, 128, 128), Color.White);
                    }
                    else
                    {
                        spriteBatch.Draw(boardTileLight, new Rectangle(i * TILE_SIZE, j * TILE_SIZE, 128, 128), Color.White);
                    }
                }
            }
        }

        //sets up currentPieces list with all new pieces for start of game and makes it white's turn
        public void setupGame(List<ChessPiece> currentPieces)
        {
            currentPieces.Clear();

            Rook whiteRook1 = new Rook(0, 7, true, currentPieces);
            Rook whiteRook2 = new Rook(7, 7, true, currentPieces);
            Rook blackRook1 = new Rook(0, 0, false, currentPieces);
            Rook blackRook2 = new Rook(7, 0, false, currentPieces);
            Knight whiteKnight1 = new Knight(1, 7, true, currentPieces);
            Knight whiteKnight2 = new Knight(6, 7, true, currentPieces);
            Knight blackKnight1 = new Knight(1, 0, false, currentPieces);
            Knight blackKnight2 = new Knight(6, 0, false, currentPieces);
            Bishop whiteBishop1 = new Bishop(2, 7, true, currentPieces);
            Bishop whiteBishop2 = new Bishop(5, 7, true, currentPieces);
            Bishop blackBishop1 = new Bishop(2, 0, false, currentPieces);
            Bishop blackBishop2 = new Bishop(5, 0, false, currentPieces);
            Queen whiteQueen = new Queen(3, 7, true, currentPieces);
            Queen blackQueen = new Queen(3, 0, false, currentPieces);
            King whiteKing = new King(4, 7, true, currentPieces);
            King blackKing = new King(4, 0, false, currentPieces);
            Pawn whitePawn1 = new Pawn(0, 6, true, currentPieces);
            Pawn whitePawn2 = new Pawn(1, 6, true, currentPieces);
            Pawn whitePawn3 = new Pawn(2, 6, true, currentPieces);
            Pawn whitePawn4 = new Pawn(3, 6, true, currentPieces);
            Pawn whitePawn5 = new Pawn(4, 6, true, currentPieces);
            Pawn whitePawn6 = new Pawn(5, 6, true, currentPieces);
            Pawn whitePawn7 = new Pawn(6, 6, true, currentPieces);
            Pawn whitePawn8 = new Pawn(7, 6, true, currentPieces);
            Pawn blackPawn1 = new Pawn(0, 1, false, currentPieces);
            Pawn blackPawn2 = new Pawn(1, 1, false, currentPieces);
            Pawn blackPawn3 = new Pawn(2, 1, false, currentPieces);
            Pawn blackPawn4 = new Pawn(3, 1, false, currentPieces);
            Pawn blackPawn5 = new Pawn(4, 1, false, currentPieces);
            Pawn blackPawn6 = new Pawn(5, 1, false, currentPieces);
            Pawn blackPawn7 = new Pawn(6, 1, false, currentPieces);
            Pawn blackPawn8 = new Pawn(7, 1, false, currentPieces);

            Game1.whitesTurn = true;

        }



    }

}
