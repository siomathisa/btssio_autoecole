using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoecoleEF
{
    public partial class FrmValiderLecon : Form
    {
        private autoEcoleEntities mesDonneesEF;
        public FrmValiderLecon(autoEcoleEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = new autoEcoleEntities();
            this.mesDonneesEF = mesDonneesEF;
            this.dataGridView1.AutoGenerateColumns = false;

            //creation source donnees
            var lesLecons = from l in mesDonneesEF.lecon
                            where l.effectueeOui_Non == 0
                            select l;

            this.bdgSlecon.DataSource = lesLecons.ToList();

            this.bdgSvehicule.DataSource = mesDonneesEF.vehicule.ToList();

            DataGridViewTextBoxColumn txtColonneDate = new DataGridViewTextBoxColumn();
            txtColonneDate.HeaderText = "date";
            txtColonneDate.Name = "date";
            txtColonneDate.DataPropertyName = "date";
            this.dataGridView1.Columns.Add(txtColonneDate);

            DataGridViewTextBoxColumn txtColonneHeure = new DataGridViewTextBoxColumn();
            txtColonneHeure.HeaderText = "heure";
            txtColonneHeure.Name = "heure";
            txtColonneHeure.DataPropertyName = "heure";
            this.dataGridView1.Columns.Add(txtColonneHeure);

            DataGridViewComboBoxColumn cmbColonneVehicule = new DataGridViewComboBoxColumn();
            cmbColonneVehicule.HeaderText = "vehicule";
            cmbColonneVehicule.Name = "vehicule";
            cmbColonneVehicule.DisplayMember = "numImma";
            cmbColonneVehicule.DataPropertyName = "numImmaVehicule";
            cmbColonneVehicule.DataSource = this.bdgSvehicule;
            this.dataGridView1.Columns.Add(cmbColonneVehicule);

            DataGridViewCheckBoxColumn chkColonneOk = new DataGridViewCheckBoxColumn();
            chkColonneOk.HeaderText = "effectuee";
            chkColonneOk.Name = "effectuee";
            chkColonneOk.DataPropertyName = "effectueeOui_Non";
            this.dataGridView1.Columns.Add(chkColonneOk);
            this.dataGridView1.DataSource = this.bdgSlecon;
        }

        private void FrmValiderLecon_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btnEnregistrer, "Valider la leçon");
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.bdgSlecon.EndEdit();
            this.mesDonneesEF.SaveChanges();
            MessageBox.Show("Enregistrement validé :)");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
