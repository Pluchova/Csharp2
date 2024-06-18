using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pole_Dance_projekt
{
    public partial class Form1 : Form
    {
        private IDataService dataService;
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PoleDanceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public Form1()
        {
            InitializeComponent();
            dataService = new SqlService(connectionString);
            LoadObtiznosti();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void LoadObtiznosti()
        {
            cbPrvky.Items.Clear();

            try
            {
                var obtiznosti = dataService.GetObtiznosti();
                foreach (var obtiznost in obtiznosti)
                {
                    cbPrvky.Items.Add(obtiznost);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba pøi naèítání obtížností: " + ex.Message);
            }
        }

        private void cbInverted_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPotvrdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = cbPrvky.SelectedItem;
                string obtiznostString = null;

                if (selectedItem != null)
                {
                    obtiznostString = selectedItem.ToString();
                }
                if (obtiznostString == null)
                {
                    obtiznostString = "";
                }
                string obtiznost = obtiznostString;
                bool includeInverted = cbInverted.Checked;
                int pocetPrvku = (int)NumericUpDown.Value;

                // Zde voláme metodu s obìma parametry
                var prvky = dataService.GetPrvky(obtiznost, includeInverted).ToList();
                var randomPrvky = GetRandomPrvky(prvky, pocetPrvku);

                lbNahodnePrvky.Items.Clear();
                foreach (var prvek in randomPrvky)
                {
                    lbNahodnePrvky.Items.Add(prvek);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba pøi naèítání prvkù: " + ex.Message);
            }
        }

        private List<string> GetRandomPrvky(List<string> prvky, int count)
        {
            Random rnd = new Random();
            var randomOrder = prvky.OrderBy(x => rnd.Next());
            var selectedPrvky = randomOrder.Take(count);
            var resultList = selectedPrvky.ToList();
            return resultList;
        }
    }
}
