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
    public partial class registrationConfirmation : Form
    {
        public int runnerId = 0;
        public registrationConfirmation()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            runnerMenu runnerMenu = new runnerMenu();
            runnerMenu.runnerId = runnerId;
            this.Close();
            runnerMenu.Show();
        }

        private void toBack_Click(object sender, EventArgs e)
        {
            eventRegistration eventRegistration = new eventRegistration();
            this.Close();
            eventRegistration.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }
    }
}
