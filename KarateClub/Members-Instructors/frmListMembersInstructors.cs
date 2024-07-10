using clsKarateBussinse;
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
using System.Xml.Linq;

namespace KarateClub
{
    public partial class frmListMembersInstructors : Form
    {
        public frmListMembersInstructors()
        {
            InitializeComponent();
        }
        private static DataTable _dtAllMembersInstructors = clsMemberInstructors.GetAllRows();


        private void _RefreshIMemberInstructorlList()
        {
            _dtAllMembersInstructors = clsMemberInstructors.GetAllRows();

            dgvMemberInstructor.DataSource = _dtAllMembersInstructors;
            lblCountMemberInstructor.Text = dgvMemberInstructor.Rows.Count.ToString();
            cbMemberInstructor.SelectedIndex = 0;
        }
        private void _LoadDefaultData()
        {
            dgvMemberInstructor.DataSource = _dtAllMembersInstructors;
            cbMemberInstructor.SelectedIndex = 0;
            lblCountMemberInstructor.Text = dgvMemberInstructor.Rows.Count.ToString();
            if (dgvMemberInstructor.Rows.Count > 0)
            {

                dgvMemberInstructor.Columns[0].HeaderText = "Members-Instructors ID";
                dgvMemberInstructor.Columns[0].Width = 150;

                dgvMemberInstructor.Columns[1].HeaderText = "Instructor Name";
                dgvMemberInstructor.Columns[1].Width = 150;

                dgvMemberInstructor.Columns[2].HeaderText = "Member Name";
                dgvMemberInstructor.Columns[2].Width = 150;

                dgvMemberInstructor.Columns[3].HeaderText = "Assign Date";
                dgvMemberInstructor.Columns[3].Width = 150;
            }
        }
        private void _SearchMemberInstructor()
        {


            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbMemberInstructor.Text)
            {
                case "Member-Instructor ID":
                    FilterColumn = "MemberInstructorID";
                    break;

                case "Member Name":
                    FilterColumn = "MemberName";
                    break;

                case "Instructor Name":
                    FilterColumn = "InstructorName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txbMemberInstructor.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllMembersInstructors.DefaultView.RowFilter = "";
                lblCountMemberInstructor.Text = dgvMemberInstructor.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "MemberInstructorID")

                _dtAllMembersInstructors.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txbMemberInstructor.Text.Trim());
            else
                _dtAllMembersInstructors.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txbMemberInstructor.Text.Trim());

            lblCountMemberInstructor.Text = dgvMemberInstructor.Rows.Count.ToString();
        }
        private void _RefreshSearch()
        {
            dgvMemberInstructor.DataSource = _dtAllMembersInstructors;
            lblCountMemberInstructor.Text = dgvMemberInstructor.Rows.Count.ToString();
        }
        private void FilterBy()
        {
            _RefreshSearch();

            txbMemberInstructor.Visible = (cbMemberInstructor.Text != "None");

            txbMemberInstructor.Text = "";
            txbMemberInstructor.Focus();


        }
        private void _DeleteMemberInstructor()
        {
            if (MessageBox.Show("Are you sure you want to delete Member-Instuctor [" + dgvMemberInstructor.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                clsMemberInstructors memberInstructors = clsMemberInstructors.FindByMemberInsturctorID((int)dgvMemberInstructor.CurrentRow.Cells[0].Value);




                //Perform Delele and refresh
                if (clsMemberInstructors.DeleteRow((int)dgvMemberInstructor.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Member-Instuctor Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshIMemberInstructorlList();
                }

                else
                    MessageBox.Show("Member-Instuctor was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void frmListMembersInstructors_Load(object sender, EventArgs e)
        {
            _LoadDefaultData();
        }
        private void txbMemberInstructor_TextChanged(object sender, EventArgs e)
        {
            _SearchMemberInstructor();
        }
        private void cbMemberInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy();
        }
        private void txbMemberInstructor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbMemberInstructor.Text == "Member-Instructor ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void toolShowMemberInstructor_Click(object sender, EventArgs e)
        {
            frmShowDetailsMembersInstructors frm = new frmShowDetailsMembersInstructors((int)dgvMemberInstructor.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshIMemberInstructorlList();
        }
        private void toolAddMemberInstructor_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateMembersInstructors frm = new frmAddAndUpdateMembersInstructors();
            frm.ShowDialog();
            _RefreshIMemberInstructorlList();

        }
        private void toolEditMemberInstructor_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateMembersInstructors frm = new frmAddAndUpdateMembersInstructors((int)dgvMemberInstructor.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshIMemberInstructorlList();
        }
        private void toolDeleteMemberInstructor_Click(object sender, EventArgs e)
        {
            _DeleteMemberInstructor();
        }
        private void btnAddMemberInstructor_Click(object sender, EventArgs e)
        {

            frmAddAndUpdateMembersInstructors frm = new frmAddAndUpdateMembersInstructors();
            frm.ShowDialog();
            _RefreshIMemberInstructorlList();
        }

    }
}
