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
    public partial class frmListPayments : Form
    {
        public frmListPayments()
        {
            InitializeComponent();
        }
        private static DataTable _dtAllPayments = clsPayments.GetAllRows();


        private void _RefreshPaymentlList()
        {
            _dtAllPayments = clsPayments.GetAllRows();

            dgvPayments.DataSource = _dtAllPayments;
            lblCountPaymentsnt.Text = dgvPayments.Rows.Count.ToString();
            cbPayments.SelectedIndex = 0;
        }
        private void _LoadDefaultData()
        {
            dgvPayments.DataSource = _dtAllPayments;
            cbPayments.SelectedIndex = 0;
            lblCountPaymentsnt.Text = dgvPayments.Rows.Count.ToString();
            if (dgvPayments.Rows.Count > 0)
            {

                dgvPayments.Columns[0].HeaderText = "Payment ID";
                dgvPayments.Columns[0].Width = 110;

                dgvPayments.Columns[1].HeaderText = "Member Name";
                dgvPayments.Columns[1].Width = 120;


                dgvPayments.Columns[2].HeaderText = "Payment Date";
                dgvPayments.Columns[2].Width = 120;


                dgvPayments.Columns[3].HeaderText = "Payment Amount";
                dgvPayments.Columns[3].Width = 120;


            }
        }
        private void _SearchPayment()
        {
  

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbPayments.Text)
            {
                case "Payment ID":
                    FilterColumn = "PaymentID";
                    break;

                case "Member Name":
                    FilterColumn = "MemberName";
                    break;

               
                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtcbPayments.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllPayments.DefaultView.RowFilter = "";
                lblCountPaymentsnt.Text = dgvPayments.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PaymentID")

                _dtAllPayments.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtcbPayments.Text.Trim());
            else
                _dtAllPayments.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtcbPayments.Text.Trim());

            lblCountPaymentsnt.Text = dgvPayments.Rows.Count.ToString();
        }
        private void _RefreshSearch()
        {
            dgvPayments.DataSource = _dtAllPayments;
            lblCountPaymentsnt.Text = dgvPayments.Rows.Count.ToString();
        }
        private void FilterBy()
        {
            _RefreshSearch();
            
            
                txtcbPayments.Visible = (cbPayments.Text != "None");

                txtcbPayments.Text = "";
                txtcbPayments.Focus();
            


        }
       
        private void frmListPayments_Load(object sender, EventArgs e)
        {
            _LoadDefaultData();
        }
        private void cbPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy();

        }
        private void txtcbPayments_TextChanged(object sender, EventArgs e)
        {
            _SearchPayment();
        }
        private void txtcbPayments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbPayments.Text == "_Payment ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void toolShowPaymentDetails_Click(object sender, EventArgs e)
        {
            frmPaymentDetails frm = new frmPaymentDetails((int)dgvPayments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPaymentlList();
        }
        private void toolHistoryPayment_Click(object sender, EventArgs e)
        {
            frmPaymentHistory frm = new frmPaymentHistory(clsPayments.FindByPaymentID((int)dgvPayments.CurrentRow.Cells[0].Value).MemberID);
            frm.ShowDialog();
            _RefreshPaymentlList();
        }

    }
}
