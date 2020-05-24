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
    public partial class loginForm : Form
    {
        public string role = "";
        public loginForm()
        {
            InitializeComponent();
            toBack.Click += new EventHandler(goToBack);
            cancel.Click += new EventHandler(goToBack);
        }

        private void goToBack(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(email.Text.Trim() == "" || password.Text.Trim() == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                using(MarathonEntities context = new MarathonEntities())
                {
                    IQueryable<User> users = from user in context.User where user.RoleId == role select user;
                    
                    if(users.Count() > 0)
                    {
                        string userEmail = users.First().Email;

                        switch(role)
                        {
                            case "R":
                                runnerMenu runnerMenu = new runnerMenu();
                                runnerMenu.email = userEmail;
                                this.Close();
                                runnerMenu.Show();
                                break;
                            case "C":
                                coordinatorMenu coordinatorMenu = new coordinatorMenu();
                                coordinatorMenu.userEmail = userEmail;
                                this.Close();
                                coordinatorMenu.Show();
                                break;
                            case "A":
                                administratorMenu administratorMenu = new administratorMenu();
                                administratorMenu.userEmail = userEmail;
                                this.Close();
                                administratorMenu.Show();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден");
                    }
                }
            }
        }
    }
}
