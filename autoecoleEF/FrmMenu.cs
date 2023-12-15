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
    public partial class FrmMenu : Form
    {
        private autoEcoleEntities mesDonneesEF;
        public FrmMenu()
        {
            InitializeComponent();
            this.mesDonneesEF = new autoEcoleEntities();
        }
        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGererEleve f = new FrmGererEleve(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }

        private void gérerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGererVehicule f = new FrmGererVehicule(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeVehicule f = new FrmListeVehicule(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjouterLecon f = new FrmAjouterLecon(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }

        private void validerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmValiderLecon f = new FrmValiderLecon(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
