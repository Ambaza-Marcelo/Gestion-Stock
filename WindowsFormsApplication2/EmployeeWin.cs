﻿using System;
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
    public partial class EmployeeWin : Form
    {
        public EmployeeWin()
        {
            InitializeComponent();
        }

        private void EmployeeWin_Load(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("dataSource=localhost;port=3306;Database=bar;username=root;password=");
                connection.Open();
                MySqlCommand req = new MySqlCommand("insert into employees(idEmployee,nom,prenom,email,telephone,adresse,matricule) values('"+idEmployee.Text+"','"+nom.Text+"','"+prenom.Text+"','"+email.Text+"','"+telephone.Text+"','"+adresse.Text+"','"+matricule.Text+"')",connection);
                if(req.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("vous avez ajoutee l'employee avec succees");
                }else
                {
                    MessageBox.Show("erreur d'ajout");
                }
            }catch(Exception ex)
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
                MySqlCommand req = new MySqlCommand("update employees set nom = '"+nom.Text+"',prenom='"+prenom.Text+"',email='"+email.Text+"',telephone='"+telephone.Text+"',adresse='"+adresse.Text+"',matricule='"+matricule.Text+"'where idEmployee='"+ idEmployee.Text + "'", connection);
                if (req.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("vous avez modifiee l'employee avec succees");
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
                MySqlCommand req = new MySqlCommand("delete from employees where idEmployee='"+idEmployee.Text+ "'", connection);
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
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("D:/DEVOIR/produits.pdf", FileMode.Create));
            document.Open();

            Paragraph p = new Paragraph( nom.Text + " " + prenom.Text + " " + " " + email.Text + " " + telephone.Text + " " + adresse.Text + " " + matricule.Text);
            document.Add(p);
            document.Close();
            MessageBox.Show("PDF a ete genere,Aller voir dans le repertoire D:/DEVOIR");
        }

        private void idEmployee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
