using GestionParcInformatique.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionParcInformatique.View
{
    public partial class ContratView : Form
    {
        Contrat contrat = new Contrat();
        AppContext db =App.db;
        private int v;

        public ContratView()
        {
            InitializeComponent();
        }

        public ContratView(int v)
        {
            InitializeComponent();
            contrat = db.Contrats.Find(v);
            txtNumero.Text= contrat.NumeroContrat ;
            txtRaisonSociale.Text=contrat.RaisonSociale ;
            txtMontant.Text=contrat.Montant.ToString();
            dtContrat.Value= contrat.Date;
            dtFinContrat.Value=contrat.Fin;
            txtCodeFournisseur.Text=contrat.CodeFournisseur ;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                contrat.NumeroContrat = txtNumero.Text;
                contrat.RaisonSociale = txtRaisonSociale.Text;
                contrat.Montant = Convert.ToDouble(txtMontant.Text);
                contrat.Date = dtContrat.Value.Date;
                contrat.Fin = dtFinContrat.Value.Date;
                contrat.CodeFournisseur = txtCodeFournisseur.Text;
                if(contrat.ID==0)
                  db.Contrats.Add(contrat);
                db.SaveChanges();
                this.Close();
            }
            catch (Exception)
            {
            }
           
        }
    }
}
