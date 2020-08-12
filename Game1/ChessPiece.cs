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
            this.xPos = x;
            this.yPos = y;
            this.isWhite = white;
        }

        public void LoadPiece(ContentManager c, ChessPiece piece)
        {
            if (piece is Rook == true)
            {
                if (isWhite == true)
                {
                    pieceTexture = c.Load<Texture2D>("w_rook");
                }
                else
                {
                    pieceTexture = c.Load<Texture2D>("b_rook");
                }
            }
            if (piece is Bishop == true)
            {
                if (isWhite == true)
                {
                    pieceTexture = c.Load<Texture2D>("w_bishop");
                }
                else
                {
                    pieceTexture = c.Load<Texture2D>("b_bishop");
                }
            }
            if (piece is Knight == true)
            {
                if (isWhite == true)
                {
                    pieceTexture = c.Load<Texture2D>("w_knight");
                }
                else
                {
                    pieceTexture = c.Load<Texture2D>("b_knight");
                }
            }
            if (piece is Queen == true)
            {
                if (isWhite == true)
                {
                    pieceTexture = c.Load<Texture2D>("w_queen");
                }
                else
                {
                    pieceTexture = c.Load<Texture2D>("b_queen");
                }
            }
            if (piece is King == true)
            {
                if (isWhite == true)
                {
                    pieceTexture = c.Load<Texture2D>("w_king");
                }
                else
                {
                    pieceTexture = c.Load<Texture2D>("b_king");
                }
            }
            if (piece is Pawn == true)
            {
                if (isWhite == true)
                {
                    pieceTexture = c.Load<Texture2D>("w_pawn");
                }
                else
                {
                    pieceTexture = c.Load<Texture2D>("b_pawn");
                }
            }
        }

        public void DrawPiece(SpriteBatch spriteBatch, ChessPiece piece)
        {
            spriteBatch.Draw(piece.pieceTexture, new Rectangle(xPos * 128, yPos * 128, 128, 128), Color.White);
        }
    }

    public class Rook : ChessPiece
    {
        public Rook(int x, int y, bool white)
            : base(x, y, white)
        {
        }
    }

    public class Knight : ChessPiece
    {
        public Knight(int x, int y, bool white)
            : base(x, y, white)
        {
        }
    }

    public class Bishop : ChessPiece
    {
        public Bishop(int x, int y, bool white)
            : base(x, y, white)
        {
        }
    }

    public class King : ChessPiece
    {
        public King(int x, int y, bool white)
            : base(x, y, white)
        {
        }
    }

    public class Queen : ChessPiece
    {
        public Queen(int x, int y, bool white)
            : base(x, y, white)
        {
        }
    }

    public class Pawn : ChessPiece
    {
        public Pawn(int x, int y, bool white)
            : base(x, y, white)
        {
        }
    }
}
