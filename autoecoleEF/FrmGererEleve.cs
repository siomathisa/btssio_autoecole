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
            for (int i = 0; i < 30; i++)
            {
                this.cmbCredit.Items.Add(i);
            }
            this.mesDonneesEF = new autoEcoleEntities();
            this.bdgSourceEleve.DataSource = mesDonneesEF.eleve.ToList();
        }
        private int getNumEleve()
        {
            var reqDernier = (from el in this.mesDonneesEF.eleve
                              orderby el.id descending
                              select el);
            eleve dernierEleve = reqDernier.First();
            int n = dernierEleve.id + 1;
            return n;
        }

        private void FrmGererEleve_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.txtNum.Text = this.getNumEleve().ToString();
        }

        private eleve newEleve()
        {
            eleve newEleve = new eleve();
            newEleve.id = Convert.ToInt16(txtNum.Text);
            newEleve.nom = txtNom.Text;
            newEleve.prenom = txtPrenom.Text;  
            newEleve.adresse = txtAdresse.Text;
            newEleve.dateInscription = dtInscription.Value;
            return newEleve;
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            this.bdgSourceEleve.EndEdit();
            try
            {
                this.mesDonneesEF.eleve.Add(newEleve());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Enregistrement validé :)");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            using (var context = new autoEcoleEntities())
            {
                var idASupprimer = Convert.ToInt16(txtNum.Text);
                var entiteASupprimer = context.eleve.FirstOrDefault(el => el.id == idASupprimer);

                if(entiteASupprimer != null)
                {
                    context.eleve.Remove(entiteASupprimer);
                    context.SaveChanges();
                    bdgSourceEleve.RemoveCurrent();
                    MessageBox.Show("Enregistrement supprimé");
                }
            }
        }

        private void checkedChangeEleve()
        {
            if (txtAdresse.Text == "" || txtNom.Text == "" || txtPrenom.Text == "")
            {
                MessageBox.Show("Il faut remplir tous les champs du nouvel élève");
                bdgSourceEleve.CancelEdit();
            }
        }
        private void bindingNavigatorMovePreviousItem_CheckedChange(object sender, EventArgs e)
        {
            checkedChangeEleve();
        }

        private void bindingNavigatorMoveFirstItem_CheckedChange(object sender, EventArgs e)
        {
            checkedChangeEleve();
        }
        private void bindingNavigatorAddNewItem_CheckedChange(object sender, EventArgs e)
        {
            checkedChangeEleve();
        }
    }
}
