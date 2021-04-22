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

namespace Admin
{
    public partial class Admin : Form

    {
        string _connectionString = "server=127.0.0.1;user id = root; persistsecurityinfo=True;database=ppe";
        public Admin(String NiveauUtilisateur, String LeNomutilisateur)
        {
            InitializeComponent();
            label2.Text = LeNomutilisateur;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            MySqlConnection conn = new MySqlConnection(_connectionString);
            try

            {
                conn.Open();
                string sql = "Select * FROM user ;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader(); //Curseur
                while (rdr.Read())
                {
                    if (GridUsers.Columns.Count == 0)
                    {
                        //rb.AppendText(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2] + " -- " + rdr[3]);
                        //rb.AppendText(rdr[0].ToString());
                        GridUsers.Columns.Add("prenom", "Prenom");
                        GridUsers.Columns.Add("nom", "Nom");

                    }
                    GridUsers.Rows.Add(rdr[1], rdr[2]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close(); //Fermer la connexion
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Utilisateur MonFormUtilisateur = new Utilisateur();
            MonFormUtilisateur.ShowDialog();
            if (MonFormUtilisateur.DialogResult == DialogResult.OK)
            {
                GridUsers.Rows.Add(MonFormUtilisateur.StrPrenomUtilisateur, MonFormUtilisateur.StrNomUtilisateur);
            }
            else
                MonFormUtilisateur.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridUsers.SelectedRows)
            {

                string idDemande = GridUsers.Rows[row.Index].Cells[0].Value.ToString();
                Utilisateur MonFormUtilisateur = new Utilisateur(idDemande);
                MonFormUtilisateur.ShowDialog();
                if (MonFormUtilisateur.DialogResult == DialogResult.OK)
                {

                }
                else
                    MonFormUtilisateur.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridUsers.SelectedRows)
            {
                GridUsers.Rows.RemoveAt(row.Index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Utilisateur MonFormUtilisateur = new Utilisateur();
            MonFormUtilisateur.ShowDialog();
            if (MonFormUtilisateur.DialogResult == DialogResult.OK)
            {
                GridUsers.Rows.Add(MonFormUtilisateur.StrPrenomUtilisateur, MonFormUtilisateur.StrNomUtilisateur);
            }
            else
                MonFormUtilisateur.Close();
        }
    }
    }

