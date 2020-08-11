using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Game1
{
    public class Board
    {

        private const int TILE_SIZE = 128;

        private int[,] boardArray = new int[8, 8];

        private Texture2D boardTileLight;
        private Texture2D boardTileDark;

        public void LoadContent(Texture2D lightSquare, Texture2D darkSquare)
        {
            this.boardTileLight = lightSquare;
            this.boardTileDark = darkSquare;

        }
        

        public void Draw(SpriteBatch spriteBatch)
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
    }

}
