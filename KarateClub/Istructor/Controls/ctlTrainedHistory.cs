using clsKarateBussinse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class ctlTrainedHistory : UserControl
    {
        public ctlTrainedHistory()
        {
            InitializeComponent();
        }
        public void LoadData(int _Instuctor)
        {
            dgvTrainedHistory.DataSource = clsInstructors.GetAllRows(_Instuctor);

            if (dgvTrainedHistory.RowCount == 0)
            {
                MessageBox.Show("No Trained with ID = " + _Instuctor, "Trained Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblCountTrained.Text = dgvTrainedHistory.RowCount.ToString();


        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberDetails frm = new frmMemberDetails((int)dgvTrainedHistory.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadData((int)dgvTrainedHistory.CurrentRow.Cells[0].Value);

        }

        private void editMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewAndUpdateInstructor frm = new frmAddNewAndUpdateInstructor((int)dgvTrainedHistory.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadData((int)dgvTrainedHistory.CurrentRow.Cells[0].Value);
        }

        private void toolMemberTakeNextBeltTest_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateTest frm = new frmAddAndUpdateTest((int)dgvTrainedHistory.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void toolMemberPeriod_Click(object sender, EventArgs e)
        {
            frmSubscriptionPireodHistory frm = new frmSubscriptionPireodHistory((int)dgvTrainedHistory.CurrentRow.Cells[0].Value,true);
            frm.ShowDialog();
        }

        private void showMemberPeriodHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberTestHistory frm = new frmMemberTestHistory((int)dgvTrainedHistory.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentHistory frm = new frmPaymentHistory((int)dgvTrainedHistory.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

    }
}
