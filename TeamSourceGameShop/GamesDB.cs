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
            //SqlConnection connection = DBHelper.GetConnection();
            //SqlCommand addGameCommand = new SqlCommand();
            //addGameCommand.Connection = connection;
            //addGameCommand.CommandText = @"INSERT INTO Games(GameName, Price, NumberOfCopies, AvailabilityOfGame)
            //                               VALUES(@GameName, @Price, @NumberOfCopies, @AvailabilityOfGame)";
            //addGameCommand.Parameters.AddWithValue("@GameName", game.GameName);
            //addGameCommand.Parameters.AddWithValue("@Price", game.Price);
            //addGameCommand.Parameters.AddWithValue("@NumberOfCopies", game.NumberOfCopies);
            //addGameCommand.Parameters.AddWithValue("@AvailabilityOfGame", game.Availability);

            //try
            //{
            //    connection.Open();
            //    int rowsAffected = addGameCommand.ExecuteNonQuery();
            //    if(rowsAffected > 0)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //catch(SqlException ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }
        public static List<Game> getAllGamesByName()
        {
            // get's all games by name from DB.
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand retrieve = new SqlCommand();
            retrieve.Connection = con;
            retrieve.CommandText = @"SELECT GameName
                                      FROM Games";

            try
            {
                con.Open();

                SqlDataReader reader = retrieve.ExecuteReader();

                List<Game> gameList = new List<Game>();

                while(reader.Read())
                {
                    Game game = new Game();
                    game.GameName = reader["GameName"] as string;

                    gameList.Add(game);
                }
                return gameList;
            }
            finally
            {
                con.Dispose();
            }
        }
        public static List<Game> getAllGamesByPrice()
        {
            // get's all games by price from DB.
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand retrieve = new SqlCommand();
            retrieve.Connection = con;
            retrieve.CommandText = @"SELECT Price
                                      FROM Games";

            try
            {
                con.Open();

                SqlDataReader reader = retrieve.ExecuteReader();

                List<Game> gameList = new List<Game>();

                while (reader.Read())
                {
                    Game game = new Game();
                    game.Price = reader.GetDouble(reader.GetOrdinal("Price"));

                    gameList.Add(game);
                }
                return gameList;
            }
            finally
            {
                con.Dispose();
            }
        }

        public static List<Game> getAllGames()
        {
            // get's all games by name from DB.
            GameStoreDB db = new GameStoreDB();

            return db.Games.OrderBy(g => g.GameName).ToList();
            //SqlConnection con = DBHelper.GetConnection();

            //SqlCommand retrieve = new SqlCommand();
            //retrieve.Connection = con;
            //retrieve.CommandText = @"SELECT GameName, Price, NumberOfCopies, AvailabilityOfGame
            //                          FROM Games";

            //try
            //{
            //    con.Open();

            //    SqlDataReader reader = retrieve.ExecuteReader();

            //    List<Game> gameList = new List<Game>();

            //    while (reader.Read())
            //    {
            //        Game game = new Game();
            //        game.GameName = reader["GameName"] as string;
            //        game.Price = reader.GetDouble(reader.GetOrdinal("Price"));
            //        game.NumberOfCopies = reader.GetInt32(reader.GetOrdinal("NumberOfCopies"));
            //        game.Availability = reader["AvailabilityOfGame"] as string;


            //        gameList.Add(game);
            //    }
            //    return gameList;
            //}
            //finally
            //{
            //    con.Dispose();
            //}
        }
    }
}
