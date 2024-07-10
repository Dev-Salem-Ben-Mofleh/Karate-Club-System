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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        private void _LoadDefaultData()
        {
            lblNumBeltTests.Text = clsBeltTests.CountBeltTests().ToString();
            lblNumIstructor.Text = clsInstructors.CountInstructors().ToString();
            lblNumMembers.Text = clsMembers.CountMembers().ToString();
            lblNumPayments.Text = clsPayments.CountPayments().ToString();
            lblNumSubscription.Text = clsSubscriptionPeriods.CountSubscriptionPeriods().ToString();
            lblNumUsere.Text = clsUsers.CountUsers().ToString();

        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            _LoadDefaultData();
        }

    }
}
