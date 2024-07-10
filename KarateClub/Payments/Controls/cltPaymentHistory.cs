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
    public partial class cltPaymentHistory : UserControl
    {
        public cltPaymentHistory()
        {
            InitializeComponent();
        }
        public void LoadData(int MemberID)
        {
            dgvPaymentHistory.DataSource = clsPayments.GetAllRows(MemberID);

            if (dgvPaymentHistory.RowCount == 0)
            {
                MessageBox.Show("No Paymet with ID = " + MemberID, "Payment Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblCountPayment.Text = dgvPaymentHistory.RowCount.ToString();


        }

    }
}
