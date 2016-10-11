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
    public partial class InterventionsView : Form
    {
        AppContext db = App.db;
        Intervention inter = new Intervention();
        public InterventionsView(int ID)
        {
            InitializeComponent();
            inter.PanneID = ID;
        }
        public InterventionsView(int ID,object obj)
        {
            InitializeComponent();
            inter = db.Interventions.Find(ID);
            cbRealisation.SelectedIndex= inter.Realisation ;
            dtPLDebut.Value = inter.Date;
            tmPlDebut.Value=inter.Date;

            dtPlFin.Value=inter.DateFinPalnifie;
            tmPlFin.Value=inter.DateFinPalnifie;

            dtFin.Value=inter.DateFinReal;
            tmFin.Value=inter.DateFinReal;
        }
        private void InterventionsView_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMatricule_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                inter.Realisation = cbRealisation.SelectedItem.ToString().Contains("Interne") ? 0 : 1;
                inter.Date = dtPLDebut.Value.Date;
                inter.Date += tmPlDebut.Value.TimeOfDay;

                inter.DateFinPalnifie = dtPlFin.Value.Date;
                inter.DateFinPalnifie += tmPlFin.Value.TimeOfDay;

                inter.DateFinReal = dtFin.Value.Date;
                inter.DateFinReal += tmFin.Value.TimeOfDay;
                if (inter.ID == 0)
                    db.Interventions.Add(inter);
                db.SaveChanges();
                this.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
