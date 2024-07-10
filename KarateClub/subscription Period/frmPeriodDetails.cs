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
    public partial class frmPeriodDetails : Form
    {
        private int _PeriodID;
        public frmPeriodDetails(int periodID)
        {
            InitializeComponent();
            _PeriodID = periodID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmPeriodDetails_Load(object sender, EventArgs e)
        {
            cltPeriodDetails1.LoadPeriodInfo(_PeriodID);
        }
    }
}
