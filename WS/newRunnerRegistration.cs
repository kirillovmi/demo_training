using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS
{
    public partial class newRunnerRegistration : Form
    {
        public newRunnerRegistration()
        {
            InitializeComponent();

            toBack.Click += new EventHandler(goToBack);
            cancel.Click += new EventHandler(goToBack);

            password.PasswordChar = '*';
            repeat_password.PasswordChar = '*';
        }

        private void goToBack(object sender, EventArgs e)
        {
            runnerRegistration runnerRegistration = new runnerRegistration();
            this.Close();
            runnerRegistration.Show();
        }

        //Проверка валидности почты
        bool emailIsValid(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        private void registration_Click(object sender, EventArgs e)
        {
            try
            {
                using (MarathonEntities context = new MarathonEntities())
                {
                    IQueryable<User> users = from user in context.User where user.Email == email.Text select user;

                    if (!emailIsValid(email.Text))
                    {
                        MessageBox.Show("Введен неверный email");
                    }
                    else if (users.Count() > 0)
                    {
                        MessageBox.Show("Участник с такой почтой уже зарегистрирован");
                    }
                    else if (password.Text != repeat_password.Text)
                    {
                        MessageBox.Show("Пароли не совпадают");
                    }
                    else if (email.Text.Trim() == "" || password.Text.Trim() == "" || repeat_password.Text.Trim() == "" || name.Text.Trim() == "" || second_name.Text.Trim() == "" || selectGender.SelectedIndex == -1 || selectCountry.SelectedIndex == -1)
                    {
                        MessageBox.Show("Заполните все поля");
                    }
                    else
                    {
                        IQueryable<Country> countries = from country in context.Country where country.CountryName == selectCountry.Text select country;

                        User user = new User()
                        {
                            Email = email.Text,
                            Password = password.Text,
                            FirstName = name.Text,
                            LastName = second_name.Text,
                            RoleId = "R"
                        };

                        Runner runner = new Runner()
                        {
                            Email = email.Text,
                            Gender = selectGender.Text,
                            DateOfBirth = birthday.Value,
                            CountryCode = countries.First().CountryCode
                        };

                        context.User.Add(user);
                        context.Runner.Add(runner);
                        context.SaveChanges();

                        eventRegistration eventRegistration = new eventRegistration();
                        eventRegistration.runnerEmail = email.Text;
                        this.Close();
                        eventRegistration.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных");
            }
        }

        private void newRunnerRegistration_Load(object sender, EventArgs e)
        {
            using(MarathonEntities context = new MarathonEntities())
            {
                IQueryable < Gender > genders = from gender in context.Gender select gender;
                IQueryable<Country> countries = from country in context.Country select country;

                foreach(var gender in genders)
                {
                    selectGender.Items.Add(gender.Gender1);
                }

                foreach(var country in countries)
                {
                    selectCountry.Items.Add(country.CountryName);
                }
            }
        }
    }
}
