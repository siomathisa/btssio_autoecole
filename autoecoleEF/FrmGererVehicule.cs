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
    public partial class FrmGererVehicule : Form
    {
        private autoEcoleEntities mesDonneesEF;
        public FrmGererVehicule(autoEcoleEntities mesDonneesEF)
        {
            InitializeComponent();
        }

        private void FrmGererEleve_Load(object sender, EventArgs e)
        {

        }
    }
}
