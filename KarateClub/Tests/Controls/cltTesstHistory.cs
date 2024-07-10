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
    public partial class cltTesstHistory : UserControl
    {

        public cltTesstHistory()
        {
            InitializeComponent();
        }
        public void LoadData(int _MemberID)
        {
            dgvTestHistory.DataSource = clsBeltTests.GetAllRows(_MemberID);

            if (dgvTestHistory.RowCount == 0)
            {
                MessageBox.Show("No Test with MemberID = " + _MemberID, "Period Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lblCountTest.Text = dgvTestHistory.RowCount.ToString();


        }
    }
}
