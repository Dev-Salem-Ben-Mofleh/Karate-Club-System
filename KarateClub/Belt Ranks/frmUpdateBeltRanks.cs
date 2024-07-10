using clsKarateBussinse;
using KarateClub.Global;
using KarateClub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;

namespace KarateClub
{
    public partial class frmUpdateBeltRanks : Form
    {

        private int _BeltRankID = -1;
        clsBeltRanks _BeltRank;

     
        public frmUpdateBeltRanks(int BeltRankID)
        {
            InitializeComponent();
            _BeltRankID = BeltRankID;
        }
        private void _ResetDefualtValues()
        {
            lblBeltID.Text = "";
            txtBeltFees.Text = "";
            txtBeltName.Text = "";

        }
        private void _LoadData()
        {

            _BeltRank = clsBeltRanks.FindByRankID(_BeltRankID);

            if (_BeltRank == null)
            {
                MessageBox.Show("No Belt Rank with ID = " + _BeltRankID, "Belt Rank Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblBeltID.Text = _BeltRankID.ToString();
            txtBeltName.Text = _BeltRank.RankName;
            txtBeltFees.Text = _BeltRank.TestFees.ToString();

        }
        private void _Save()
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            _BeltRank.RankName = txtBeltName.Text.Trim();
            _BeltRank.TestFees = Convert.ToSingle( txtBeltFees.Text);

            

            if (_BeltRank.Save())
            {
                lblBeltID.Text = _BeltRank.RankID.ToString();

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void txtBeltName_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
        private void txtBeltFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void frmUpdateBeltRanks_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            _LoadData();
        }
    }
}
