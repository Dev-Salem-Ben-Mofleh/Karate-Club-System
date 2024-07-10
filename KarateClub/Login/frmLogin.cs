using clsKarateBussinse;
using KarateClub.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging.Design;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmLogin : Form
    {
        int CounterFailedLogin = 0;
        public frmLogin()
        {
            InitializeComponent();
        }
        public void LoadDataFromRegistory()
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;

        }
        public void CheckAndFindUser()
        {
            string Password;
            string HashPassword;

            Password = txtPassword.Text.Trim();
            HashPassword=clsUtil.ComputeHash(Password);

            clsUsers user= clsUsers.FindByUsernameAndPassword(txtUserName.Text.Trim(), HashPassword);
            

            if (user != null) 
            { 

                if (chkRememberMe.Checked )
                {
                    //store username and password
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), Password);

                } 
                  else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("", "");

                }

                //incase the user is not active
                if (!user.IsActive )
                {

                    txtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return ;
                }

                 clsGlobal.CurrentUser = user;
                 clsPemission.CheckAccessPermission(user.Permission);
                 this.Hide();
                 frmMain frm = new frmMain(this,chkRememberMe.Checked);
                 frm.ShowDialog();


            } else
            {
                CounterFailedLogin++;
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password, and you have "+ CounterFailedLogin+"/3 Before closed ", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (CounterFailedLogin == 3)
                    this.Close();
            }    
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadDataFromRegistory();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckAndFindUser();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLinke_Click(object sender, EventArgs e)
        {
            // Specify the URL you want to open
            string url = "https://github.com/SalemBenMofleh/Carate-Club-Management-System";

            // Open the URL in the default web browser
            System.Diagnostics.Process.Start(url);
        }
    }
}
