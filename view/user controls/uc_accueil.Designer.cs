namespace StockIt_2.user_controls
{
    partial class uc_accueil
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
            achatsBtn = new Button();
            ventesBtn = new Button();
            inventaireBtn = new Button();
            SuspendLayout();
            // 
            // achatsBtn
            // 
            achatsBtn.Font = new Font("Segoe UI", 12F);
            achatsBtn.Location = new Point(35, 40);
            achatsBtn.Name = "achatsBtn";
            achatsBtn.Size = new Size(183, 57);
            achatsBtn.TabIndex = 0;
            achatsBtn.Text = "Achats";
            achatsBtn.UseVisualStyleBackColor = true;
            achatsBtn.Click += achatsBtn_Click;
            // 
            // ventesBtn
            // 
            ventesBtn.Font = new Font("Segoe UI", 12F);
            ventesBtn.Location = new Point(35, 125);
            ventesBtn.Name = "ventesBtn";
            ventesBtn.Size = new Size(183, 57);
            ventesBtn.TabIndex = 1;
            ventesBtn.Text = "Ventes";
            ventesBtn.UseVisualStyleBackColor = true;
            // 
            // inventaireBtn
            // 
            inventaireBtn.Font = new Font("Segoe UI", 12F);
            inventaireBtn.Location = new Point(35, 211);
            inventaireBtn.Name = "inventaireBtn";
            inventaireBtn.Size = new Size(183, 57);
            inventaireBtn.TabIndex = 2;
            inventaireBtn.Text = "Inventaire";
            inventaireBtn.UseVisualStyleBackColor = true;
            // 
            // uc_accueil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(inventaireBtn);
            Controls.Add(ventesBtn);
            Controls.Add(achatsBtn);
            Name = "uc_accueil";
            Size = new Size(800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Button achatsBtn;
        private Button ventesBtn;
        private Button inventaireBtn;
    }
}
