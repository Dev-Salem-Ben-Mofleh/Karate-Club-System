using clsKarateBussinse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmListBeltRanks : Form
    {
        public frmListBeltRanks()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllBeltRank = clsBeltRanks.GetAllRows();
        private void _RefreshIBeltRanklList()
        {
            _dtAllBeltRank = clsBeltRanks.GetAllRows();

            dgvBeltRank.DataSource = _dtAllBeltRank;
            lblCountBeltRank.Text = dgvBeltRank.Rows.Count.ToString();
            cbBeltRanke.SelectedIndex = 0;
        }
        private void _LoadDefaultData()
        {
            dgvBeltRank.DataSource = _dtAllBeltRank;
            cbBeltRanke.SelectedIndex = 0;
            lblCountBeltRank.Text = dgvBeltRank.Rows.Count.ToString();
            if (dgvBeltRank.Rows.Count > 0)
            {

                dgvBeltRank.Columns[0].HeaderText = "Rank ID";
                dgvBeltRank.Columns[0].Width = 160;

                dgvBeltRank.Columns[1].HeaderText = "Rank Name";
                dgvBeltRank.Columns[1].Width = 160;


                dgvBeltRank.Columns[2].HeaderText = "Test Fees";
                dgvBeltRank.Columns[2].Width = 160;

            }
        }
        private void _SearchBeltRank()
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbBeltRanke.Text)
            {
                case "Belt Rank ID":
                    FilterColumn = "RankID";
                    break;

                case "Belt Rank  Name":
                    FilterColumn = "RankName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtBeltRank.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllBeltRank.DefaultView.RowFilter = "";
                lblCountBeltRank.Text = dgvBeltRank.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "RankID")

                _dtAllBeltRank.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtBeltRank.Text.Trim());
            else
                _dtAllBeltRank.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtBeltRank.Text.Trim());

            lblCountBeltRank.Text = dgvBeltRank.Rows.Count.ToString();
        }
        private void _RefreshSearch()
        {
            dgvBeltRank.DataSource = _dtAllBeltRank;
            lblCountBeltRank.Text = dgvBeltRank.Rows.Count.ToString();
        }
        private void FilterBy()
        {
            _RefreshSearch();

            txtBeltRank.Visible = (cbBeltRanke.Text != "None");

            txtBeltRank.Text = "";
            txtBeltRank.Focus();


        }
        private void toolEditBeltRank_Click(object sender, EventArgs e)
        {
            frmUpdateBeltRanks frm=new frmUpdateBeltRanks((int)dgvBeltRank.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshIBeltRanklList();
        }
        private void frmListBeltRanks_Load(object sender, EventArgs e)
        {
            _LoadDefaultData();
        }
        private void cbBeltRanke_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy();
        }
        private void txtBeltRank_TextChanged(object sender, EventArgs e)
        {
            _SearchBeltRank();
        }
        private void txtBeltRank_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbBeltRanke.Text == "Belt Rank ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
