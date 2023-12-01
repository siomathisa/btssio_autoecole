namespace autoecoleEF
{
    partial class FrmListeVehicule
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
            this.components = new System.ComponentModel.Container();
            this.bdgVehicules = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVehicule = new System.Windows.Forms.DataGridView();
            this.numImmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couleurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enEtatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVehicules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicule)).BeginInit();
            this.SuspendLayout();
            // 
            // bdgVehicules
            // 
            this.bdgVehicules.DataSource = typeof(autoecoleEF.vehicule);
            // 
            // dgvVehicule
            // 
            this.dgvVehicule.AutoGenerateColumns = false;
            this.dgvVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numImmaDataGridViewTextBoxColumn,
            this.modeleDataGridViewTextBoxColumn,
            this.couleurDataGridViewTextBoxColumn,
            this.enEtatDataGridViewTextBoxColumn});
            this.dgvVehicule.DataSource = this.bdgVehicules;
            this.dgvVehicule.Location = new System.Drawing.Point(146, 90);
            this.dgvVehicule.Name = "dgvVehicule";
            this.dgvVehicule.Size = new System.Drawing.Size(443, 150);
            this.dgvVehicule.TabIndex = 0;
            // 
            // numImmaDataGridViewTextBoxColumn
            // 
            this.numImmaDataGridViewTextBoxColumn.DataPropertyName = "numImma";
            this.numImmaDataGridViewTextBoxColumn.HeaderText = "numImma";
            this.numImmaDataGridViewTextBoxColumn.Name = "numImmaDataGridViewTextBoxColumn";
            this.numImmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeleDataGridViewTextBoxColumn
            // 
            this.modeleDataGridViewTextBoxColumn.DataPropertyName = "modele";
            this.modeleDataGridViewTextBoxColumn.HeaderText = "modele";
            this.modeleDataGridViewTextBoxColumn.Name = "modeleDataGridViewTextBoxColumn";
            this.modeleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // couleurDataGridViewTextBoxColumn
            // 
            this.couleurDataGridViewTextBoxColumn.DataPropertyName = "couleur";
            this.couleurDataGridViewTextBoxColumn.HeaderText = "couleur";
            this.couleurDataGridViewTextBoxColumn.Name = "couleurDataGridViewTextBoxColumn";
            this.couleurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enEtatDataGridViewTextBoxColumn
            // 
            this.enEtatDataGridViewTextBoxColumn.DataPropertyName = "enEtat";
            this.enEtatDataGridViewTextBoxColumn.HeaderText = "enEtat";
            this.enEtatDataGridViewTextBoxColumn.Name = "enEtatDataGridViewTextBoxColumn";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnregistrer.Location = new System.Drawing.Point(146, 278);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(119, 31);
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // FrmListeVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dgvVehicule);
            this.Name = "FrmListeVehicule";
            this.Text = "FrmListeVehicule";
            this.Load += new System.EventHandler(this.FrmListeVehicule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgVehicules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdgVehicules;
        private System.Windows.Forms.DataGridView dgvVehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn numImmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn couleurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enEtatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}