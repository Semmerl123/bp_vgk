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
    public partial class ManageReceptorsForm : Form
    {
        public ManageReceptorsForm()
        {
            InitializeComponent();
        }

        private void ManageReceptorsForm_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "_BP_VGK_DatabaseDataSet2.ReceptorsTable". Sie können sie bei Bedarf verschieben oder entfernen.

            refreshDGV();

            // TODO: Diese Codezeile lädt Daten in die Tabelle "_BP_VGK_DatabaseDataSet1.ReceptorsTable". Sie können sie bei Bedarf verschieben oder entfernen.
            // this.receptorsTableTableAdapter.Fill(this._BP_VGK_DatabaseDataSet1.ReceptorsTable);

        }

        private void refreshDGV()
        {
            this.receptorsTableTableAdapter.Fill(this._BP_VGK_DatabaseDataSet2.ReceptorsTable);
        }

        private void btAddNewReceptor_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNewReceptorName.Text))
                MessageBox.Show(this, "No name for receptor selected!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Receptor r = new Receptor();
                r.ReceptorName = tbNewReceptorName.Text;
                BP_VGK.Data.MSSQL.DataProvider.GetInstance().AddOrUpdateReceptor(r);
                int selIndex = dgvAvailableReceptors.CurrentRow.Index;
                refreshDGV();
                


            }
        }

        private void btDeleteSelectedEntry_Click(object sender, EventArgs e)
        {
            Guid gToDelete = new Guid(dgvAvailableReceptors.SelectedRows[0].Cells[0].Value.ToString());

            Receptor rToDelete = new Receptor();
            rToDelete.Id = gToDelete;
            rToDelete.ReceptorName = dgvAvailableReceptors.SelectedRows[0].Cells[1].Value.ToString();
            DialogResult dr = MessageBox.Show(this, "Do you really want to remove the receptor " + rToDelete.ReceptorName + "?", "Delete confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.OK)
                BP_VGK.Data.MSSQL.DataProvider.GetInstance().DeleteReceptor(rToDelete);

            refreshDGV();
        }

        private void btUpdateSelectedReceptor_Click(object sender, EventArgs e)
        {
            if (dgvAvailableReceptors.SelectedRows.Count > 0)
            {
                Receptor updateReceptor = new Receptor();
                updateReceptor.ReceptorName = tbNewReceptorName.Text;
                updateReceptor.Id = new Guid(dgvAvailableReceptors.SelectedRows[0].Cells[0].Value.ToString());
                BP_VGK.Data.MSSQL.DataProvider.GetInstance().AddOrUpdateReceptor(updateReceptor);
                refreshDGV();


            }
        }
    }
}
