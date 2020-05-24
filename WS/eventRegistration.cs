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
    public partial class eventRegistration : Form
    {
        public string runnerEmail = "";
        private int runnerId = 0;
        private int count = 0;
        private string raceKit = "";
        public eventRegistration()
        {
            InitializeComponent();

            toBack.Click += new EventHandler(goToBack);
            cancel.Click += new EventHandler(goToBack);

            fullDistance.CheckedChanged += new EventHandler(marathoneType);
            mediumDistance.CheckedChanged += new EventHandler(marathoneType);
            ShortDistance.CheckedChanged += new EventHandler(marathoneType);

        }

        private void eventRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                using(MarathonEntities context = new MarathonEntities())
                {
                    IQueryable<Runner> runners = from runner in context.Runner where runner.Email == runnerEmail select runner;
                    runnerId = runners.First().RunnerId;

                    IQueryable<Charity> charities = from charity in context.Charity select charity;

                    foreach(var charity in charities)
                    {
                        selectCharity.Items.Add(charity.CharityName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сервера" + ex.ToString());
            }
        }

        private void goToBack(object sender, EventArgs e)
        {
            newRunnerRegistration newRunner = new newRunnerRegistration();
            this.Close();
            newRunner.Show();
        }

        private void marathoneType(object sender, EventArgs e)
        {
            if(sender == fullDistance)
            {
                if(fullDistance.Checked)
                {
                    count += 145;
                    countLabel.Text = "$ " + count.ToString();
                }
                else
                {
                    count -= 145;
                    countLabel.Text = "$ " + count.ToString();
                }
            }
            else if(sender == mediumDistance)
            {
                if(mediumDistance.Checked)
                {
                    count += 75;
                    countLabel.Text = "$ " + count.ToString();
                }
                else
                {
                    count -= 75;
                    countLabel.Text = "$ " + count.ToString();
                }
            }
            else
            {
                if(ShortDistance.Checked)
                {
                    count += 20;
                    countLabel.Text = "$ " + count.ToString();
                }
                else
                {
                    count -= 20;
                    countLabel.Text = "$ " + count.ToString();
                }
            }
        }

        private void complectsVariants(object sender, EventArgs e)
        {
            if(sender == variantA)
            {
                if(variantA.Checked)
                {
                    raceKit = "A";
                }
            }
            else if(sender == variantB)
            {
                if(variantB.Checked)
                {
                    count += 20;
                    raceKit = "B";
                    countLabel.Text = "$ " + count.ToString();
                }
                else
                {
                    count -= 20;
                    countLabel.Text = "$ " + count.ToString();
                }
            }
            else
            {
                if(variantC.Checked)
                {
                    count += 45;
                    raceKit = "C";
                    countLabel.Text = "$ " + count.ToString();
                }
                else
                {
                    count -= 45;
                    countLabel.Text = "$ " + count.ToString();
                }
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }

        private void SponsorshipTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void registration_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            using(MarathonEntities context = new MarathonEntities())
            {

                IQueryable<Charity> charities = from charity in context.Charity where charity.CharityName == selectCharity.Text select charity;

                if((fullDistance.Checked == false && mediumDistance.Checked == false && ShortDistance.Checked == false) || (variantA.Checked == false && variantB.Checked == false && variantC.Checked == false) || selectCharity.SelectedIndex == -1 || SponsorshipTarget.Text.Trim() == "")
                {
                    MessageBox.Show("Заполните все поля");
                }
                else if(decimal.Parse(SponsorshipTarget.Text) < 0)
                {
                    MessageBox.Show("Сумма вклада не может быть отрицательной");
                }
                else
                {
                    Registration registration = new Registration()
                    {
                        RunnerId = runnerId,
                        RegistrationDateTime = now,
                        RaceKitOptionId = raceKit,
                        RegistrationStatusId = 1,
                        Cost = count,
                        CharityId = charities.First().CharityId,
                        SponsorshipTarget = decimal.Parse(SponsorshipTarget.Text)
                    };

                    try
                    {
                        context.Registration.Add(registration);
                        context.SaveChanges();

                        registrationConfirmation confirmation = new registrationConfirmation();
                        confirmation.runnerId = runnerId;
                        this.Close();
                        confirmation.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка сервера");
                    }
                }
            }
        }
    }
}
