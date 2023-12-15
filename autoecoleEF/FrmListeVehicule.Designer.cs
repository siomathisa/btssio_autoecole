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
            this.dgvVehicule = new System.Windows.Forms.DataGridView();
            this.numImmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couleurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enEtatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bdgVehicules = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVehicules)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicule
            // 
            this.dgvVehicule.AutoGenerateColumns = false;
            this.dgvVehicule.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numImmaDataGridViewTextBoxColumn,
            this.modeleDataGridViewTextBoxColumn,
            this.couleurDataGridViewTextBoxColumn,
            this.enEtatDataGridViewTextBoxColumn});
            this.dgvVehicule.DataSource = this.bdgVehicules;
            this.dgvVehicule.Location = new System.Drawing.Point(172, 103);
            this.dgvVehicule.Name = "dgvVehicule";
            this.dgvVehicule.Size = new System.Drawing.Size(443, 150);
            this.dgvVehicule.TabIndex = 0;
            this.dgvVehicule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicule_CellContentClick);
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
            this.enEtatDataGridViewTextBoxColumn.FalseValue = "0";
            this.enEtatDataGridViewTextBoxColumn.HeaderText = "enEtat";
            this.enEtatDataGridViewTextBoxColumn.Name = "enEtatDataGridViewTextBoxColumn";
            this.enEtatDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.enEtatDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.enEtatDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // bdgVehicules
            // 
            this.bdgVehicules.DataSource = typeof(autoecoleEF.vehicule);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnregistrer.Location = new System.Drawing.Point(335, 259);
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
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dgvVehicule);
            this.Name = "FrmListeVehicule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListeVehicule";
            this.Load += new System.EventHandler(this.FrmListeVehicule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVehicules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdgVehicules;
        private System.Windows.Forms.DataGridView dgvVehicule;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn numImmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn couleurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enEtatDataGridViewTextBoxColumn;
    }
}