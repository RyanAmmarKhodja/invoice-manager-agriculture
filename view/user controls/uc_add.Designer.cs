namespace StockIt_2.view.user_controls
{
    partial class uc_add
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
            button1 = new Button();
            label3 = new Label();
            field = new TextBox();
            label2 = new Label();
            name = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(635, 393);
            button1.Name = "button1";
            button1.Size = new Size(253, 42);
            button1.TabIndex = 25;
            button1.Text = "Ajouter fournisseur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(46, 14);
            label3.Name = "label3";
            label3.Size = new Size(275, 32);
            label3.TabIndex = 24;
            label3.Text = "Ajouter un fournisseur";
            // 
            // field
            // 
            field.Location = new Point(590, 90);
            field.Name = "field";
            field.Size = new Size(298, 31);
            field.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(470, 87);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 22;
            label2.Text = "Prénom :";
            // 
            // name
            // 
            name.Location = new Point(124, 90);
            name.Name = "name";
            name.Size = new Size(298, 31);
            name.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(46, 87);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 20;
            label1.Text = "Nom :";
            // 
            // uc_add
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(field);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "uc_add";
            Size = new Size(965, 555);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private TextBox field;
        private Label label2;
        private TextBox name;
        private Label label1;
    }
}
