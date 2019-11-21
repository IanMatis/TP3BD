namespace TrivialPursuit
{
    partial class frm_ajouter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_alias = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.lbl_erreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // txt_alias
            // 
            this.txt_alias.Location = new System.Drawing.Point(138, 23);
            this.txt_alias.Name = "txt_alias";
            this.txt_alias.Size = new System.Drawing.Size(243, 29);
            this.txt_alias.TabIndex = 3;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(138, 83);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(243, 29);
            this.txt_prenom.TabIndex = 4;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(138, 147);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(243, 29);
            this.txt_nom.TabIndex = 5;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(84, 205);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(228, 62);
            this.btn_ajouter.TabIndex = 6;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // lbl_erreur
            // 
            this.lbl_erreur.AutoSize = true;
            this.lbl_erreur.ForeColor = System.Drawing.Color.Red;
            this.lbl_erreur.Location = new System.Drawing.Point(53, 179);
            this.lbl_erreur.Name = "lbl_erreur";
            this.lbl_erreur.Size = new System.Drawing.Size(313, 24);
            this.lbl_erreur.TabIndex = 7;
            this.lbl_erreur.Text = "Vous devez remplir les trois champs";
            this.lbl_erreur.Visible = false;
            // 
            // frm_ajouter
            // 
            this.AcceptButton = this.btn_ajouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 279);
            this.Controls.Add(this.lbl_erreur);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_alias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_ajouter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un Joueur";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ajouter_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_alias;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label lbl_erreur;
    }
}