using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Utilisateur : Form
    {
        public string StrNomUtilisateur = "";
        public string StrPrenomUtilisateur = "";
        public Utilisateur()
        {
            InitializeComponent();
        }
        public Utilisateur(String idUtilisateur)
        {
            InitializeComponent();
            tbTD.Text = idUtilisateur;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.StrNomUtilisateur =tbnom.Text;
            this.StrPrenomUtilisateur = tbprenom.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
