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
    public partial class cltMemberHistory : UserControl
    {
        clsSubscriptionPeriods _Period;
        public cltMemberHistory()
        {
            InitializeComponent();
        }
        int _MemberID;
        public void LoadData(int MemberID)
        {
            _MemberID = MemberID;
            dgvPeriodHistory.DataSource = clsSubscriptionPeriods.GetAllRows(MemberID);
            if(dgvPeriodHistory.RowCount==0)
            {
                MessageBox.Show("No Period with ID = " + MemberID, "Period Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblCountPeroid.Text = dgvPeriodHistory.RowCount.ToString();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriodDetails frm = new frmPeriodDetails((int)dgvPeriodHistory.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadData(_MemberID);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
             _Period = clsSubscriptionPeriods.FindByPeriodID((int)dgvPeriodHistory.CurrentRow.Cells[0].Value);
            _Period.PaymentID = _Period.SavePayment();
            _Period.Paid = true;
            _Period.Save();
            LoadData(_Period.MemberID);
        }

    }
}
