using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_installment
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (tbxPrice.Text.ToString() == "")
            {
                MessageBox.Show("Please input your price!");
            }
            else if (tbxDown.Text.ToString() == "")
            {
                MessageBox.Show("Please input your down payment!");
            }
            else if (tbxMonth.Text.ToString() == "")
            {
                MessageBox.Show("Please input your month!");
            }
            else if (tbxRate.Text.ToString() == "")
            {
                MessageBox.Show("Please input your rate!");
            }
            else
            {
                double price = Convert.ToDouble(tbxPrice.Text);
                double down = 0;

                if (rbDownMoney.Checked)
                {
                    down = Convert.ToDouble(tbxDown.Text);
                }
                else if (rbDownPercent.Checked)
                {
                    down = price * Convert.ToDouble(tbxDown.Text) / 100;
                }
                else
                {
                    down = Convert.ToDouble(tbxDown.Text);
                }

                double month = Convert.ToDouble(tbxMonth.Text);
                double rate = Convert.ToDouble(tbxRate.Text) / 100;
                double ratePerMonth = rate / 12;
                double finance = price - down;
                double interest = finance * ratePerMonth * month;
                double total = finance + interest;
                double installment = total / month;
                lbResult.Text = installment.ToString("0,000,000.00");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxPrice.Clear();
            tbxDown.Clear();
            tbxMonth.Clear();
            tbxRate.Clear();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
