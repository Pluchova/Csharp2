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
    public partial class OdstranPrvky : Form
    {
        private IDataService dataService;

        public OdstranPrvky(IDataService dataService)
        {
            InitializeComponent();
            this.dataService = dataService;
        }

        private void btnOkOdstran_Click(object sender, EventArgs e)
        {
            string nazev = tbOdstran.Text;

            if (string.IsNullOrEmpty(nazev))
            {
                MessageBox.Show("Zadejte název prvku.");
                return;
            }

            try
            {

                dataService.RemovePrvek(nazev);
                MessageBox.Show("Prvek byl úspěšně odstraněn.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při odstraňování prvku: " + ex.Message);
            }

        }

        private void btnCancelOdstran_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
