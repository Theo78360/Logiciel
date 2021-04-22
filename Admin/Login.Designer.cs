
namespace Admin
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ltb = new System.Windows.Forms.TextBox();
            this.mtb = new System.Windows.Forms.TextBox();
            this.bta = new System.Windows.Forms.Button();
            this.btv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // ltb
            // 
            this.ltb.Location = new System.Drawing.Point(316, 92);
            this.ltb.Name = "ltb";
            this.ltb.Size = new System.Drawing.Size(138, 20);
            this.ltb.TabIndex = 2;
            // 
            // mtb
            // 
            this.mtb.Location = new System.Drawing.Point(316, 157);
            this.mtb.Name = "mtb";
            this.mtb.Size = new System.Drawing.Size(138, 20);
            this.mtb.TabIndex = 3;
            // 
            // bta
            // 
            this.bta.Location = new System.Drawing.Point(173, 225);
            this.bta.Name = "bta";
            this.bta.Size = new System.Drawing.Size(75, 23);
            this.bta.TabIndex = 4;
            this.bta.Text = "Annuler";
            this.bta.UseVisualStyleBackColor = true;
            this.bta.Click += new System.EventHandler(this.bta_Click);
            // 
            // btv
            // 
            this.btv.Location = new System.Drawing.Point(379, 225);
            this.btv.Name = "btv";
            this.btv.Size = new System.Drawing.Size(75, 23);
            this.btv.TabIndex = 5;
            this.btv.Text = "Valider";
            this.btv.UseVisualStyleBackColor = true;
            this.btv.Click += new System.EventHandler(this.btv_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.btv);
            this.Controls.Add(this.bta);
            this.Controls.Add(this.mtb);
            this.Controls.Add(this.ltb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Bienvenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ltb;
        private System.Windows.Forms.TextBox mtb;
        private System.Windows.Forms.Button bta;
        private System.Windows.Forms.Button btv;
    }
}

