using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Pole_Dance_projekt
{
    public class SqlService : IDataService
    {
        private string connectionString;

        public SqlService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<string> GetPrvky(string obtiznost, bool includeInverted)
        {
            List<string> prvky = new List<string>();

            using (SqlConnection pripojeni = new SqlConnection(connectionString))
            {
                pripojeni.Open();
                string query = "SELECT Nazev FROM Prvky WHERE Obtiznost = @obtiznost AND (Inverted = 0 OR (Inverted = 1 AND @includeInverted = 1))";
                SqlCommand prikaz = new SqlCommand(query, pripojeni);
                prikaz.Parameters.AddWithValue("@obtiznost", obtiznost);
                prikaz.Parameters.AddWithValue("@includeInverted", includeInverted ? 1 : 0);

                using (SqlDataReader reader = prikaz.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        prvky.Add(reader["Nazev"].ToString());
                    }
                }
            }

            return prvky;
        }





        public IEnumerable<string> GetObtiznosti()
        {
            List<string> obtiznosti = new List<string>();

            using (SqlConnection pripojeni = new SqlConnection(connectionString))
            {
                pripojeni.Open();
                SqlCommand prikaz = new SqlCommand(
                    "SELECT Obtiznost FROM (" +
                    "SELECT DISTINCT Obtiznost, " +
                    "CASE " +
                    "WHEN Obtiznost = 'Beginner' THEN 1 " +
                    "WHEN Obtiznost = 'Intermediate' THEN 2 " +
                    "WHEN Obtiznost = 'Advanced' THEN 3 " +
                    "ELSE 4 END AS SortOrder " +
                    "FROM Prvky) AS InnerQuery " +
                    "ORDER BY SortOrder", pripojeni);

                using (SqlDataReader reader = prikaz.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        obtiznosti.Add(reader["Obtiznost"].ToString());
                    }
                }
            }

            return obtiznosti;
        }
    }
}
