using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_VGK.VerwaltungGentechKonstrukte
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void refreshSpeciesTable()
        {
            this.speciesTableTableAdapter.Fill(this._BP_VGK_DatabaseDataSet.SpeciesTable);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "_BP_VGK_DatabaseDataSet.SpeciesTable". Sie können sie bei Bedarf verschieben oder entfernen.

            refreshSpeciesTable();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        private void dgvSpecies_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guid g = new Guid(dgvSpecies.SelectedRows[0].Cells[0].Value.ToString());
            ManageReceptorsOfSpeciesForm urf = new ManageReceptorsOfSpeciesForm();
            urf.UpdateForm(g);
            urf.Show(this);
           urf.FormClosed += urf_FormClosed;
            

        }

        void urf_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.refreshSpeciesTable();
           
        }

        private void btUpdateReceptors_Click(object sender, EventArgs e)
        {
            ManageReceptorsForm urf = new ManageReceptorsForm();
            urf.Show(this);

        }
    }
}
