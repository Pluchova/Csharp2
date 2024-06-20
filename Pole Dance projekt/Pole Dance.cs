using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pole_Dance_projekt
{
    public partial class Form1 : Form
    {
        private IDataService dataService;
        private static string connectionString = @"Data Source=db\PoleDanceDB.sqlite;";

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
                if (selectedItem == null)
                {
                    MessageBox.Show("Nevybral jsi obtížnost.");
                    return;
                }

                string obtiznostString = selectedItem.ToString();
                bool includeInverted = cbInverted.Checked;
                int pocetPrvku = (int)NumericUpDown.Value;

                if (pocetPrvku <= 0)
                {
                    MessageBox.Show("Nevybral jsi poèet prvkù.");
                    return;
                }

                var prvky = dataService.GetPrvky(obtiznostString, includeInverted).ToList();
                if (prvky.Count < pocetPrvku)
                {
                    MessageBox.Show("Databáze neobsahuje tolik prvkù. Zobrazí se maximální možný poèet prvkù.");
                }

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
            return randomOrder.Take(count).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var pridatPrvekForm = new PridatPrvekForm(dataService);
            pridatPrvekForm.ShowDialog();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var odstranPrvekForm = new OdstranPrvky(dataService);
            odstranPrvekForm.ShowDialog();


        }
    }
}
