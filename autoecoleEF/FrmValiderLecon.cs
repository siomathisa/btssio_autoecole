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
            this.mesDonneesEF = mesDonneesEF;
            this.bdgSlecon.DataSource = mesDonneesEF.lecon.ToList();
            this.bdgSvehicule.DataSource = mesDonneesEF.vehicule.ToList();
            this.bdgSeleve.DataSource = mesDonneesEF.eleve.Include("lecon").ToList();
        }

        private void FrmValiderLecon_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btnEnregistrer, "Valider la leçon");
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.bdgSlecon.EndEdit();
            this.bdgSeleve.EndEdit();
            this.bdgSvehicule.EndEdit();
            this.mesDonneesEF.SaveChanges();
            MessageBox.Show("Enregistrement validé :)");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
