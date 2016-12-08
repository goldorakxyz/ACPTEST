namespace TestEmulator
{
    partial class MenuSelectionOrganisme
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
            this.btnMenuNouvelOrganisme = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSélectionOrganism = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenuNouvelOrganisme
            // 
            this.btnMenuNouvelOrganisme.Location = new System.Drawing.Point(627, 12);
            this.btnMenuNouvelOrganisme.Name = "btnMenuNouvelOrganisme";
            this.btnMenuNouvelOrganisme.Size = new System.Drawing.Size(191, 23);
            this.btnMenuNouvelOrganisme.TabIndex = 0;
            this.btnMenuNouvelOrganisme.Text = "Créer un nouvel organisme";
            this.btnMenuNouvelOrganisme.UseVisualStyleBackColor = true;
            this.btnMenuNouvelOrganisme.Click += new System.EventHandler(this.btnMenuNouvelOrganisme_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 513);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom de l\'entreprise";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numéro d\'organisme";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Débit";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Crédit";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // btnSélectionOrganism
            // 
            this.btnSélectionOrganism.Location = new System.Drawing.Point(627, 549);
            this.btnSélectionOrganism.Name = "btnSélectionOrganism";
            this.btnSélectionOrganism.Size = new System.Drawing.Size(191, 23);
            this.btnSélectionOrganism.TabIndex = 2;
            this.btnSélectionOrganism.Text = "Accéder l\'organisme";
            this.btnSélectionOrganism.UseVisualStyleBackColor = true;
            // 
            // MenuSelectionOrganisme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 611);
            this.Controls.Add(this.btnSélectionOrganism);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMenuNouvelOrganisme);
            this.Name = "MenuSelectionOrganisme";
            this.Text = "Sélection d\'organisme";
            this.Activated += new System.EventHandler(this.display);
            this.Load += new System.EventHandler(this.MenuSelectionOrganisme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuNouvelOrganisme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.Button btnSélectionOrganism;
    }
}