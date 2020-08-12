using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Game1
{

    public class ChessPiece
    {
        public int xPos;
        public int yPos;
        public bool isWhite;
        public Texture2D pieceTexture;
        
        public ChessPiece(int x, int y, bool white)
        {
        }

        public void DrawPiece(SpriteBatch spriteBatch, Texture2D pieceTexture)
        {

            //logic for deciding which piece gets which texture for it's Texture2D pieceTexture will go here, (generalised from RookDraw())

            //spriteBatch.Draw(pieceTexture, new Rectangle(xPos * 128, yPos * 128, 128, 128), Color.White);
        }
    }
}
