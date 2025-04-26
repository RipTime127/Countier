using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Countier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;




        }

        private void Settings_Click(object sender, EventArgs e)
        {
            SettingsForm SettingsForm = new SettingsForm();
            SettingsForm.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        public void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:

            System.Diagnostics.Process.Start(DataBank.Followlink);
            //followlink = enterlink

        }
        void SaveBalance(string sumbalance/*chto*/, string tb/*gde*/)   //////txt
        {
            if (sumbalance.Count() > 1)
            {
                if (File.Exists(tb))
                    File.Create(tb).Close();
                File.WriteAllText(tb, sumbalance);
            }
        }
        void SaveMaxPricePB(string MaxPriceForPBstr/*chto*/, string tyt/*gde*/)
        {
            if (MaxPriceForPBstr.Count() > 1)
            {
                if (File.Exists(tyt))
                    File.Create(tyt).Close();
                File.WriteAllText(tyt, MaxPriceForPBstr);
            }
        }

        private void Form1_Load(object sender, EventArgs e)  //////txt
        {
            string txtlink = @"D:\It\Countier3\bin\Debug\Link.txt";
            if (File.Exists(txtlink))
            {
                File.ReadAllText(txtlink);
                DataBank.Followlink = File.ReadAllText(txtlink);
            }
            string txtprocentforsn = @"D:\It\Countier3\bin\Debug\ProcentForSafetyNet.txt";
            if (File.Exists(txtprocentforsn))
            {
                File.ReadAllText(txtprocentforsn);
                DataBank.ProcentSN = File.ReadAllText(txtprocentforsn);
            }
            string txtprocentforep = @"D:\It\Countier3\bin\Debug\ProcentForEmergencyPlan.txt";
            if (File.Exists(txtprocentforep))
            {
                File.ReadAllText(txtprocentforep);
                DataBank.ProcentEP = File.ReadAllText(txtprocentforep);
            }
            string txtpfr = @"D:\It\Countier3\bin\Debug\ProcentForRent.txt";
            if (File.Exists(txtpfr))
            {
                File.ReadAllText(txtpfr);
                DataBank.ProcentFR = File.ReadAllText(txtpfr);
            }
            string txte = @"D:\It\Countier3\bin\Debug\ProcentEat.txt";
            if (File.Exists(txte))
            {
                File.ReadAllText(txte);
                DataBank.ProcentEat = File.ReadAllText(txte);
            }
            string txtinv = @"D:\It\Countier3\bin\Debug\ProcentInvestments.txt";
            if (File.Exists(txtinv))
            {
                File.ReadAllText(txtinv);
                DataBank.ProcentInv = File.ReadAllText(txtinv);
            }
            string txtfc = @"D:\It\Countier3\bin\Debug\ProcentFreeCash.txt";
            if (File.Exists(txtfc))
            {
                File.ReadAllText(txtfc);
                DataBank.ProcentFC = File.ReadAllText(txtfc);
            }
            string txtbalance = @"D:\It\Countier3\bin\Debug\BALANCE.txt";
            if (File.Exists(txtbalance))
            {
                File.ReadAllText(txtbalance);
                DataBank.Balance = File.ReadAllText(txtbalance);
            }
            string txtMaxPriceForPB = @"D:\It\Countier3\bin\Debug\MaxPriceForPB.txt";
            if (File.Exists(txtMaxPriceForPB))
            {
                File.ReadAllText(txtMaxPriceForPB);
                DataBank.MaxPriceForPB = File.ReadAllText(txtMaxPriceForPB);
            }
            string txtpayday1 = @"D:\It\Countier3\bin\Debug\PayDay.txt";
            if (File.Exists(txtpayday1))
            {
                File.ReadAllText(txtpayday1);
                DataBank.PayDay = File.ReadAllText(txtpayday1);
            }
            string txtUserSalary1 = @"D:\It\Countier3\bin\Debug\UserSalary.txt";
            if (File.Exists(txtUserSalary1))
            {
                File.ReadAllText(txtUserSalary1);
                DataBank.UserSalary = File.ReadAllText(txtUserSalary1);
            }
            string txtCS = @"D:\It\Countier3\bin\Debug\Subscriptions.txt";
            if (File.Exists(txtCS))
            {
                File.ReadAllText(txtCS);
                DataBank.CostSub = File.ReadAllText(txtCS);
            }
            safetynetlabel.Text = "SafetyNet: " + DataBank.ProcentSN;
            emergencyplanlabel.Text = "EmergencyPlan: " + DataBank.ProcentEP;
            arendalabel.Text = "For Rent: " + DataBank.ProcentFR;
            eatlabel.Text = "Eat: " + DataBank.ProcentEat;
            invlabel.Text = "Investments: " + DataBank.ProcentInv;
            cashlabel.Text = "Free Cash: " + DataBank.ProcentFC;
            ////////////////////////////////////////////////
            ///

            int currentDayOfMonth = DateTime.Now.Day;      /// счетчик дней
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            if (currentDayOfMonth == int.Parse(DataBank.PayDay))
            {
                MessageBox.Show("Зарплата добавилась на баланс программы. С вычетом подписок если они были.", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int balance = int.Parse(DataBank.Balance);
                balance = int.Parse(DataBank.Balance) + int.Parse(DataBank.UserSalary);
                DataBank.Balance = balance.ToString();
                balance = int.Parse(DataBank.Balance) - int.Parse(DataBank.CostSub);
                DataBank.Balance = balance.ToString();
                SaveBalance(DataBank.Balance, "BALANCE.txt");


            }
            ConsoleListBox.Items.Add(currentDayOfMonth + "." + currentMonth + "." + currentYear + " |Ваш баланс составляет: " + DataBank.Balance + " UAH");
            progressBar1.Minimum = 0;
            progressBar1.Maximum = int.Parse(DataBank.MaxPriceForPB);
            if (int.Parse(DataBank.MaxPriceForPB) > int.Parse(DataBank.Balance))
            {
                progressBar1.Value = int.Parse(DataBank.Balance);
            }
            else
            {
                MessageBox.Show("Цель была достигнута", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Value = 0;
            }





            /*            double doublepfr = double.Parse(DataBank.ProcentFR);
                        double doublebalance = double.Parse(DataBank.Balance); 
                        DataBank.AddRent = (doublepfr / 100) * doublebalance;*/


        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            CalculatorForm CalculatorForm = new CalculatorForm();
            CalculatorForm.Show();

        }

        private void ConfirmbalnceButton_Click(object sender, EventArgs e)
        {
            double sumbalance = double.Parse(DataBank.Balance);

            if (double.TryParse(balanceTextBox.Text, out double number))
            {
                sumbalance += number;
                DataBank.Balance = sumbalance.ToString();
                ConsoleListBox.Items.Add("Поступление на баланс: " + number + " UAH");
                ConsoleListBox.Items.Add("/// Всего на балансе: " + DataBank.Balance + " UAH");
                ConsoleListBox.Items.Add("==========================");
                SaveBalance(DataBank.Balance, "BALANCE.txt");
            }
            else
            {
                MessageBox.Show("Число не верное.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

        }

        private void browserbutton_Click(object sender, EventArgs e)
        {
            BrowserForm BrowserForm = new BrowserForm();
            BrowserForm.Show();
        }

        private void ConfirmMaxPriceForPB_Click(object sender, EventArgs e)
        {
            if (int.TryParse(MaxpriceTextBox.Text, out int nothink))
            {
                DataBank.MaxPriceForPB = MaxpriceTextBox.Text;
                SaveMaxPricePB(DataBank.MaxPriceForPB, "MaxPriceForPB.txt");
                Form4 Form4 = new Form4();
                Form4.Show();
                progressBar1.Maximum = int.Parse(DataBank.MaxPriceForPB);
            }
            else
            {
                MessageBox.Show("Введите цельное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            ReloadButton.FlatAppearance.BorderSize = 0;
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            safetynetlabel.Text = "SafetyNet: " + DataBank.ProcentSN;
            emergencyplanlabel.Text = "EmergencyPlan: " + DataBank.ProcentEP;
            arendalabel.Text = "For Rent: " + DataBank.ProcentFR;
            eatlabel.Text = "Eat: " + DataBank.ProcentEat;
            invlabel.Text = "Investments: " + DataBank.ProcentInv;
            cashlabel.Text = "Free Cash: " + DataBank.ProcentFC;
            Form4 Form4 = new Form4();
            Form4.Show();
        }

        private void SaveDataToTxt(ListBox.ObjectCollection items)
        {
            using (StreamWriter writer = new StreamWriter("Report.txt", true)) // true означает режим добавления
            {
                foreach (var item in items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // SaveListBoxReport(ConsoleListBox.Text, "Report.txt");
            SaveDataToTxt(ConsoleListBox.Items);
        }
    }
}
