using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{

    public class ChessPiece
    {
        public int xPos;
        public int yPos;
        public bool isWhite;
        Texture2D pieceTexture;

        public ChessPiece(int x, int y, bool white)
        {
        }

        public void LoadPiece(Texture2D pieceTexture)
        {
            this.pieceTexture = pieceTexture;
        }

        public void DrawPiece(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(pieceTexture, new Rectangle(xPos * 128, yPos * 128, 128, 128), Color.White);
        }
    }
}
