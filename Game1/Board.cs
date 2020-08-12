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
                    if ((i + j)%2 == 0 )
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

        //sets the board up for a new game including piece placement
        public void setupGame(SpriteBatch spriteBatch, List<ChessPiece> currentPieces)
        {
            currentPieces.Clear();

            Rook whiteRook1 = new Rook(0, 7, true);
            Rook whiteRook2 = new Rook(7, 7, true);
            Rook blackRook1 = new Rook(0, 0, false);
            Rook blackRook2 = new Rook(7, 0, false);
            currentPieces.Add(whiteRook1);
            currentPieces.Add(whiteRook2);
            currentPieces.Add(blackRook1);
            currentPieces.Add(blackRook2);

            foreach(ChessPiece piece in currentPieces)
            {
                piece.DrawPiece(spriteBatch, piece.pieceTexture); //this will work once I generalise DrawRook() to DrawPiece() :)
            }
        }
    }

}
