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
    public partial class frmShowTestDetails : Form
    {
        private int _BeltTestID;
        public frmShowTestDetails(int beltTestID)
        {
            InitializeComponent();
            _BeltTestID = beltTestID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void frmShowTestDetails_Load(object sender, EventArgs e)
        {
            cltBeltTestInformation1.LoadBeltTestInfo(_BeltTestID);
        }

    }
}
