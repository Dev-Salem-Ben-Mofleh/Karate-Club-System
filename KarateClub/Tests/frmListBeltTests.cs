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
    public partial class frmListBeltTests : Form
    {
        public frmListBeltTests()
        {
            InitializeComponent();
        }
        private static DataTable _dtAllBeltTest = clsBeltTests.GetAllRows();
        private void _FillRanks()
        {
            DataTable RanksName = clsBeltRanks.GetAllRows();
            foreach (DataRow Row in RanksName.Rows)
            {
                cbRankName.Items.Add(Row["RankName"]);
            }
        }
        private void _SearchRankName()
        {
            string FilterColumn = "RankName";
            string FilterValue = cbRankName.Text;


            if (FilterValue == "")
                _dtAllBeltTest.DefaultView.RowFilter = "";
            else
                _dtAllBeltTest.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, cbRankName.Text.Trim());

            lblCountBeltTest.Text = _dtAllBeltTest.Rows.Count.ToString();
        }
        private void _RefreshBeltTestlList()
        {
            _dtAllBeltTest = clsBeltTests.GetAllRows();

            dgvBeltTests.DataSource = _dtAllBeltTest;
            lblCountBeltTest.Text = dgvBeltTests.Rows.Count.ToString();
            cbBeltTests.SelectedIndex = 0;
        }
        private void _LoadDefaultData()
        {
            dgvBeltTests.DataSource = _dtAllBeltTest;
            cbBeltTests.SelectedIndex = 0;
            lblCountBeltTest.Text = dgvBeltTests.Rows.Count.ToString();
            if (dgvBeltTests.Rows.Count > 0)
            {

                dgvBeltTests.Columns[0].HeaderText = "Test ID";
                dgvBeltTests.Columns[0].Width = 110;

                dgvBeltTests.Columns[1].HeaderText = "Member Name";
                dgvBeltTests.Columns[1].Width = 120;

                dgvBeltTests.Columns[2].HeaderText = "Instructor Name";
                dgvBeltTests.Columns[2].Width = 120;

                dgvBeltTests.Columns[3].HeaderText = "Ranke Name";
                dgvBeltTests.Columns[3].Width = 120;

                dgvBeltTests.Columns[4].HeaderText = "Test Date";
                dgvBeltTests.Columns[4].Width = 120;


                

                dgvBeltTests.Columns[5].HeaderText = "PaymentID";
                dgvBeltTests.Columns[5].Width = 120;

                dgvBeltTests.Columns[6].HeaderText = "Result";
                dgvBeltTests.Columns[6].Width = 140;

            }
        }
        private void _SearchBeltTes()
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbBeltTests.Text)
            {
                case "Test ID":
                    FilterColumn = "TestID";
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
            if (txtBeltTests.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllBeltTest.DefaultView.RowFilter = "";
                lblCountBeltTest.Text = dgvBeltTests.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "TestID")

                _dtAllBeltTest.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtBeltTests.Text.Trim());
            else
                _dtAllBeltTest.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtBeltTests.Text.Trim());

            lblCountBeltTest.Text = dgvBeltTests.Rows.Count.ToString();
        }
        private void _RefreshSearch()
        {
            dgvBeltTests.DataSource = _dtAllBeltTest;
            lblCountBeltTest.Text = dgvBeltTests.Rows.Count.ToString();
        }
        private void FilterBy()
        {
            _RefreshSearch();


            if (cbBeltTests.Text == "Rank Name")
            {
                txtBeltTests.Visible = false;
                cbRankName.Visible = true;
                cbRankName.Focus();
                cbRankName.SelectedIndex = 0;
            }
            else

            {

                txtBeltTests.Visible = (cbBeltTests.Text != "None");
                cbRankName.Visible = false;

                txtBeltTests.Text = "";
                txtBeltTests.Focus();

            }
        }

        private void frmListBeltTests_Load(object sender, EventArgs e)
        {
            _FillRanks();
            _LoadDefaultData();
        }
        private void txtBeltTests_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbBeltTests.Text == "Test ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void cbBeltTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy();
        }
        private void cbRankName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchRankName();
        }
        private void txtBeltTests_TextChanged(object sender, EventArgs e)
        {
            _SearchBeltTes();
        }
        private void toolTestTakeNext_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateTest frm = new frmAddAndUpdateTest(clsBeltTests.FindByTestID((int)dgvBeltTests.CurrentRow.Cells[0].Value).MemberID);
            frm.ShowDialog();
            _RefreshBeltTestlList();
        }
        private void btnAddNewBeltTest_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateTest frm = new frmAddAndUpdateTest();
            frm.ShowDialog();
            _RefreshBeltTestlList();
        }
        private void cmTests_Opening(object sender, CancelEventArgs e)
        {
        }
        private void toolShowTestDetails_Click(object sender, EventArgs e)
        {
            frmShowTestDetails frm = new frmShowTestDetails((int)dgvBeltTests.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshBeltTestlList();
        }
        private void toolHistoryTest_Click(object sender, EventArgs e)
        {
            frmMemberTestHistory frm = new frmMemberTestHistory(clsBeltTests.FindByTestID((int)dgvBeltTests.CurrentRow.Cells[0].Value).MemberID);
            frm.ShowDialog();
            _RefreshBeltTestlList();
        }
    }
}
