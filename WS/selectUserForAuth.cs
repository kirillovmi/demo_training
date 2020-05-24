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
    public partial class selectUserForAuth : Form
    {
        public selectUserForAuth()
        {
            InitializeComponent();

            runner.Click += new EventHandler(selectAuthRole);
            coordinator.Click += new EventHandler(selectAuthRole);
            administrator.Click += new EventHandler(selectAuthRole);
        }

        private void selectAuthRole(object sender, EventArgs e)
        {
            loginForm login = new loginForm();

            if(sender == runner)
            {
                login.role = "R";
            }
            else if (sender == coordinator)
            {
                login.role = "C";
            }
            else
            {
                login.role = "A";
            }

            this.Close();
            login.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }
    }
}
