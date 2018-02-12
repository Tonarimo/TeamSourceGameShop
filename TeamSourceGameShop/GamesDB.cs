using System;
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
    }
}
