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
    public partial class frmMemberTestHistory : Form
    {
       private int _MemberID;
        public frmMemberTestHistory(int memberID)
        {
            InitializeComponent();
            _MemberID = memberID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void frmMemberTestHistory_Load(object sender, EventArgs e)
        {
            cltMemberInformation1.LoadMemberInfo(_MemberID);
            cltTesstHistory1.LoadData(_MemberID);
        }
    }
}
