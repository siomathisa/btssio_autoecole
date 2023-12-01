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
    public partial class FrmAjouterLecon : Form
    {
        private autoEcoleEntities mesDonneesEF;
        public FrmAjouterLecon(autoEcoleEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = new autoEcoleEntities();
            for(int i = 8; i < 20; i++)
            {
                this.cmbHeure.Items.Add(i);
            }
            this.bdgEleve.DataSource = mesDonneesEF.eleve.ToList();
        }
        private int newNumLecon()
        {
            int n;
            int dernier = (from ra in this.mesDonneesEF.lecon
                           select ra.id).Max();
            n = dernier + 1;
            return n;
        }
        private lecon nouvelleLecon()
        {
            int n = newNumLecon();
            eleve el = (eleve)cmbEleve.SelectedValue;
            DateTime d = this.dtLecon.Value;
            int heureLecon = Convert.ToInt32(this.cmbHeure.SelectedItem);
            int nbHeures = 1;
            if (this.radioButton2.Checked)
            {
                nbHeures = 2;
            }
            lecon l = new lecon();
            l.date = d;
            l.heure = heureLecon;
            l.duree = nbHeures;
            l.id = n;  
            l.eleve = el;
            return l;
        }

        private void FrmAjouterLecon_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.mesDonneesEF.lecon.Add(nouvelleLecon());
            this.mesDonneesEF.SaveChanges();
            MessageBox.Show("Enregistrement validé :)");
        }
    }
}
