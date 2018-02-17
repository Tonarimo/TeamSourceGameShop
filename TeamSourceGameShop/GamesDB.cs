﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceGameShop
{
    static class GamesDB
    {
        public static bool AddGame(Game game)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand addGameCommand = new SqlCommand();
            addGameCommand.Connection = connection;
            addGameCommand.CommandText = @"INSERT INTO Games(GameName, Price, NumberOfCopies, Availability)
                                           VALUES(@GameName, @Price, @NumberOfCopies, @Availability)";
            addGameCommand.Parameters.AddWithValue("@GameName", game.GameName);
            addGameCommand.Parameters.AddWithValue("@Price", game.Price);
            addGameCommand.Parameters.AddWithValue("@NumberOfCopies", game.NumberOfCopies);
            addGameCommand.Parameters.AddWithValue("@Availability", game.Availability);

            try
            {
                connection.Open();
                int rowsAffected = addGameCommand.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
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
            // get's all games by name from DB.
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
                    game.GameName = reader["Price"] as string;

                    gameList.Add(game);
                }
                return gameList;
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}