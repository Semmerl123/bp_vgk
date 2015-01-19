using BP_VGK.Tools;
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
    public partial class ManageReceptorsOfSpeciesForm : Form
    {
        private List<Receptor> _allReceptors;

        private Species _species = null;

        public ManageReceptorsOfSpeciesForm()
        {
            InitializeComponent();
            _allReceptors = new List<Receptor>();
        }

        public void UpdateForm(Guid speciesId)
        {
            Species s = BP_VGK.Data.MSSQL.DataProvider.GetInstance().GetSpecies(speciesId);
            _species = s;
            if (s != null)
            {
                tbTrivialName.Text = s.DesignationTrivial;
                tbScientificName.Text = s.DesignationScientific;
                foreach (Receptor r in s.ReceptorList)
                {
                    r.IsAvailable = true;
                    _allReceptors.Add(r);
                }
                foreach (Receptor r1 in BP_VGK.Data.MSSQL.DataProvider.GetInstance().GetNotActivatedReceptorsOfSpecies(speciesId))
                {
                    _allReceptors.Add(r1);
                }
                executeFilter(null);
            }
        }

        private void btSaveNewReceptors_Click(object sender, EventArgs e)
        {
            List<Receptor> newReceptors = new List<Receptor>();
            _species.ReceptorList.Clear();

            foreach (DataGridViewRow dgvr in dgvAvailableReceptors.Rows)
            {
                if (dgvr.Cells[1].Value is bool && Convert.ToBoolean(dgvr.Cells[1].Value) == true)
                {
                    _species.ReceptorList.Add((Receptor)dgvr.Cells[0].Value);
                }
            }
            _species.DesignationTrivial = tbTrivialName.Text;
            _species.DesignationScientific = tbScientificName.Text;
            BP_VGK.Data.MSSQL.DataProvider.GetInstance().UpdateSpecies(_species);
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            executeFilter(tbFilter.Text);
        }

        private void executeFilter(string filterString)
        {
            if (String.IsNullOrEmpty(filterString))
            {

                dgvAvailableReceptors.Rows.Clear();
                foreach (Receptor r in _allReceptors)
                {
                    dgvAvailableReceptors.Rows.Add(r, r.IsAvailable);
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvAvailableReceptors.Rows)
                {
                    dgvAvailableReceptors.CurrentCell = null;
                    row.Visible = ((Receptor)row.Cells[0].Value).ReceptorName.ToLower().Contains(filterString.ToLower());
                }
                dgvAvailableReceptors.Refresh();
            }

            lbNoEntryFound.Visible = false;
            foreach (DataGridViewRow row in dgvAvailableReceptors.Rows)
            {
                if (row.Visible)
                    return;
            }
            lbNoEntryFound.Visible = true;
        }
    }
}
