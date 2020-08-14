using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;


namespace Game1
{

    public class BoardSquare
    {
        public const int TILE_SIZE = 128;
        public int x;
        public int y;
        public Texture2D squareTexture;
        public ChessPiece pieceOnSquare;

        public BoardSquare(int x, int y, bool theme, Texture2D[] textureArray)
        {
            this.x = x;
            this.y = y;
            if (theme == true)
            {
                if ((x + y) % 2 == 0)
                {
                    this.squareTexture = textureArray[0];
                }
                else
                {
                    squareTexture = textureArray[1];
                }
            }
            else
            {
                if ((x + y) % 2 == 0)
                {
                    squareTexture = textureArray[2];
                }
                else
                {
                    squareTexture = textureArray[3];
                }
            }
        }

        public void DrawBoardSquare(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(squareTexture, new Rectangle(x * TILE_SIZE, y * TILE_SIZE, TILE_SIZE, TILE_SIZE), Color.White);
        }

    }



    public class Board
    {

        private const int TILE_SIZE = 128;

        public BoardSquare[,] boardArray = new BoardSquare[8, 8];
        public List<ChessPiece> currentPieces = new List<ChessPiece>();
        public bool boardTheme = true;

        public void BoardCreation(bool theme, Texture2D[] textureList)
        {
            for (int i = 0; i < 8; i++ )
            {
                for (int j = 0; j < 8; j++ )
                {
                    boardArray[i, j] = new BoardSquare(i, j, theme, textureList);
                }
            }
        }

        //sets up currentPieces list with all new pieces for start of game and makes it white's turn
        public void setupNewGame(Board board, List<ChessPiece> currentPieces)
        {
            currentPieces.Clear();

            Rook whiteRook1 = new Rook(0, 7, true, board, currentPieces);
            Rook whiteRook2 = new Rook(7, 7, true, board, currentPieces);
            Rook blackRook1 = new Rook(0, 0, false, board, currentPieces);
            Rook blackRook2 = new Rook(7, 0, false, board, currentPieces);
            Knight whiteKnight1 = new Knight(1, 7, true, board, currentPieces);
            Knight whiteKnight2 = new Knight(6, 7, true, board, currentPieces);
            Knight blackKnight1 = new Knight(1, 0, false, board, currentPieces);
            Knight blackKnight2 = new Knight(6, 0, false, board, currentPieces);
            Bishop whiteBishop1 = new Bishop(2, 7, true, board, currentPieces);
            Bishop whiteBishop2 = new Bishop(5, 7, true, board, currentPieces);
            Bishop blackBishop1 = new Bishop(2, 0, false, board, currentPieces);
            Bishop blackBishop2 = new Bishop(5, 0, false, board, currentPieces);
            Queen whiteQueen = new Queen(3, 7, true, board, currentPieces);
            Queen blackQueen = new Queen(3, 0, false, board, currentPieces);
            King whiteKing = new King(4, 7, true, board, currentPieces);
            King blackKing = new King(4, 0, false, board, currentPieces);
            Pawn whitePawn1 = new Pawn(0, 6, true, board, currentPieces);
            Pawn whitePawn2 = new Pawn(1, 6, true, board, currentPieces);
            Pawn whitePawn3 = new Pawn(2, 6, true, board, currentPieces);
            Pawn whitePawn4 = new Pawn(3, 6, true, board, currentPieces);
            Pawn whitePawn5 = new Pawn(4, 6, true, board, currentPieces);
            Pawn whitePawn6 = new Pawn(5, 6, true, board, currentPieces);
            Pawn whitePawn7 = new Pawn(6, 6, true, board, currentPieces);
            Pawn whitePawn8 = new Pawn(7, 6, true, board, currentPieces);
            Pawn blackPawn1 = new Pawn(0, 1, false, board, currentPieces);
            Pawn blackPawn2 = new Pawn(1, 1, false, board, currentPieces);
            Pawn blackPawn3 = new Pawn(2, 1, false, board, currentPieces);
            Pawn blackPawn4 = new Pawn(3, 1, false, board, currentPieces);
            Pawn blackPawn5 = new Pawn(4, 1, false, board, currentPieces);
            Pawn blackPawn6 = new Pawn(5, 1, false, board, currentPieces);
            Pawn blackPawn7 = new Pawn(6, 1, false, board, currentPieces);
            Pawn blackPawn8 = new Pawn(7, 1, false, board, currentPieces);

            Game1.whitesTurn = true;

        }

        public void selectPiece(int xCoord, int yCoord, Board board, List<BoardSquare> availableMoves, List<ChessPiece> currentPieces)
        {
            foreach(ChessPiece piece in currentPieces)
            {
                if (piece.xCoord == xCoord && piece.yCoord == yCoord)
                {
                    piece.isSelected = true;
                    Game1.currentlySelectedPiece = piece;
                    availableMoves = piece.availableMoves(board);
                }
            }
        }

        public void useSelectedPiece(int xCoord, int yCoord, Board board, List<BoardSquare> availableMoves, ChessPiece selectedPiece)
        {
            if (selectedPiece.xCoord == xCoord && selectedPiece.yCoord == yCoord)
            {
                selectedPiece.isSelected = false;
                Game1.currentlySelectedPiece = null;
                availableMoves.Clear();
            }
        }



    }

}
