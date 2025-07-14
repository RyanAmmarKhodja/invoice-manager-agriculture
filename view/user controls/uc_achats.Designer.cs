namespace StockIt_2
{
    partial class uc_achats
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
            creer_fournisseur = new Button();
            bon_reception = new Button();
            label1 = new Label();
            retour = new Button();
            button1 = new Button();
            button2 = new Button();
            transporteurBtn = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // creer_fournisseur
            // 
            creer_fournisseur.Font = new Font("Segoe UI", 10F);
            creer_fournisseur.Location = new Point(35, 180);
            creer_fournisseur.Name = "creer_fournisseur";
            creer_fournisseur.Size = new Size(295, 48);
            creer_fournisseur.TabIndex = 0;
            creer_fournisseur.Text = "Créer un fournisseur";
            creer_fournisseur.UseVisualStyleBackColor = true;
            creer_fournisseur.Click += fournisseur_Click;
            // 
            // bon_reception
            // 
            bon_reception.Font = new Font("Segoe UI", 10F);
            bon_reception.Location = new Point(35, 95);
            bon_reception.Name = "bon_reception";
            bon_reception.Size = new Size(295, 48);
            bon_reception.TabIndex = 1;
            bon_reception.Text = "Créer un bon de récéption";
            bon_reception.UseVisualStyleBackColor = true;
            bon_reception.Click += bon_reception_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 2;
            label1.Text = "Accueil/ Achats";
            // 
            // retour
            // 
            retour.Location = new Point(35, 393);
            retour.Name = "retour";
            retour.Size = new Size(112, 34);
            retour.TabIndex = 3;
            retour.Text = "Retour";
            retour.UseVisualStyleBackColor = true;
            retour.Click += retour_Click;
            // 
            // button1
            // 
            button1.Location = new Point(346, 180);
            button1.Name = "button1";
            button1.Size = new Size(46, 48);
            button1.TabIndex = 4;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(346, 249);
            button2.Name = "button2";
            button2.Size = new Size(46, 48);
            button2.TabIndex = 6;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            // 
            // transporteurBtn
            // 
            transporteurBtn.Font = new Font("Segoe UI", 10F);
            transporteurBtn.Location = new Point(35, 249);
            transporteurBtn.Name = "transporteurBtn";
            transporteurBtn.Size = new Size(295, 48);
            transporteurBtn.TabIndex = 5;
            transporteurBtn.Text = "Créer un transporteur";
            transporteurBtn.UseVisualStyleBackColor = true;
            transporteurBtn.Click += transporteurBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(647, 32);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 7;
            button3.Text = "Testing ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // uc_achats
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(transporteurBtn);
            Controls.Add(button1);
            Controls.Add(retour);
            Controls.Add(label1);
            Controls.Add(bon_reception);
            Controls.Add(creer_fournisseur);
            Name = "uc_achats";
            Size = new Size(800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button creer_fournisseur;
        private Button bon_reception;
        private Label label1;
        private Button retour;
        private Button button1;
        private Button button2;
        private Button transporteurBtn;
        private Button button3;
    }
}
