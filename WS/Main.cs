using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void becomeRunner_Click(object sender, EventArgs e)
        {
            runnerRegistration registration = new runnerRegistration();
            this.Hide();
            registration.Show();
        }

        private void becomeSponsor_Click(object sender, EventArgs e)
        {
            runnerSponsor sponsor = new runnerSponsor();
            this.Hide();
            sponsor.Show();
        }

        private void eventInfo_Click(object sender, EventArgs e)
        {
            eventInfoForm eventInfo = new eventInfoForm();
            this.Hide();
            eventInfo.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            selectUserForAuth loginForm = new selectUserForAuth();
            this.Hide();
            loginForm.Show();
        }
    }
}
