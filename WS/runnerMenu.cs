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
    public partial class runnerMenu : Form
    {
        public int runnerId = 0;
        public string email = "";
        public runnerMenu()
        {
            InitializeComponent();
            toBack.Click += new EventHandler(goToBack);
            logout.Click += new EventHandler(goToBack);
        }

        private void contacts_Click(object sender, EventArgs e)
        {
            contactsForm contactsForm = new contactsForm();
            contactsForm.Show();
        }

        private void goToBack(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }
    }
}
