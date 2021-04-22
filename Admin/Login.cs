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
    public partial class Login : Form
    {
        string _connectionString = "server=127.0.0.1;user id = root; persistsecurityinfo=True;database=ppe";
        public String StrLevel = "Inconnu";
        public String NomUtilisateur = "Inconnu";
        public Login()
        {
            InitializeComponent();
        }

        private void bta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btv_Click(object sender, EventArgs e)
        {


            if (ltb.Text == "" || mtb.Text == "")
            {
                MessageBox.Show("Les champs sont vides!");
                return;
            }

            try
            {

                string idu = "";
                string nom = "";
                string motdepasse = "";
                string lvl = "";

                MySqlConnection conn = new MySqlConnection(_connectionString);
                conn.Open();

                nom = ltb.Text;
                motdepasse = (SHA.petitsha(mtb.Text));

                string sql = $"SELECT idu, nom, lvl FROM user WHERE nom = '{nom}' AND mdp = '{motdepasse}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        idu = rdr[0].ToString();
                        nom = rdr[1].ToString();
                        lvl = rdr[2].ToString();
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else MessageBox.Show("Identifiants incorrects");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


    }
}
    
    

