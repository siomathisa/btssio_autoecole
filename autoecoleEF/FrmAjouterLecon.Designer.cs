namespace autoecoleEF
{
    partial class FrmAjouterLecon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEleve = new System.Windows.Forms.ComboBox();
            this.bdgEleve = new System.Windows.Forms.BindingSource(this.components);
            this.dtLecon = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cmbHeure = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eleve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Heure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durée";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbEleve
            // 
            this.cmbEleve.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgEleve, "nom", true));
            this.cmbEleve.DataSource = this.bdgEleve;
            this.cmbEleve.DisplayMember = "nom";
            this.cmbEleve.FormattingEnabled = true;
            this.cmbEleve.Location = new System.Drawing.Point(241, 68);
            this.cmbEleve.Name = "cmbEleve";
            this.cmbEleve.Size = new System.Drawing.Size(121, 21);
            this.cmbEleve.TabIndex = 4;
            // 
            // bdgEleve
            // 
            this.bdgEleve.DataSource = typeof(autoecoleEF.eleve);
            // 
            // dtLecon
            // 
            this.dtLecon.Location = new System.Drawing.Point(241, 95);
            this.dtLecon.Name = "dtLecon";
            this.dtLecon.Size = new System.Drawing.Size(200, 20);
            this.dtLecon.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(241, 148);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Une heure";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(332, 148);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Deux heures";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(241, 186);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(104, 21);
            this.btnEnregistrer.TabIndex = 8;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // cmbHeure
            // 
            this.cmbHeure.FormattingEnabled = true;
            this.cmbHeure.Location = new System.Drawing.Point(241, 121);
            this.cmbHeure.Name = "cmbHeure";
            this.cmbHeure.Size = new System.Drawing.Size(121, 21);
            this.cmbHeure.TabIndex = 9;
            // 
            // FrmAjouterLecon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbHeure);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dtLecon);
            this.Controls.Add(this.cmbEleve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjouterLecon";
            this.Text = "FrmGererLecon";
            this.Load += new System.EventHandler(this.FrmAjouterLecon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEleve;
        private System.Windows.Forms.DateTimePicker dtLecon;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ComboBox cmbHeure;
        private System.Windows.Forms.BindingSource bdgEleve;
    }
}