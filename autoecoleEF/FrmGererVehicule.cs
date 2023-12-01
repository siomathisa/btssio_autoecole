using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace autoecoleEF
{
    public partial class FrmGererVehicule : Form
    {
        private autoEcoleEntities mesDonneesEF;
        public FrmGererVehicule(autoEcoleEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = new autoEcoleEntities();
            this.bdgSourceVehicule.DataSource = mesDonneesEF.vehicule.ToList();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.txtNum.ReadOnly = false;
            this.txtModele.ReadOnly = false;
            this.txtCouleur.ReadOnly = false;
        }
        private void checkedChangeVehicule()
        {
            if (txtNum.Text == "" || txtModele.Text == "" || txtCouleur.Text == "")
            {
                MessageBox.Show("Il faut remplir tous les champs du nouveau véhicule");
                bdgSourceVehicule.CancelEdit();
            }
        }
        private void bindingNavigatorMoveFirstItem_CheckedChange(object sender, EventArgs e)
        {
            checkedChangeVehicule();
        }

        private void bindingNavigatorMovePreviousItem_CheckedChange(object sender, EventArgs e)
        {
            checkedChangeVehicule();
        }
        private void bindingNavigatorAddNewItem_CheckedChange(object sender, EventArgs e)
        {
            checkedChangeVehicule();
        }

        private void FrmGererVehicule_Load(object sender, EventArgs e)
        {

        }
        private vehicule newVehicule()
        {
                vehicule newVehicule = new vehicule();
                newVehicule.numImma = txtNum.Text;
                newVehicule.modele = txtModele.Text;
                newVehicule.couleur = txtCouleur.Text;
                return newVehicule;
        }
        private void Enregistrer_Click(object sender, EventArgs e)
        {
            this.bdgSourceVehicule.EndEdit();
            try
            {
                this.mesDonneesEF.vehicule.Add(newVehicule());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Enregistrement validé :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }
    }
}
