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
    public partial class FrmGererEleve : Form
    {
        private autoEcoleEntities mesDonneesEF;
        public FrmGererEleve(autoEcoleEntities mesDonneesEF)
        {
            InitializeComponent();
        }

        private void FrmGererEleve_Load(object sender, EventArgs e)
        {

        }
    }
}
