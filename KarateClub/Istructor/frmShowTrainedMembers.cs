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
    public partial class frmShowTrainedMembers : Form
    {
        int _InstructorID;
        public frmShowTrainedMembers(int InstructorID)
        {
            _InstructorID = InstructorID;
            InitializeComponent();
        }
        private void _LaodDate()
        {
            cltInstructorDetails1.LoadInstructorInfo(_InstructorID);
            ctlTrainedHistory1.LoadData(_InstructorID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClosefrom_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmShowTrainedMembers_Load(object sender, EventArgs e)
        {
            _LaodDate();
        }
    }
}
