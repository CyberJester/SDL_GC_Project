basic structure of the library:

GameControls - Overall namespace
	Animation2D - Holds animation controls
	Controls - Varoius controls similar to Windows forms controls, with additional game related ones like screens and textures.
	FFMpeg - Handles video.
	Managers - Subspace that include Keybord, Mouse, Gontent, GraphicsDevices, and other controls.
	Globals - class holding game wide available values.
	Utilities - holds converters for images textures, etc.
	
Just like the old xna, which for it's time was very good, this library will, as the end product, be used in Visual studio
just like any other template to build projects. As such when a project is created it creates a Program.cs file that is preset to thiis:
    class Program 
    { 
        static void Main(string[] args) 
        {
            using (var game = new TestGame()) 
            { 
                game.Run(); 
            }
        } 
    } 
where test game will be replaced by the project name when the project is created. It also creates a second file named Game1.cs
which is the heart of the program and contains the game loop. It also has a pre-determined template that the user simply "fills-in"
with thier own code. This is the template structure for the Game1 file: 
using System; 
using GameControls; 
using System.Diagnostics;
using System.Collections;
using System.Runtime.InteropServices;

using GameControls.Managers; 

namespace $ProjectName  // This value will change to the project name in the creation
{ 
	public class Game1 : Game  // The user can change Game1 to whatever they want to. This is also the default filename Game1.cs
	{ 
		private GraphicsDeviceManager _graphics; 
		public MyGame() 
		{ 
			_graphics = new GraphicsDeviceManager(); 
		} 
		
		public override void Initialize() 
		{ 
			// Add your initialization logic here
		} 
		public override void LoadContent() 
		{ 
			// Load your content here
		} 
		public override void UnLoadContent() 
		{ 
			// Unload your content here
		} 
		public override void Update(GameTime gameTime) 
		{ 
			// Add your update logic here
			base.Update(gameTime); 
		 } 
		 public override void Draw(GameTime gameTime) 
		 { 
			graphicsDevice.Clear(Color.CornflowerBlue);
			spriteBatch.Begin();
			// Add your draw logic here
			spriteBatch.End();
			base.Draw(gameTime); 
		} 
	}
}
Some of the structure for the gameloop program may be changing.
Currently working on Game - GraphicsDeviceManager - ContentManager - GraphicsDevices - GCWindow - Texture2D - RenderTarget2D - PopUpWindow 
creation, management, passing and rendering.

Library includes controls created years ago for use with Microsoft Xna, and are being reworked to provide the same functionality without the
use of Xna.

