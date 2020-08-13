using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public const int TILE_SIZE = 128;

        private MouseState oldState;

        Board board = new Board();
        public static bool whitesTurn;
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.IsMouseVisible = true;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            graphics.PreferredBackBufferWidth = 128 * 8;
            graphics.PreferredBackBufferHeight = 128 * 8;
            graphics.ApplyChanges();

            

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            // TODO: use this.Content to load your game content here

            //Loads all textures into an Array
            Texture2D[] textureArray = new Texture2D[16];
            textureArray[0] = Content.Load<Texture2D>("square_light");
            textureArray[1] = Content.Load<Texture2D>("square_dark");
            textureArray[2] = Content.Load<Texture2D>("square_brown_light");
            textureArray[3] = Content.Load<Texture2D>("square_brown_dark");
            textureArray[4] = Content.Load<Texture2D>("w_rook");
            textureArray[5] = Content.Load<Texture2D>("b_rook");
            textureArray[6] = Content.Load<Texture2D>("w_knight");
            textureArray[7] = Content.Load<Texture2D>("b_knight");
            textureArray[8] = Content.Load<Texture2D>("w_bishop");
            textureArray[9] = Content.Load<Texture2D>("b_bishop");
            textureArray[10] = Content.Load<Texture2D>("w_queen");
            textureArray[11] = Content.Load<Texture2D>("b_queen");
            textureArray[12] = Content.Load<Texture2D>("w_king");
            textureArray[13] = Content.Load<Texture2D>("b_king");
            textureArray[14] = Content.Load<Texture2D>("w_pawn");
            textureArray[15] = Content.Load<Texture2D>("b_pawn");

            
            board.BoardCreation(board.boardTheme, textureArray);

            foreach(BoardSquare square in board.boardArray)
            {
                square.SquareTextureAllocation(true, textureArray);
            }

            board.setupNewGame(board);

            foreach(BoardSquare square in board.boardArray)
            {
                if (square.PieceOnSquare != null)
                {
                    square.PieceOnSquare.PieceTextureAllocation(square, textureArray);
                }
            }


        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            MouseState newState = Mouse.GetState();
            if (newState.LeftButton == ButtonState.Pressed && oldState.LeftButton == ButtonState.Released)
            {
                foreach(BoardSquare square in board.boardArray)
                {
                    if (square.PieceOnSquare != null)
                    {
                        if (square.PieceOnSquare.pieceIsSelected == true)
                        {
                            square.PieceOnSquare.pieceIsSelected = false;
                        }
                        if (square.x == newState.X / TILE_SIZE && square.y == newState.Y / TILE_SIZE && square.PieceOnSquare.isWhite == whitesTurn)
                        {
                            square.PieceOnSquare.pieceIsSelected = true;
                        }
                    }
                }
            }

            oldState = newState; // this reassigns the old state so that it is ready for next time



            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            //draw board and pieces
            foreach(BoardSquare square in board.boardArray)
            {
                square.DrawBoardSquare(spriteBatch);
                if (square.PieceOnSquare != null)
                {
                    square.PieceOnSquare.DrawPiece(spriteBatch, square);
                    if (square.PieceOnSquare.pieceIsSelected == true)
                    {
                        square.PieceOnSquare.DrawAvailableSquares(spriteBatch, Content, square);
                    }
                }
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
