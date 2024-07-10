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
    public partial class frmPaymentHistory : Form
    {
        private int _MemberID;
        public frmPaymentHistory(int memberID)
        {
            InitializeComponent();
            _MemberID = memberID;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void frmPaymentHistory_Load(object sender, EventArgs e)
        {
            cltPaymentHistory2.LoadData(_MemberID);
        }
    }
}
