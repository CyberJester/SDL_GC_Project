using System; 
using SDL2;
using GameControls;
using GameControls.Managers;

namespace GameControlsTest 
{ 
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
}