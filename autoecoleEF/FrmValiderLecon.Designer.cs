namespace autoecoleEF
{
    partial class FrmValiderLecon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectueeOuiNonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numImmaVehiculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdgSvehicule = new System.Windows.Forms.BindingSource(this.components);
            this.bdgSlecon = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSvehicule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSlecon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.idEleveDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn,
            this.dureeDataGridViewTextBoxColumn,
            this.effectueeOuiNonDataGridViewTextBoxColumn,
            this.numImmaVehiculeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdgSlecon;
            this.dataGridView1.Location = new System.Drawing.Point(70, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnregistrer.Location = new System.Drawing.Point(330, 314);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(119, 38);
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.Text = "Valider";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // idEleveDataGridViewTextBoxColumn
            // 
            this.idEleveDataGridViewTextBoxColumn.DataPropertyName = "idEleve";
            this.idEleveDataGridViewTextBoxColumn.HeaderText = "idEleve";
            this.idEleveDataGridViewTextBoxColumn.Name = "idEleveDataGridViewTextBoxColumn";
            // 
            // heureDataGridViewTextBoxColumn
            // 
            this.heureDataGridViewTextBoxColumn.DataPropertyName = "heure";
            this.heureDataGridViewTextBoxColumn.HeaderText = "heure";
            this.heureDataGridViewTextBoxColumn.Name = "heureDataGridViewTextBoxColumn";
            // 
            // dureeDataGridViewTextBoxColumn
            // 
            this.dureeDataGridViewTextBoxColumn.DataPropertyName = "duree";
            this.dureeDataGridViewTextBoxColumn.HeaderText = "duree";
            this.dureeDataGridViewTextBoxColumn.Name = "dureeDataGridViewTextBoxColumn";
            // 
            // effectueeOuiNonDataGridViewTextBoxColumn
            // 
            this.effectueeOuiNonDataGridViewTextBoxColumn.DataPropertyName = "effectueeOui_Non";
            this.effectueeOuiNonDataGridViewTextBoxColumn.FalseValue = "Non";
            this.effectueeOuiNonDataGridViewTextBoxColumn.HeaderText = "effectueeOui_Non";
            this.effectueeOuiNonDataGridViewTextBoxColumn.Name = "effectueeOuiNonDataGridViewTextBoxColumn";
            this.effectueeOuiNonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.effectueeOuiNonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.effectueeOuiNonDataGridViewTextBoxColumn.TrueValue = "Oui";
            // 
            // numImmaVehiculeDataGridViewTextBoxColumn
            // 
            this.numImmaVehiculeDataGridViewTextBoxColumn.DataPropertyName = "numImmaVehicule";
            this.numImmaVehiculeDataGridViewTextBoxColumn.DataSource = this.bdgSvehicule;
            this.numImmaVehiculeDataGridViewTextBoxColumn.DisplayMember = "numImma";
            this.numImmaVehiculeDataGridViewTextBoxColumn.HeaderText = "numImmaVehicule";
            this.numImmaVehiculeDataGridViewTextBoxColumn.Name = "numImmaVehiculeDataGridViewTextBoxColumn";
            this.numImmaVehiculeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numImmaVehiculeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.numImmaVehiculeDataGridViewTextBoxColumn.ValueMember = "numImma";
            // 
            // bdgSvehicule
            // 
            this.bdgSvehicule.DataSource = typeof(autoecoleEF.vehicule);
            // 
            // bdgSlecon
            // 
            this.bdgSlecon.DataSource = typeof(autoecoleEF.lecon);
            // 
            // FrmValiderLecon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmValiderLecon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmValiderLecon";
            this.Load += new System.EventHandler(this.FrmValiderLecon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSvehicule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSlecon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdgSlecon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bdgSvehicule;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEleveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn effectueeOuiNonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn numImmaVehiculeDataGridViewTextBoxColumn;
    }
}