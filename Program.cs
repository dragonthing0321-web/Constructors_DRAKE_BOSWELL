using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_DRAKE_BOSWELL
{
    class Program
    {
        /// <summary>
        // This program shows off how to use constructors
        
        static void Main(string[] args)
        {
            // Create a new game object using the constructor
            Game myGame = new Game("The Legend of Zelda: Breath of the Wild", "Action-Adventure");
            // Print out the details of the game using the properties
            Console.WriteLine($"One game I really want to try would be {myGame.title}");
            Console.WriteLine($"Which is a {myGame.genre} game!");
            // Create another game object using the constructor
            Game myOtherGame = new Game("Ultrakill", "First Person Shooter");
            // Print out the details of the other game using the properties
            Console.WriteLine($"A game I have been playing a lot recently is {myOtherGame.title}");
            Console.WriteLine($"Which is a {myOtherGame.genre} game!");
        }
    }
}
