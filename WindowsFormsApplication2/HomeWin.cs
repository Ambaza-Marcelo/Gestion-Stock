using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class HomeWin : Form
    {
        public HomeWin()
        {
            InitializeComponent();
        }

        private void gestionDesEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeWin emp = new EmployeeWin();
            emp.Show();
        }

        private void gestionDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientWin cl = new ClientWin();
            cl.Show();
        }

        private void gestionDesDepensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepenseWin dep = new DepenseWin();
            dep.Show();
        }

        private void gestionDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProduitWin prod = new ProduitWin();
            prod.Show();
        }
    }
}
