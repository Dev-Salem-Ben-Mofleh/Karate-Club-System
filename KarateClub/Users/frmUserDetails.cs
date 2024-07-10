﻿using System;
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
    public partial class frmUserDetails : Form
    {
        int _UserID;
        public frmUserDetails(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            cltUserDetails1.LoadUserInfo(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
