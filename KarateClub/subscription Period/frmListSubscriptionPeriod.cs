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
using System.Web.UI;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KarateClub
{
    public partial class frmListSubscriptionPeriod : Form
    {
        public frmListSubscriptionPeriod()
        {
            InitializeComponent();
        }



        private static DataTable _dtAllPeriod = clsSubscriptionPeriods.GetAllRows();


        private void _RefreshPeriodList()
        {
            _dtAllPeriod = clsSubscriptionPeriods.GetAllRows();

            dgvSubscription.DataSource = _dtAllPeriod;
            lblCountSubscription.Text = dgvSubscription.Rows.Count.ToString();
            cbSubscription.SelectedIndex = 0;
        }
        private void _LoadDefaultData()
        {
            dgvSubscription.DataSource = _dtAllPeriod;
            cbSubscription.SelectedIndex = 0;
            lblCountSubscription.Text = dgvSubscription.Rows.Count.ToString();
            if (dgvSubscription.Rows.Count > 0)
            {

                dgvSubscription.Columns[0].HeaderText = "Period ID";
                dgvSubscription.Columns[0].Width = 100;

                dgvSubscription.Columns[1].HeaderText = "Member Name";
                dgvSubscription.Columns[1].Width = 140;


                dgvSubscription.Columns[2].HeaderText = "Fees";
                dgvSubscription.Columns[2].Width = 100;

                dgvSubscription.Columns[3].HeaderText = "Is Paid";
                dgvSubscription.Columns[3].Width = 80;


                dgvSubscription.Columns[4].HeaderText = "Start Date";
                dgvSubscription.Columns[4].Width = 120;

                dgvSubscription.Columns[5].HeaderText = "End Date";
                dgvSubscription.Columns[5].Width = 120;

                dgvSubscription.Columns[6].HeaderText = "Subscription Days";
                dgvSubscription.Columns[6].Width = 140;

                dgvSubscription.Columns[7].HeaderText = "Payment ID";
                dgvSubscription.Columns[7].Width = 100;

                dgvSubscription.Columns[8].HeaderText = "Is Active";
                dgvSubscription.Columns[8].Width = 80;


            }
        }
        private void _SearchPeriod()
        {
           
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbSubscription.Text)
            {
                case "Period ID":
                    FilterColumn = "PeriodID";
                    break;

                case "Member Name":
                    FilterColumn = "Name";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtSubscription.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllPeriod.DefaultView.RowFilter = "";
                lblCountSubscription.Text = dgvSubscription.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PeriodID")
                //in this case we deal with integer not string.

                _dtAllPeriod.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtSubscription.Text.Trim());
            else
                _dtAllPeriod.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSubscription.Text.Trim());

            lblCountSubscription.Text = dgvSubscription.Rows.Count.ToString();
        }
        private void _RefreshSearch()
        {
            dgvSubscription.DataSource = _dtAllPeriod;
            lblCountSubscription.Text = dgvSubscription.Rows.Count.ToString();
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
                _dtAllPeriod.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllPeriod.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblCountSubscription.Text = _dtAllPeriod.Rows.Count.ToString();
        }
        private void _SearchIsPaid()
        {
            string FilterColumn = "Paid";
            string FilterValue = cbIsPaid.Text;


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
                _dtAllPeriod.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllPeriod.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblCountSubscription.Text = _dtAllPeriod.Rows.Count.ToString();
        }
        private void FilterBy()
        {
            _RefreshSearch();

            if (cbSubscription.Text == "Is Active")
            {
                txtSubscription.Visible = false;
                cbIsPaid.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            if (cbSubscription.Text == "Is Paid")
            {
                txtSubscription.Visible = false;
                cbIsPaid.Visible = true;
                cbIsActive.Visible = false;
                cbIsPaid.Focus();
                cbIsPaid.SelectedIndex = 0;
            }
            else

            {

                txtSubscription.Visible = (cbSubscription.Text != "None");
                cbIsActive.Visible = false;
                cbIsPaid.Visible = false;

                txtSubscription.Text = "";
                txtSubscription.Focus();

            }
        }
        private void _DeletePeriod()
        {
            if (MessageBox.Show("Are you sure you want to delete Period [" + dgvSubscription.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                

                //Perform Delele and refresh
                if (clsSubscriptionPeriods.DeleteRow((int)dgvSubscription.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Period Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeriodList();
                }

                else
                    MessageBox.Show("Period was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void frmListSubscriptionPeriod_Load(object sender, EventArgs e)
        {
            _LoadDefaultData();
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchIsActive();
        }
        private void cbIsPaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchIsPaid();
        }
        private void txtSubscription_TextChanged(object sender, EventArgs e)
        {
            _SearchPeriod();
        }
        private void cbSubscription_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy();
        }
        private void txtSubscription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbSubscription.Text == "Period ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void btnRenewPeriod_Click(object sender, EventArgs e)
        {
            frmRenewPeriod frm = new frmRenewPeriod();
            frm.ShowDialog();
            _RefreshPeriodList();
        }
        private void btnAddNewSubscription_Click_1(object sender, EventArgs e)
        {
            frmAddNewSubscription frm = new frmAddNewSubscription();
            frm.ShowDialog();
            _RefreshPeriodList();
        }
        private void toolDeletePeriod_Click(object sender, EventArgs e)
        {
            _DeletePeriod();
        }
        private void toolAddNewPeriodr_Click(object sender, EventArgs e)
        {
            frmAddNewSubscription frm = new frmAddNewSubscription();
            frm.ShowDialog();
            _RefreshPeriodList();
        }
        
        private void toolShowPeriodDetails_Click(object sender, EventArgs e)
        {
            frmPeriodDetails frm = new frmPeriodDetails((int)dgvSubscription.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeriodList();
        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmSubscriptionPireodHistory frm = new frmSubscriptionPireodHistory((int)dgvSubscription.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeriodList();
        }
        private void toolPayPeriod_Click(object sender, EventArgs e)
        {
            clsSubscriptionPeriods subscriptionPeriods = clsSubscriptionPeriods.FindByPeriodID((int)dgvSubscription.CurrentRow.Cells[0].Value);
            subscriptionPeriods.PaymentID = subscriptionPeriods.SavePayment();
            subscriptionPeriods.Paid = true;
            subscriptionPeriods.Save();
            _RefreshPeriodList();

        }
        private void toolRenewPeriod_Click(object sender, EventArgs e)
        {
            frmRenewPeriod frm = new frmRenewPeriod((int)dgvSubscription.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeriodList();

        }
        private void cmPeriod_Opening(object sender, CancelEventArgs e)
        {
            bool Edit = clsSubscriptionPeriods.CheckIsActiveAndIsPaid((int)dgvSubscription.CurrentRow.Cells[0].Value);
            bool Delete = clsSubscriptionPeriods.CheckForDeletePeriod((int)dgvSubscription.CurrentRow.Cells[0].Value);
            bool Pay = clsSubscriptionPeriods.CheckForPayPeriod((int)dgvSubscription.CurrentRow.Cells[0].Value);
            bool Renew = clsSubscriptionPeriods.CheckForRenewPeriod((int)dgvSubscription.CurrentRow.Cells[0].Value);
            toolEditePeriod.Enabled = Edit;
            toolDeletePeriod.Enabled = Delete;
            toolPayPeriod.Enabled = Pay;
            toolRenewPeriod.Enabled = Renew;

        }

        private void toolEditePeriod_Click(object sender, EventArgs e)
        {
            frmAddNewSubscription frm = new frmAddNewSubscription((int)dgvSubscription.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeriodList();
        }
    }
}
