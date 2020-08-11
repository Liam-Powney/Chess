using Microsoft.Xna.Framework;
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

        


    }
}
