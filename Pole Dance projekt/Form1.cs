using System.Data.SqlClient;

namespace Pole_Dance_projekt
{
    public partial class Form1 : Form
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PoleDanceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public Form1()
        {
            InitializeComponent();
            LoadPrvky();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadPrvky()
        {
            cbPrvky.Items.Clear(); // Vyèistíme existující položky v ComboBoxu
            try
            {
                using (SqlConnection pripojeni = new SqlConnection(connectionString))
                {
                    pripojeni.Open();
                    SqlCommand prikaz = new SqlCommand();
                    prikaz.Connection = pripojeni;
                    prikaz.CommandText = @"
                        SELECT Obtiznost
                        FROM (
                            SELECT DISTINCT Obtiznost
                            FROM Prvky
                        ) AS DistinctObtiznost
                        ORDER BY CASE 
                            WHEN Obtiznost = 'Beginner' THEN 1 
                            WHEN Obtiznost = 'Intermediate' THEN 2 
                            WHEN Obtiznost = 'Advanced' THEN 3 
                            ELSE 4 
                        END";

                    using (SqlDataReader reader = prikaz.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string obtiznost = reader["Obtiznost"].ToString();
                            cbPrvky.Items.Add(obtiznost); // Pøidání jedineèných obtížností do ComboBoxu
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba pøi naèítání prvkù: " + ex.Message);
            }
        }
    }
}
