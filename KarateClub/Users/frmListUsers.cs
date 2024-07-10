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
    public partial class frmListUsers : Form
    {
        bool _IsSavedLoginInfo;
        public frmListUsers(bool isSavedLoginInfo)
        {
            InitializeComponent();
            _IsSavedLoginInfo = isSavedLoginInfo;
        }
        private static DataTable _dtAllUsers = clsUsers.GetAllRows();


        private void _RefreshUserlList()
        {
            _dtAllUsers = clsUsers.GetAllRows();

            dgvUsers.DataSource = _dtAllUsers;
            lblCountUsers.Text = dgvUsers.Rows.Count.ToString();
            cbUsers.SelectedIndex = 0;
        }
        private void _LoadDefaultData()
        {
            dgvUsers.DataSource = _dtAllUsers;
            cbUsers.SelectedIndex = 0;
            lblCountUsers.Text = dgvUsers.Rows.Count.ToString();
            if (dgvUsers.Rows.Count > 0)
            {

                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].HeaderText = "Name";
                dgvUsers.Columns[1].Width = 120;


                dgvUsers.Columns[2].HeaderText = "User Name";
                dgvUsers.Columns[2].Width = 120;


                dgvUsers.Columns[3].HeaderText = "Gender";
                dgvUsers.Columns[3].Width = 120;

                dgvUsers.Columns[4].HeaderText = "Date Of Birth";
                dgvUsers.Columns[4].Width = 140;

                dgvUsers.Columns[5].HeaderText = "Phone";
                dgvUsers.Columns[5].Width = 120;

                dgvUsers.Columns[6].HeaderText = "Is Active";
                dgvUsers.Columns[6].Width = 120;

            }
        }
        private void _SearchUser()
        {


            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbUsers.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;

                case "Name":
                    FilterColumn = "Name";
                    break;

                case "Gender":
                    FilterColumn = "Gender";
                    break;

                case "User Name":
                    FilterColumn = "UserName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtUsers.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblCountUsers.Text = dgvUsers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "UserID")

                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtUsers.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtUsers.Text.Trim());

            lblCountUsers.Text = dgvUsers.Rows.Count.ToString();
        }
        private void _RefreshSearch()
        {
            dgvUsers.DataSource = _dtAllUsers;
            lblCountUsers.Text = dgvUsers.Rows.Count.ToString();
        }
        private void FilterBy()
        {
            _RefreshSearch();
            if (cbUsers.Text == "Is Active")
            {
                txtUsers.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtUsers.Visible = (cbUsers.Text != "None");
                cbIsActive.Visible = false;

                txtUsers.Text = "";
                txtUsers.Focus();
            }


        }
        private void _MakeUserIsNotActive()
        {
            if (MessageBox.Show("Are you sure you want to Make User Not Activ  [" + dgvUsers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                   
               

                //Perform Delele and refresh
                if (clsUsers.DeleteRow((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Is Not Active Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUserlList();
                }

                else
                    MessageBox.Show("User was not done ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

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
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblCountUsers.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void txtUsers_TextChanged(object sender, EventArgs e)
        {
            _SearchUser();
        }
        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _LoadDefaultData();
        }
        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy();
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchIsActive();
        }
        private void txtUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbUsers.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void toolShowUserDetails_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshUserlList();

        }
        private void toolAddUser_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateUser frm = new frmAddAndUpdateUser();
                frm.ShowDialog();
            _RefreshUserlList();

        }
        private void toolEditUser_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateUser frm = new frmAddAndUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshUserlList();
        }
        private void toolDeleteUSer_Click(object sender, EventArgs e)
        {
            _MakeUserIsNotActive();
        }
        private void toolChabgePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value, _IsSavedLoginInfo);
            frm.ShowDialog();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateUser frm = new frmAddAndUpdateUser();
            frm.ShowDialog();
            _RefreshUserlList();
        }
    }
}
