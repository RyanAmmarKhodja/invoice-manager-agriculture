namespace StockIt_2.view.forms
{
    partial class choisir_transporteur
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
            trans_grid = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)trans_grid).BeginInit();
            SuspendLayout();
            // 
            // trans_grid
            // 
            trans_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            trans_grid.Location = new Point(12, 70);
            trans_grid.Name = "trans_grid";
            trans_grid.RowHeadersWidth = 62;
            trans_grid.Size = new Size(776, 317);
            trans_grid.TabIndex = 0;
            trans_grid.CellClick += trans_grid_CellClick;
            trans_grid.CellContentClick += trans_grid_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(591, 393);
            button1.Name = "button1";
            button1.Size = new Size(197, 34);
            button1.TabIndex = 1;
            button1.Text = "choisir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // choisir_transporteur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(trans_grid);
            Name = "choisir_transporteur";
            Text = "choisir_transporteur";
            Load += choisir_transporteur_Load;
            ((System.ComponentModel.ISupportInitialize)trans_grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView trans_grid;
        private Button button1;
    }
}