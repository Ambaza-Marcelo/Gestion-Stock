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
    public partial class ProduitWin : Form
    {
        public ProduitWin()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("dataSource=localhost;port=3306;Database=bar;username=root;password=");
                connection.Open();
                MySqlCommand req = new MySqlCommand("insert into produit(idProduit,nom,prix_unitaire,quantite) values('"+idProduit.Text+"','"+nom.Text+"','"+prix_unitaire.Text+"','"+quantite.Text+ "')", connection);
                if (req.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("vous avez ajoutee le produit avec succees");
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
                MySqlCommand req = new MySqlCommand("update produit set nom ='"+nom.Text+"',prix_unitaire='"+prix_unitaire.Text+"',quantite='"+quantite.Text+"'where idProduit ='"+idProduit.Text+"'", connection);
                if (req.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("vous avez modifiee le produit avec succees");
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
                MySqlCommand req = new MySqlCommand("delete from produit where idProduit ='" + idProduit.Text + "'", connection);
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
            PdfWriter.GetInstance(document, new FileStream("D:/DEVOIR/produits.pdf", FileMode.Create));
            document.Open();

            Paragraph p = new Paragraph(idProduit.Text + " " + nom.Text + " " + prix_unitaire.Text + " " + quantite.Text);
            document.Add(p);
            document.Close();
            MessageBox.Show("PDF a ete genere,Aller voir dans le repertoire D:/DEVOIR");
        }

        private void idProduit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
