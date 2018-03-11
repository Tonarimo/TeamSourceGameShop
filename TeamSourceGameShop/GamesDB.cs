using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSourceGameShop
{
    static class GamesDB 
    {
        /// <summary>
        /// Adds or updates a game depending on whether
        /// the user added a new game or tried to update
        /// a current game.
        /// </summary>
        /// <param name="game">A game that is being passed to the method to be updated or added.</param>
        public static void AddOrUpdateGame(Game game)
        {
            GameStoreDB db = new GameStoreDB();
            Game g = db.Games.Find(game.GameID);

            if (g == null)
            {
                db.Games.Add(game);
                MessageBox.Show("Game Added");
            }
            else
            {
                g.GameName = game.GameName;
                g.NumberOfCopies = game.NumberOfCopies;
                g.Price = game.Price;
                g.Availability = game.Availability;
                MessageBox.Show("Game Updated");
            }

            db.SaveChanges();
        }

        /// <summary>
        /// Get all the games by their price from the
        /// database.
        /// </summary>
        /// <returns>Retuns a list of games by their price.</returns>
        public static List<Game> getAllGamesByPrice()
        {
            // gets games by price from DB
            GameStoreDB db = new GameStoreDB();
            return db.Games.OrderBy(g => g.Price).ToList();
        }

        /// <summary>
        /// Get a list of all the games by their name from
        /// the database.
        /// </summary>
        /// <returns>Returns a list of all the games by their name.</returns>
        public static List<Game> getAllGamesByName()
        {
            // get's all games by name from DB.
            GameStoreDB db = new GameStoreDB();

            return db.Games.OrderBy(g => g.GameName).ToList();
        }

        public static void deleteGame(Game games)
        {
            GameStoreDB db = new GameStoreDB();

            if(games != null)
            {
                var game = db.Games.Find(games.GameID);
                db.Games.Remove(game);
                db.SaveChanges();
                MessageBox.Show("Game Deleted!");
            } 
            else
            {
                MessageBox.Show("You did not select a game to delete!");
            }
        }
    }
}
