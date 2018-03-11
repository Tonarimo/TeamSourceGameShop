using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSourceGameShop
{
    static class GamesDB 
    {
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
        public static List<Game> getAllGamesByName()
        {
            return getAllGames(); 
            // calls getAllGames to get around having to rename every instance ofr getAllGamesByName
        }
        public static List<Game> getAllGamesByPrice()
        {
            // gets games by price from DB
            GameStoreDB db = new GameStoreDB();
            return db.Games.OrderBy(g => g.Price).ToList();
            // get's all games by price from DB.
            //SqlConnection con = DBHelper.GetConnection();

            //SqlCommand retrieve = new SqlCommand();
            //retrieve.Connection = con;
            //retrieve.CommandText = @"SELECT Price
            //                          FROM Games";

            //try
            //{
            //    con.Open();

            //    SqlDataReader reader = retrieve.ExecuteReader();

            //    List<Game> gameList = new List<Game>();

            //    while (reader.Read())
            //    {
            //        Game game = new Game();
            //        game.Price = reader.GetDouble(reader.GetOrdinal("Price"));

            //        gameList.Add(game);
            //    }
            //    return gameList;
            //}
            //finally
            //{
            //    con.Dispose();
            //}
        }

        public static List<Game> getAllGames()
        {
            // get's all games by name from DB.
            GameStoreDB db = new GameStoreDB();

            return db.Games.OrderBy(g => g.GameName).ToList();
        }

        public static Game deleteGame(Game games)
        {
            GameStoreDB db = new GameStoreDB();

            var game = db.Games.Find(games.GameID);

            if(game != null)
            {
                db.Games.Remove(game);
                db.SaveChanges();
                return game;
            }
            return null;
        }
    }
}
