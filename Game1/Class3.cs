using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    public class Rook : ChessPiece
    {
        private Texture2D rookTexture;

        public Rook(int x, int y, bool white)
            : base(x, y, white)
        {
            this.xPos = x;
            this.yPos = y;
            this.isWhite = white;
        }

        public void LoadRook(Texture2D rookTexture)
        {
            this.rookTexture = rookTexture;
        }

        public void DrawRook(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(rookTexture, new Rectangle(xPos * 128, yPos * 128, 128, 128), Color.White);
        }
    }
}
