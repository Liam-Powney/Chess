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

            Rook whiteRook1 = new Rook(0, 7, true);
            Rook whiteRook2 = new Rook(7, 7, true);
            Rook blackRook1 = new Rook(0, 0, false);
            Rook blackRook2 = new Rook(7, 0, false);
            Knight whiteKnight1 = new Knight(1, 7, true);
            Knight whiteKnight2 = new Knight(6, 7, true);
            Knight blackKnight1 = new Knight(1, 0, false);
            Knight blackKnight2 = new Knight(6, 0, false);
            Bishop whiteBishop1 = new Bishop(2, 7, true);
            Bishop whiteBishop2 = new Bishop(5, 7, true);
            Bishop blackBishop1 = new Bishop(2, 0, false);
            Bishop blackBishop2 = new Bishop(5, 0, false);
            Queen whiteQueen = new Queen(3, 7, true);
            Queen blackQueen = new Queen(3, 0, false);
            King whiteKing = new King(4, 7, true);
            King blackKing = new King(4, 0, false);
            Pawn whitePawn1 = new Pawn(0, 6, true);
            Pawn whitePawn2 = new Pawn(1, 6, true);
            Pawn whitePawn3 = new Pawn(2, 6, true);
            Pawn whitePawn4 = new Pawn(3, 6, true);
            Pawn whitePawn5 = new Pawn(4, 6, true);
            Pawn whitePawn6 = new Pawn(5, 6, true);
            Pawn whitePawn7 = new Pawn(6, 6, true);
            Pawn whitePawn8 = new Pawn(7, 6, true);
            Pawn blackPawn1 = new Pawn(0, 1, false);
            Pawn blackPawn2 = new Pawn(1, 1, false);
            Pawn blackPawn3 = new Pawn(2, 1, false);
            Pawn blackPawn4 = new Pawn(3, 1, false);
            Pawn blackPawn5 = new Pawn(4, 1, false);
            Pawn blackPawn6 = new Pawn(5, 1, false);
            Pawn blackPawn7 = new Pawn(6, 1, false);
            Pawn blackPawn8 = new Pawn(7, 1, false);
            currentPieces.Add(whiteRook1);
            currentPieces.Add(whiteRook2);
            currentPieces.Add(blackRook1);
            currentPieces.Add(blackRook2);
            currentPieces.Add(blackRook2);
            currentPieces.Add(whiteKnight1);
            currentPieces.Add(whiteKnight2);
            currentPieces.Add(blackKnight1);
            currentPieces.Add(blackKnight2);
            currentPieces.Add(whiteBishop1);
            currentPieces.Add(whiteBishop2);
            currentPieces.Add(blackBishop1);
            currentPieces.Add(blackBishop2);
            currentPieces.Add(whiteQueen);
            currentPieces.Add(blackQueen);
            currentPieces.Add(whiteKing);
            currentPieces.Add(blackKing);
            currentPieces.Add(whitePawn1);
            currentPieces.Add(whitePawn2);
            currentPieces.Add(whitePawn3);
            currentPieces.Add(whitePawn4);
            currentPieces.Add(whitePawn5);
            currentPieces.Add(whitePawn6);
            currentPieces.Add(whitePawn7);
            currentPieces.Add(whitePawn8);
            currentPieces.Add(blackPawn1);
            currentPieces.Add(blackPawn2);
            currentPieces.Add(blackPawn3);
            currentPieces.Add(blackPawn4);
            currentPieces.Add(blackPawn5);
            currentPieces.Add(blackPawn6);
            currentPieces.Add(blackPawn7);
            currentPieces.Add(blackPawn8);

            Game1.whitesTurn = true;

        }



    }

}
