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
    public partial class runnerManagement : Form
    {
        public string userEmail = "";
        DataTable dt = new DataTable();
        public runnerManagement()
        {
            InitializeComponent();

            dt.Columns.Add("Имя");
            dt.Columns.Add("Фамилия");
            dt.Columns.Add("Email");

            runnersTable.DataSource = dt;
        }

        private void toBack_Click(object sender, EventArgs e)
        {
            coordinatorMenu coordinatorMenu = new coordinatorMenu();
            coordinatorMenu.userEmail = userEmail;
            this.Close();
            coordinatorMenu.Close();
        }

        private void runnerManagement_Load(object sender, EventArgs e)
        {
            using(MarathonEntities context = new MarathonEntities())
            {
                IQueryable<User> users = from user in context.User where user.RoleId == "R" select user;

                totalRunners.Text = "Total runners: " + users.Count().ToString();

                DataTable workTable = new DataTable("Runners");

                foreach (var user in users)
                {
                    DataRow dr = dt.NewRow();
                    dr["Имя"] = user.FirstName;
                    dr["Фамилия"] = user.LastName;
                    dr["Email"] = user.Email;
                    dt.Rows.Add(dr);
                }
            }
        }
    }
}
