using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Game1
{
    public class Board
    {

        private const int TILE_SIZE = 128;

        public static List<ChessPiece> startingPieces = new List<ChessPiece>();
        private int[,] boardArray = new int[8, 8];

        private Texture2D boardTileLight;
        private Texture2D boardTileDark;


        //loads the light and dark board tile textures
        public void LoadBoard(Texture2D lightSquare, Texture2D darkSquare)
        {
            this.boardTileLight = lightSquare;
            this.boardTileDark = darkSquare;

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
        public void setup(SpriteBatch spriteBatch)
        {
            // need to unload all pieces still on board 
            startingPieces.Clear();

            startingPieces[0] = new Rook(0, 8, true);
            startingPieces[1] = new Rook(8, 8, true);

            foreach(ChessPiece piece in startingPieces)
            {
                piece.DrawPiece(spriteBatch);
            }
        }
    }

}
