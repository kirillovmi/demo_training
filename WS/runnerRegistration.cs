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
    public partial class runnerRegistration : Form
    {
        public runnerRegistration()
        {
            InitializeComponent();
            oldMember.Click += new EventHandler(openLoginForm);
            Login.Click += new EventHandler(openLoginForm);
        }

        private void newMember_Click(object sender, EventArgs e)
        {
            newRunnerRegistration registration = new newRunnerRegistration();
            this.Close();
            registration.Show();
        }

        private void toBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }

        private void openLoginForm(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            this.Close();
            loginForm.Show();
        }
    }
}
