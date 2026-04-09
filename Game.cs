using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_DRAKE_BOSWELL
{
    class Game
    {
        /// <summary>
        // This class represents a game with a title and genre, and has a constructor to initialize these properties.
        public string title, genre;
        // Constructor for the Game class that takes in a title and genre as parameters and assigns them to the properties
        public Game(string titleParam = "Unknown Title", string genreParam = "Casual")
        {
            title = titleParam;
            genre = genreParam;
        }
    }
}
