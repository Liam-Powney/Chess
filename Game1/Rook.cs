using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    public class Rook : ChessPiece
    {
        public Rook(int x, int y, bool white)
            : base(x, y, white)
        {
            this.xPos = x;
            this.yPos = y;
            this.isWhite = white;
        }

        //need to generalise this for all pieces, somehow make a parameter that checks the ChessPiece to see if it is a rook, bishop etc.
        public void rookDraw(Rook piece, ContentManager c, SpriteBatch spriteBatch)
        {
            if (piece.isWhite == true)
            {
                this.pieceTexture = c.Load<Texture2D>("w_rook");
            }
            else
            {
                this.pieceTexture = c.Load<Texture2D>("b_rook");
            }

            spriteBatch.Draw(pieceTexture, new Rectangle(xPos * 128, yPos * 128, 128, 128), Color.White);
        }

    }
}
