namespace TrivialPursuit
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
            this.txt_joueur1 = new System.Windows.Forms.TextBox();
            this.txt_joueur2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_motDePasse = new System.Windows.Forms.TextBox();
            this.txt_compte = new System.Windows.Forms.TextBox();
            this.lbl_test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(75, 211);
            this.btn_start.Margin = new System.Windows.Forms.Padding(6);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(241, 84);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_joueur1
            // 
            this.txt_joueur1.Location = new System.Drawing.Point(151, 120);
            this.txt_joueur1.Margin = new System.Windows.Forms.Padding(6);
            this.txt_joueur1.Name = "txt_joueur1";
            this.txt_joueur1.Size = new System.Drawing.Size(259, 29);
            this.txt_joueur1.TabIndex = 1;
            // 
            // txt_joueur2
            // 
            this.txt_joueur2.Location = new System.Drawing.Point(151, 170);
            this.txt_joueur2.Margin = new System.Windows.Forms.Padding(6);
            this.txt_joueur2.Name = "txt_joueur2";
            this.txt_joueur2.Size = new System.Drawing.Size(259, 29);
            this.txt_joueur2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Joueur 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Joueur 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mot de passe";
            // 
            // txt_motDePasse
            // 
            this.txt_motDePasse.Location = new System.Drawing.Point(151, 67);
            this.txt_motDePasse.Margin = new System.Windows.Forms.Padding(6);
            this.txt_motDePasse.Name = "txt_motDePasse";
            this.txt_motDePasse.Size = new System.Drawing.Size(259, 29);
            this.txt_motDePasse.TabIndex = 7;
            // 
            // txt_compte
            // 
            this.txt_compte.Location = new System.Drawing.Point(151, 14);
            this.txt_compte.Margin = new System.Windows.Forms.Padding(6);
            this.txt_compte.Name = "txt_compte";
            this.txt_compte.Size = new System.Drawing.Size(259, 29);
            this.txt_compte.TabIndex = 8;
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Location = new System.Drawing.Point(335, 241);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(38, 24);
            this.lbl_test.TabIndex = 9;
            this.lbl_test.Text = "test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 302);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.txt_compte);
            this.Controls.Add(this.txt_motDePasse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_joueur2);
            this.Controls.Add(this.txt_joueur1);
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
        private System.Windows.Forms.TextBox txt_joueur1;
        private System.Windows.Forms.TextBox txt_joueur2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_motDePasse;
        private System.Windows.Forms.TextBox txt_compte;
        private System.Windows.Forms.Label lbl_test;
    }
}

