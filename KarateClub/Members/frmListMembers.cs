using clsKarateBussinse;
using clsKarateBussinseLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmListMembers : Form
    {
        public frmListMembers()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllPeople = clsMembers.GetAllRows();

        private void _FillRanks()
        {
            DataTable RanksName = clsBeltRanks.GetAllRows();
            foreach(DataRow Row in RanksName.Rows)
            {
                cbRankName.Items.Add(Row["RankName"]);
            }
        }
        private void _RefreshPeoplList()
        {
            _dtAllPeople = clsMembers.GetAllRows();

            dgvMembers.DataSource = _dtAllPeople;
            lblRecordsCountMemeber.Text = dgvMembers.Rows.Count.ToString();
            cbFilterByMemebr.SelectedIndex = 0;
        }
        private void _LoadDefaultData()
        {
            dgvMembers.DataSource = _dtAllPeople;
            cbFilterByMemebr.SelectedIndex = 0;
            lblRecordsCountMemeber.Text = dgvMembers.Rows.Count.ToString();
            if (dgvMembers.Rows.Count > 0)
            {

                dgvMembers.Columns[0].HeaderText = "Member ID";
                dgvMembers.Columns[0].Width = 110;

                dgvMembers.Columns[1].HeaderText = "Name";
                dgvMembers.Columns[1].Width = 120;


                dgvMembers.Columns[2].HeaderText = "Rank Name";
                dgvMembers.Columns[2].Width = 120;

                dgvMembers.Columns[3].HeaderText = "Gender";
                dgvMembers.Columns[3].Width = 120;


                dgvMembers.Columns[4].HeaderText = "Date Of Birth";
                dgvMembers.Columns[4].Width = 140;

                dgvMembers.Columns[5].HeaderText = "Phone";
                dgvMembers.Columns[5].Width = 120;

                dgvMembers.Columns[6].HeaderText = "Is Active";
                dgvMembers.Columns[6].Width = 120;

            }
        }
        private void _SearchMembers ()
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterByMemebr.Text)
            {
                case "Member ID":
                    FilterColumn = "InstructorID";
                    break;

                case "Name":
                    FilterColumn = "Name";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValueMember.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllPeople.DefaultView.RowFilter = "";
                lblRecordsCountMemeber.Text = dgvMembers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "InstructorID")
                //in this case we deal with integer not string.

                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValueMember.Text.Trim());
            else
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValueMember.Text.Trim());

            lblRecordsCountMemeber.Text = dgvMembers.Rows.Count.ToString();
        }
        private void _RefreshSearch()
        {
            dgvMembers.DataSource = _dtAllPeople;
            lblRecordsCountMemeber.Text = dgvMembers.Rows.Count.ToString();
        }
        private void _SearchIsActive()
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtAllPeople.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCountMemeber.Text = _dtAllPeople.Rows.Count.ToString();
        }
        private void _SearchRankName()
        {
            string FilterColumn = "RankName";
            string FilterValue = cbRankName.Text;


            if (FilterValue == "")
                _dtAllPeople.DefaultView.RowFilter = "";
            else
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, cbRankName.Text.Trim());

            lblRecordsCountMemeber.Text = _dtAllPeople.Rows.Count.ToString();
        }
        private void FilterBy()
        {
            _RefreshSearch();

            if (cbFilterByMemebr.Text == "Is Active")
            {
                txtFilterValueMember.Visible = false;
                cbRankName.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 1;
            }
            else
            if (cbFilterByMemebr.Text == "Rank Name")
            {
                txtFilterValueMember.Visible = false;
                cbRankName.Visible = true;
                cbIsActive.Visible = false;
                cbRankName.Focus();
                cbRankName.SelectedIndex = 0;
            }
            else

            {

                txtFilterValueMember.Visible = (cbFilterByMemebr.Text != "None");
                cbIsActive.Visible = false;
                cbRankName.Visible = false;

                txtFilterValueMember.Text = "";
                txtFilterValueMember.Focus();

            }
        }
        private void _DeleteMember()
        {
            if (MessageBox.Show("Are you sure you want to delete Member [" + dgvMembers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                clsMembers _Member = clsMembers.FindByMemberID((int)dgvMembers.CurrentRow.Cells[0].Value);


                    if (_Member.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Member.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                //Perform Delele and refresh
                if (clsMembers.DeleteRow((int)dgvMembers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Member Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeoplList();
                }

                else
                    MessageBox.Show("Member was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void frmListMembers_Load(object sender, EventArgs e)
        {
            _FillRanks();
            _LoadDefaultData();
        }
        private void txtFilterValueMember_TextChanged(object sender, EventArgs e)
        {
            _SearchMembers();
        }
        private void cbFilterByMemebr_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberDetails frm=new frmMemberDetails((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeoplList();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateMembers frm = new frmAddAndUpdateMembers();
            frm.ShowDialog();
            _RefreshPeoplList();
        }
        private void editMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateMembers frm = new frmAddAndUpdateMembers((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeoplList();
        }
        private void toolMemberTakeNextBeltTest_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateTest frm = new frmAddAndUpdateTest((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeoplList();
        }
        private void toolMemberPeriod_Click(object sender, EventArgs e)
        {
            frmSubscriptionPireodHistory frm = new frmSubscriptionPireodHistory((int)dgvMembers.CurrentRow.Cells[0].Value,true);
            frm.ShowDialog();
            _RefreshPeoplList();
        }
        private void showMemberPeriodHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberTestHistory frm = new frmMemberTestHistory((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeoplList();
        }
        private void showPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentHistory frm = new frmPaymentHistory((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeoplList();
        }
        private void cbRankName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchRankName();
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchIsActive();
        }
        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateMembers frm = new frmAddAndUpdateMembers();
            frm.ShowDialog();
            _RefreshPeoplList();
        }
        private void txtFilterValueMember_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByMemebr.Text == "Member ID" || cbFilterByMemebr.Text == "Phone")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteMember();
        }
    }
}
