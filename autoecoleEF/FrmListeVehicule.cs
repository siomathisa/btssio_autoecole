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
    public partial class FrmListeVehicule : Form
    {
        private autoEcoleEntities mesDonneesEF;
        public FrmListeVehicule(autoEcoleEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = new autoEcoleEntities();
            this.bdgVehicules.DataSource = mesDonneesEF.vehicule.ToList();
        }

        private void FrmListeVehicule_Load(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.bdgVehicules.EndEdit();
            this.mesDonneesEF.SaveChanges();
        }
    }
}
