using clsKarateBussinse;
using KarateClub.Global;
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
    public partial class frmLisInstructors : Form
    {
        public frmLisInstructors()
        {
            InitializeComponent();
        }
        private static DataTable _dtAllInstructor = clsInstructors.GetAllRows();

        
        private void _RefreshInstuctorlList()
        {
            _dtAllInstructor = clsInstructors.GetAllRows();

            dgvInstructor.DataSource = _dtAllInstructor;
            lblCountInstructor.Text = dgvInstructor.Rows.Count.ToString();
            cbInstructor.SelectedIndex = 0;
        }
        private void _LoadDefaultData()
        {
            dgvInstructor.DataSource = _dtAllInstructor;
            cbInstructor.SelectedIndex = 0;
            lblCountInstructor.Text = dgvInstructor.Rows.Count.ToString();
            if (dgvInstructor.Rows.Count > 0)
            {

                dgvInstructor.Columns[0].HeaderText = "Instructo ID";
                dgvInstructor.Columns[0].Width = 110;

                dgvInstructor.Columns[1].HeaderText = "Name";
                dgvInstructor.Columns[1].Width = 120;


                dgvInstructor.Columns[2].HeaderText = "Phone";
                dgvInstructor.Columns[2].Width = 120;

                dgvInstructor.Columns[3].HeaderText = "Date Of Birth";
                dgvInstructor.Columns[3].Width = 140;

                dgvInstructor.Columns[4].HeaderText = "Gender";
                dgvInstructor.Columns[4].Width = 120;


                dgvInstructor.Columns[5].HeaderText = "Qualification";
                dgvInstructor.Columns[5].Width = 120;

            }
        }
        private void _SearchInstructor()
        {

            
             string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbInstructor.Text)
            {
                case "Instructor ID":
                    FilterColumn = "InstructorID";
                    break;

                case "Name":
                    FilterColumn = "Name";
                    break;

                case "Gender":
                    FilterColumn = "Gender";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtInstructor.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllInstructor.DefaultView.RowFilter = "";
                lblCountInstructor.Text = dgvInstructor.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "InstructorID")

                _dtAllInstructor.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtInstructor.Text.Trim());
            else
                _dtAllInstructor.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtInstructor.Text.Trim());

            lblCountInstructor.Text = dgvInstructor.Rows.Count.ToString();
        }
        private void _RefreshSearch()
        {
            dgvInstructor.DataSource = _dtAllInstructor;
            lblCountInstructor.Text = dgvInstructor.Rows.Count.ToString();
        }
        private void FilterBy()
        {
            _RefreshSearch();

                txtInstructor.Visible = (cbInstructor.Text != "None");

                txtInstructor.Text = "";
                txtInstructor.Focus();

            
        }
        private void _DeleteInstructor()
        {
            if (MessageBox.Show("Are you sure you want to delete Instructor [" + dgvInstructor.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                clsInstructors _Instructor = clsInstructors.FindByInstructorID((int)dgvInstructor.CurrentRow.Cells[0].Value);


                    if (_Instructor.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Instructor.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                //Perform Delele and refresh
                if (clsInstructors.DeleteRow((int)dgvInstructor.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Instructor Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshInstuctorlList();
                }

                else
                    MessageBox.Show("Instructor was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void frmLisInstructors_Load(object sender, EventArgs e)
        {
            _LoadDefaultData();
        }
        private void txtInstructor_TextChanged(object sender, EventArgs e)
        {
            _SearchInstructor();
        }
        private void cbInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy();
        }
        private void txtInstructor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbInstructor.Text == "Instructor ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnAnnNewInstructor_Click(object sender, EventArgs e)
        {
            frmAddNewAndUpdateInstructor frm = new frmAddNewAndUpdateInstructor();
            frm.ShowDialog();
            _RefreshInstuctorlList();
        }

        private void toolAddNewInstructor3_Click(object sender, EventArgs e)
        {
            frmAddNewAndUpdateInstructor frm = new frmAddNewAndUpdateInstructor();
            frm.ShowDialog();
            _RefreshInstuctorlList();
        }

        private void toolEditInstructor_Click(object sender, EventArgs e)
        {
            frmAddNewAndUpdateInstructor frm = new frmAddNewAndUpdateInstructor((int)dgvInstructor.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshInstuctorlList();
        }

        private void toolShowtrained_Click(object sender, EventArgs e)
        {
            frmShowTrainedMembers frm = new frmShowTrainedMembers((int)dgvInstructor.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
        }
        private void toolDeleteInstructor_Click(object sender, EventArgs e)
        {
            _DeleteInstructor();
        }

        private void toolShowInstructorDetails2_Click(object sender, EventArgs e)
        {
            frmInstuctorDetails frm = new frmInstuctorDetails((int)dgvInstructor.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshInstuctorlList();

        }
    }
}
