﻿namespace TrivialPursuit
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_motDePasse = new System.Windows.Forms.TextBox();
            this.txt_compte = new System.Windows.Forms.TextBox();
            this.btn_addJoueur = new System.Windows.Forms.Button();
            this.cmb_joueur1 = new System.Windows.Forms.ComboBox();
            this.cmb_joueur2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(76, 131);
            this.btn_start.Margin = new System.Windows.Forms.Padding(6);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(241, 84);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Joueur 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Joueur 2";
            // 
            // txt_motDePasse
            // 
            this.txt_motDePasse.Location = new System.Drawing.Point(529, 353);
            this.txt_motDePasse.Margin = new System.Windows.Forms.Padding(6);
            this.txt_motDePasse.Name = "txt_motDePasse";
            this.txt_motDePasse.PasswordChar = '•';
            this.txt_motDePasse.Size = new System.Drawing.Size(90, 29);
            this.txt_motDePasse.TabIndex = 7;
            this.txt_motDePasse.Text = "12";
            this.txt_motDePasse.Visible = false;
            // 
            // txt_compte
            // 
            this.txt_compte.Location = new System.Drawing.Point(529, 384);
            this.txt_compte.Margin = new System.Windows.Forms.Padding(6);
            this.txt_compte.Name = "txt_compte";
            this.txt_compte.Size = new System.Drawing.Size(90, 29);
            this.txt_compte.TabIndex = 8;
            this.txt_compte.Text = "bigbinotte";
            this.txt_compte.Visible = false;
            // 
            // btn_addJoueur
            // 
            this.btn_addJoueur.Location = new System.Drawing.Point(323, 264);
            this.btn_addJoueur.Name = "btn_addJoueur";
            this.btn_addJoueur.Size = new System.Drawing.Size(160, 61);
            this.btn_addJoueur.TabIndex = 9;
            this.btn_addJoueur.Text = "Ajouter Joueur";
            this.btn_addJoueur.UseVisualStyleBackColor = true;
            this.btn_addJoueur.Click += new System.EventHandler(this.btn_addJoueur_Click);
            // 
            // cmb_joueur1
            // 
            this.cmb_joueur1.FormattingEnabled = true;
            this.cmb_joueur1.Location = new System.Drawing.Point(100, 23);
            this.cmb_joueur1.Name = "cmb_joueur1";
            this.cmb_joueur1.Size = new System.Drawing.Size(260, 32);
            this.cmb_joueur1.TabIndex = 10;
            // 
            // cmb_joueur2
            // 
            this.cmb_joueur2.FormattingEnabled = true;
            this.cmb_joueur2.Location = new System.Drawing.Point(100, 73);
            this.cmb_joueur2.Name = "cmb_joueur2";
            this.cmb_joueur2.Size = new System.Drawing.Size(260, 32);
            this.cmb_joueur2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 417);
            this.Controls.Add(this.cmb_joueur2);
            this.Controls.Add(this.cmb_joueur1);
            this.Controls.Add(this.btn_addJoueur);
            this.Controls.Add(this.txt_compte);
            this.Controls.Add(this.txt_motDePasse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trivial Pursuit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_motDePasse;
        private System.Windows.Forms.TextBox txt_compte;
        private System.Windows.Forms.Button btn_addJoueur;
        private System.Windows.Forms.ComboBox cmb_joueur1;
        private System.Windows.Forms.ComboBox cmb_joueur2;
    }
}

