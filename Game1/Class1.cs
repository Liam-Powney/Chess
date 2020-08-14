using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class DrawLibrary
    {
        public const int TILE_SIZE = 128;

        //Draws available move indicator
        public static void DrawAvailableSquares(SpriteBatch spriteBatch, ContentManager c, List<BoardSquare> squareList)
        {
            foreach (BoardSquare square in squareList)
            {
                spriteBatch.Draw(c.Load<Texture2D>("select_circle"), new Rectangle(((square.x * TILE_SIZE) + TILE_SIZE / 10), ((square.y * TILE_SIZE) + TILE_SIZE / 10), TILE_SIZE * 8 / 10, TILE_SIZE * 8 / 10), Color.White * 0.6f);
            }
        }


    }
}
