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
    public partial class frmMemberDetails : Form
    {
        int _MemberID;
        public frmMemberDetails(int MemberID)
        {
            _MemberID= MemberID;
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClosefrom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            cltMemberInformation1.LoadMemberInfo(_MemberID);
        }

    }
}
