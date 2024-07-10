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
    public partial class frmPaymentDetails : Form
    {
        private int _PaymentID;
        public frmPaymentDetails(int paymentID)
        {
            InitializeComponent();
            _PaymentID = paymentID;
        }

        private void frmPaymentDetails_Load(object sender, EventArgs e)
        {
            cltPaymentInformation1.LoadPaymentInfo(_PaymentID);
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
