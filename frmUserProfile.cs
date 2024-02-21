using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPROJECT
{
    public partial class frmUserProfile : Form
    {
        long iduser;
        String loginname;
        public frmUserProfile(long liduser, String lname)
        {
            InitializeComponent();
            this.iduser = liduser;
            this.loginname = lname;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void ChangePasswordfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangePasswordfrm.Dispose();
        }


        private frmChangePassword ChangePasswordfrm;
        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            ChangePasswordfrm = new frmChangePassword(Globals.gIdUser, Globals.gLoginName);
            ChangePasswordfrm.FormClosed += ChangePasswordfrm_FormClosed;

            ChangePasswordfrm.ShowDialog();
        }
        private void frmUserProfile_LoadUserData()
        {
            String uname = "", uemail = "", ugender = "MALE",
                usmtphost = "", usmtpport = "";
            DateTime ubirthdate = Convert.ToDateTime("01/01/1940");
            if (Globals.glOpenSqlConn())
            {
            }
        }
    }
}