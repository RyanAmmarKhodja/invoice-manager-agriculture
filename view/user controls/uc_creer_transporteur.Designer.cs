namespace StockIt_2.user_controls
{
    partial class uc_creer_transporteur
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            retour = new Button();
            button1 = new Button();
            tel = new TextBox();
            label8 = new Label();
            matricule = new TextBox();
            label4 = new Label();
            label3 = new Label();
            prenom = new TextBox();
            label2 = new Label();
            nom = new TextBox();
            label1 = new Label();
            adresse = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // retour
            // 
            retour.Font = new Font("Segoe UI", 12F);
            retour.Location = new Point(18, 580);
            retour.Name = "retour";
            retour.Size = new Size(149, 42);
            retour.TabIndex = 42;
            retour.Text = "Retour";
            retour.UseVisualStyleBackColor = true;
            retour.Click += retour_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(611, 580);
            button1.Name = "button1";
            button1.Size = new Size(253, 42);
            button1.TabIndex = 41;
            button1.Text = "Ajouter transporteur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tel
            // 
            tel.Location = new Point(150, 243);
            tel.Name = "tel";
            tel.Size = new Size(357, 31);
            tel.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(18, 240);
            label8.Name = "label8";
            label8.Size = new Size(62, 32);
            label8.TabIndex = 35;
            label8.Text = "TEL :";
            // 
            // matricule
            // 
            matricule.Location = new Point(150, 193);
            matricule.Name = "matricule";
            matricule.Size = new Size(357, 31);
            matricule.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(18, 190);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 27;
            label4.Text = "Matricule :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(18, 20);
            label3.Name = "label3";
            label3.Size = new Size(290, 32);
            label3.TabIndex = 26;
            label3.Text = "Ajouter un transporteur";
            // 
            // prenom
            // 
            prenom.Location = new Point(562, 96);
            prenom.Name = "prenom";
            prenom.Size = new Size(315, 31);
            prenom.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(442, 93);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 24;
            label2.Text = "Prénom :";
            // 
            // nom
            // 
            nom.Location = new Point(96, 96);
            nom.Name = "nom";
            nom.Size = new Size(298, 31);
            nom.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(18, 93);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 22;
            label1.Text = "Nom :";
            // 
            // adresse
            // 
            adresse.Location = new Point(150, 147);
            adresse.Name = "adresse";
            adresse.Size = new Size(727, 31);
            adresse.TabIndex = 44;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(18, 144);
            label11.Name = "label11";
            label11.Size = new Size(109, 32);
            label11.TabIndex = 43;
            label11.Text = "Adresse :";
            // 
            // uc_creer_transporteur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(adresse);
            Controls.Add(label11);
            Controls.Add(retour);
            Controls.Add(button1);
            Controls.Add(tel);
            Controls.Add(label8);
            Controls.Add(matricule);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(prenom);
            Controls.Add(label2);
            Controls.Add(nom);
            Controls.Add(label1);
            Name = "uc_creer_transporteur";
            Size = new Size(1000, 750);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button retour;
        private Button button1;
        private TextBox tel;
        private Label label8;
        private TextBox matricule;
        private Label label4;
        private Label label3;
        private TextBox prenom;
        private Label label2;
        private TextBox nom;
        private Label label1;
        private TextBox adresse;
        private Label label11;
    }
}
