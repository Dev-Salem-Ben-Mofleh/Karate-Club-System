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

namespace KarateClub.Istructor.Controls
{
    public partial class cltTrainedHistoryInstructor : UserControl
    {
        int _InstructorID;

        public cltTrainedHistoryInstructor(int InstructorID)
        {
            _InstructorID = InstructorID;
            InitializeComponent();
        }
        public void LoadTrianedMembers()
        {
            dgvTrainedHistory.DataSource = clsMembers.GetAllRows(_InstructorID);
        }

        private void cmTrainedHisstory_Opening(object sender, CancelEventArgs e)
        {
            bool IsHaveTestNotTake = clsBeltTests.CheckMemberHaveTestNotTekeYet((int)dgvTrainedHistory.CurrentRow.Cells[0].Value);
            toolTakeNextBeltTest.Enabled = IsHaveTestNotTake;
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberDetails frm = new frmMemberDetails((int)dgvTrainedHistory.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberDetails frm = new frmMemberDetails((int)dgvTrainedHistory.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadTrianedMembers();
        }

        private void toolPireodHistory_Click(object sender, EventArgs e)
        {
            frmSubscriptionPireodHistory frm = new frmSubscriptionPireodHistory();
            frm.ShowDialog();
        }

        private void toolTakeNextBeltTest_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateTest frm = new frmAddAndUpdateTest();
            frm.ShowDialog();
        }

        private void toolshowTestHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberTestHistory frm = new frmMemberTestHistory();
            frm.ShowDialog();
        }

        private void showPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentHistory frm = new frmPaymentHistory();
            frm.ShowDialog();
        }
    }
}
