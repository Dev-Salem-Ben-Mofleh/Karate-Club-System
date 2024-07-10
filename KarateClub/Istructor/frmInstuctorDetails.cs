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
    public partial class frmInstuctorDetails : Form
    {
        int _InstructorID;
        public frmInstuctorDetails(int instructorID)
        {
            InitializeComponent();
            _InstructorID = instructorID;
        }

        private void btnClosefrom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmInstuctorDetails_Load(object sender, EventArgs e)
        {
            cltInstructorDetails1.LoadInstructorInfo(_InstructorID);
        }
    }
}
