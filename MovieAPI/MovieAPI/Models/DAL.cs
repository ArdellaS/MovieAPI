using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class DAL : IDAL
    {
        private SqlConnection conn;
        private string connectionString;

        public DAL(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }

        public IEnumerable<Film> GetAllMovies()
        {
            SqlConnection connection = null;
            string queryString = "SELECT * FROM Movies";
            IEnumerable<Film> Films = null;

            try
            {
                connection = new SqlConnection(connectionString);
                Films = connection.Query<Film>(queryString);
            }
            catch (Exception e)
            {
                //log the error--get details from e
            }
            finally //cleanup!
            {
                if (connection != null)
                {
                    connection.Close(); //explicitly closing the connection
                }
            }

            return Films;

        }

        public Film GetRandomMovie()
        {

            string queryString = "SELECT top 1 category FROM Movies  ORDER BY NEWID()";
            Film Films = null;

            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(connectionString);
                Films = connection.ExecuteScalar<Film>(queryString);
            }
            catch (Exception e)
            {
                //log the error--get details from e
            }
            finally //cleanup!
            {
                if (connection != null)
                {
                    connection.Close(); //explicitly closing the connection
                }
            }

            return Films;

        }

        public IEnumerable<Film> GetFilmsByCategory(string category)
        {
            SqlConnection connection = null;
            string queryString = "SELECT * FROM Products WHERE Category = @cat";
            IEnumerable<Film> Films = null;

            try
            {
                connection = new SqlConnection(connectionString);
                Films = connection.Query<Film>(queryString, new { cat = category });
            }
            catch (Exception e)
            {
                //log the error--get details from e
            }
            finally //cleanup!
            {
                if (connection != null)
                {
                    connection.Close(); //explicitly closing the connection
                }
            }

            return Films;

        }
        public IEnumerable<Film> GetRandomFilmsByCategory(string category)
        {
            string queryString = "SELECT * category FROM Movies  ORDER BY NEWID()";
            IEnumerable<Film> Films = null;

            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(connectionString);
                Films = connection.Query<Film>(queryString);
            }
            catch (Exception e)
            {
                //log the error--get details from e
            }
            finally //cleanup!
            {
                if (connection != null)
                {
                    connection.Close(); //explicitly closing the connection
                }
            }

            return Films;

        }
    }
}
