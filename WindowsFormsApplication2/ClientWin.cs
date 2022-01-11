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
    public partial class ClientWin : Form
    {
        public ClientWin()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("dataSource=localhost;port=3306;Database=bar;username=root;password=");
                connection.Open();
                MySqlCommand req = new MySqlCommand("insert into clients(idClient,nom,prenom,email,telephone,adresse) values('" + idClient.Text + "','" + nom.Text + "','" + prenom.Text + "','" + email.Text + "','" + telephone.Text + "','" + adresse.Text + "')", connection);
                if (req.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("vous avez ajoutee l'employee avec succees");
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
                MySqlCommand req = new MySqlCommand("update clients set nom = '" + nom.Text + "',prenom='" + prenom.Text + "',email='" + email.Text + "',telephone='" + telephone.Text + "',adresse='" + adresse.Text + "'where idClient='" + idClient.Text + "'", connection);
                if (req.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("vous avez modifiee le client avec succees");
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
                MySqlCommand req = new MySqlCommand("delete from clients where idClient='"+idClient.Text+ "'", connection);
                if (req.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("vous avez supprimee avec succees");
                }
                else
                {
                    MessageBox.Show("erreur de supression");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void read_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("dataSource = localhost;port=3306;Database = bar;username=root;password =");
                connection.Open();
                DataSet ds = new DataSet();
                MySqlDataAdapter req = new MySqlDataAdapter("select * from clients", connection);
                req.Fill(ds, "req");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "req";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void idClient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
