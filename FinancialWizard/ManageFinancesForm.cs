using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialWizard
{
    public partial class ManageFinancesForm : Form
    {
        public ManageFinancesForm()
        {
            InitializeComponent();
        }
        private void ManageFinancesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home home = new Home();
            home.Show();
        }
    }
}
