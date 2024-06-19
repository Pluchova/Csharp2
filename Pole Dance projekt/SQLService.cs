using System.Data;
using System.Data.SQLite;
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
            using (var pripojeni = new SQLiteConnection(connectionString))
            {
                pripojeni.Open();
                string query = "SELECT Nazev FROM Prvky WHERE Obtiznost = @obtiznost AND (Inverted = 0 OR (Inverted = 1 AND @includeInverted = 1))";
                var prikaz = pripojeni.CreateCommand();
                prikaz.CommandText = query;
                prikaz.Parameters.AddWithValue("@obtiznost", obtiznost);
                prikaz.Parameters.AddWithValue("@includeInverted", includeInverted ? 1 : 0);
                var adapter = new SQLiteDataAdapter(prikaz);
                var table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    prvky.Add(row["Nazev"].ToString());
                }
            }
            return prvky;
        }
        public IEnumerable<string> GetObtiznosti()
        {
            List<string> obtiznosti = new List<string>();
            using (var pripojeni = new SQLiteConnection(connectionString))
            {
                pripojeni.Open();
                var prikaz = pripojeni.CreateCommand();
                prikaz.CommandText = "SELECT Obtiznost FROM (" +
                    "SELECT DISTINCT Obtiznost, " +
                    "CASE " +
                    "WHEN Obtiznost = 'Beginner' THEN 1 " +
                    "WHEN Obtiznost = 'Intermediate' THEN 2 " +
                    "WHEN Obtiznost = 'Advanced' THEN 3 " +
                    "ELSE 4 END AS SortOrder " +
                    "FROM Prvky) AS InnerQuery " +
                    "ORDER BY SortOrder";
                var adapter = new SQLiteDataAdapter(prikaz);
                var table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    obtiznosti.Add(row["Obtiznost"].ToString());
                }
            }
            return obtiznosti;
        }
    }
}