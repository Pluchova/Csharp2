using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole_Dance_projekt
{
    public partial class PridatPrvekForm : Form
    {
        private IDataService dataService;

        public PridatPrvekForm(IDataService dataService)
        {
            InitializeComponent();
            this.dataService = dataService;


        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string nazev = tbNazev.Text;
            string obtiznost = cbObtiznost.SelectedItem.ToString();
            bool inverted = cbInverted.SelectedItem.ToString() == "Yes";

            if (string.IsNullOrEmpty(nazev) || string.IsNullOrEmpty(obtiznost))
            {
                MessageBox.Show("Vyplňte všechny údaje.");
                return;
            }

            try
            {
                if (dataService.ExistsPrvek(nazev, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Prvek s tímto názvem již existuje.");
                    return;
                }


                dataService.AddPrvek(nazev, obtiznost, inverted);
                MessageBox.Show("Prvek byl úspěšně přidán.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při přidávání prvku: " + ex.Message);
            }
        }

        private void cbInverted_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cbInverted.SelectedItem?.ToString();

            bool inverted = selectedOption == "Yes";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbObtiznost_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

