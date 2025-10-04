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
            label1 = new Label();
            retour = new Button();
            button3 = new Button();
            kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            transporteurBtn = new Button();
            gerer_transporteur = new Button();
            gerer_fournisseur = new Button();
            creer_fournisseur = new Button();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            bon_reception = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 2;
            label1.Text = "Accueil/ Achats";
            // 
            // retour
            // 
            retour.Location = new Point(3, 405);
            retour.Name = "retour";
            retour.Size = new Size(295, 39);
            retour.TabIndex = 3;
            retour.Text = "Retour";
            retour.UseVisualStyleBackColor = true;
            retour.Click += retour_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(43, 34);
            button3.TabIndex = 7;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // transporteurBtn
            // 
            transporteurBtn.Font = new Font("Segoe UI", 10F);
            transporteurBtn.Location = new Point(3, 219);
            transporteurBtn.Name = "transporteurBtn";
            transporteurBtn.Size = new Size(295, 48);
            transporteurBtn.TabIndex = 5;
            transporteurBtn.Text = "Créer un transporteur";
            transporteurBtn.UseVisualStyleBackColor = true;
            transporteurBtn.Click += transporteurBtn_Click;
            // 
            // gerer_transporteur
            // 
            gerer_transporteur.Location = new Point(301, 220);
            gerer_transporteur.Name = "gerer_transporteur";
            gerer_transporteur.Size = new Size(250, 48);
            gerer_transporteur.TabIndex = 6;
            gerer_transporteur.Text = "Gérer les transpoteurs";
            gerer_transporteur.UseVisualStyleBackColor = true;
            gerer_transporteur.Click += gerer_transporteur_Click;
            // 
            // gerer_fournisseur
            // 
            gerer_fournisseur.Location = new Point(301, 166);
            gerer_fournisseur.Name = "gerer_fournisseur";
            gerer_fournisseur.Size = new Size(250, 48);
            gerer_fournisseur.TabIndex = 4;
            gerer_fournisseur.Text = "Gérer les fournisseurs";
            gerer_fournisseur.UseVisualStyleBackColor = true;
            gerer_fournisseur.Click += gerer_fournisseurs_Click;
            // 
            // creer_fournisseur
            // 
            creer_fournisseur.Font = new Font("Segoe UI", 10F);
            creer_fournisseur.Location = new Point(3, 165);
            creer_fournisseur.Name = "creer_fournisseur";
            creer_fournisseur.Size = new Size(295, 48);
            creer_fournisseur.TabIndex = 0;
            creer_fournisseur.Text = "Créer un fournisseur";
            creer_fournisseur.UseVisualStyleBackColor = true;
            creer_fournisseur.Click += fournisseur_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(bon_reception);
            kryptonPanel1.Controls.Add(gerer_transporteur);
            kryptonPanel1.Controls.Add(label1);
            kryptonPanel1.Controls.Add(button3);
            kryptonPanel1.Controls.Add(gerer_fournisseur);
            kryptonPanel1.Controls.Add(retour);
            kryptonPanel1.Controls.Add(creer_fournisseur);
            kryptonPanel1.Controls.Add(transporteurBtn);
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(691, 450);
            kryptonPanel1.TabIndex = 9;
            // 
            // bon_reception
            // 
            bon_reception.Location = new Point(3, 56);
            bon_reception.Name = "bon_reception";
            bon_reception.Size = new Size(295, 65);
            bon_reception.TabIndex = 8;
            bon_reception.Values.DropDownArrowColor = Color.Empty;
            bon_reception.Values.Text = "Créer un bon de récéption";
            bon_reception.Click += bon_reception_Click;
            // 
            // uc_achats
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonPanel1);
            Name = "uc_achats";
            Size = new Size(691, 450);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button retour;
        private Button button3;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Button transporteurBtn;
        private Button gerer_transporteur;
        private Button gerer_fournisseur;
        private Button creer_fournisseur;
       // private Button bon_reception;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton bon_reception;
    }
}
