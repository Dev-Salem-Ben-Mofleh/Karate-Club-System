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
    public partial class frmSubscriptionPireodHistory : Form
    {
        clsSubscriptionPeriods _Period;
        private int _PeriodID;
        public frmSubscriptionPireodHistory(int periodID)
        {
            InitializeComponent();
            _PeriodID = periodID;
        }
        private int _MemberID;
        private bool _ByMemberID;
        public frmSubscriptionPireodHistory(int MemberID,bool ByMemberID=false)
        {
            InitializeComponent();
            _MemberID = MemberID;
            _ByMemberID = ByMemberID;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _LoadData()
        {
            if (_ByMemberID)
            {
                cltFilterMember1.LoadMemberInfo(_MemberID);
                cltFilterMember1.FilterEnabled = false;
                cltMemberHistory1.LoadData(_MemberID);
            }
            else
            {
                _Period= clsSubscriptionPeriods.FindByPeriodID(_PeriodID);
                if (_Period == null)
                {
                    MessageBox.Show("No Period with ID = " + _PeriodID, "Period Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    return;
                }
                cltFilterMember1.LoadMemberInfo(_Period.MemberID);
                cltFilterMember1.FilterEnabled = false;
                cltMemberHistory1.LoadData(_Period.MemberID);
            }
        }
        private void frmSubscriptionPireodHistory_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
