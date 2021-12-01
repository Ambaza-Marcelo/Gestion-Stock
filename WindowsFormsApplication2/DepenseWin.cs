using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO; 

namespace WindowsFormsApplication2
{
    public partial class DepenseWin : Form
    {
        public DepenseWin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("dataSource=localhost;port=3306;Database=bar;username=root;password=");
                connection.Open();
                MySqlCommand req = new MySqlCommand("insert into depenses(idDepense,description,montant) values('" + idDepense.Text + "','" + description.Text + "','" + montant.Text + "')", connection);
                if (req.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("vous avez ajoutee la depense avec succees");
                }
                else
                {
                    MessageBox.Show("erreur d'ajout");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("dataSource=localhost;port=3306;Database=bar;username=root;password=");
                connection.Open();
                MySqlCommand req = new MySqlCommand("update depenses set description = '"+description.Text+"',montant='"+montant.Text+"'where idDepense='"+idDepense.Text+ "'", connection);
                if (req.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("vous avez modifiee la depense avec succees");
                }
                else
                {
                    MessageBox.Show("erreur de modification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("dataSource=localhost;port=3306;Database=bar;username=root;password=");
                connection.Open();
                MySqlCommand req = new MySqlCommand("delete from depenses where idDepense ='"+idDepense.Text+"'", connection);
                if (req.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("vous avez supprimee avec succees");
                }
                else
                {
                    MessageBox.Show("erreur de suppression");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void read_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("D:/DEVOIR/depenses.pdf", FileMode.Create));
            document.Open();

            Paragraph p = new Paragraph(idDepense.Text + " " + description.Text + " " + montant.Text + "FBu");
            document.Add(p);
            document.Close();
            MessageBox.Show("PDF a ete genere,Aller voir dans le repertoire D:/DEVOIR");
        }

        private void export_to_pdf_Click(object sender, EventArgs e)
        {
             
        }

        private void idDepense_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
