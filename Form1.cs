using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

　
        public double sal { get; set; }
        public double taxableAmount { get; set; }
        public double monthly { get; set; }
        public double weekly { get; set; }
        public double daily { get; set; }
        public double ni { get; set; }
        public double takeHome { get; set; }
        public int threshold1 = 11000;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelYearlyGross_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAnnualSalary_TextChanged(object sender, EventArgs e)
        {
  
        }

　
　
        public void buttonCalculate_Click(object sender, EventArgs e)
            {

                sal = Convert.ToDouble(textBoxAnnualSalary.Text);

                    if (sal < 11000)
                    {
                        taxableAmount = 0;
                        ni = 0;
                    }
                    else if (sal > 11001 && sal < 32000)
                    {
                        taxableAmount = ((sal - 11000) * 0.2);
                        ni = ((sal - 8000) * 0.12);
                    }
                    else if (sal > 320001 && sal < 150000)
                    {
                        taxableAmount = (((sal - 43000) * 0.4) + 6400);
                        ni = ((sal - 8000) * 0.12);
                }
                    else if (sal > 150000)
                    {
                        taxableAmount = (((sal - 150000) * 0.45) + 6400 + 47200);
                        ni = ((sal - 8000) * 0.12);
                }

                textBoxTax.Text = ("" + taxableAmount);
                textBoxNI.Text = ("" + ni);

　
                monthly = (sal / 12);
                textBoxMonthlyGross.Text = String.Format("{0:0.00}", monthly);

                weekly = (sal / 52);
                textBoxWeeklyGross.Text = String.Format("{0:0.00}", weekly);

                daily = (sal / 365);
                textBoxDailyGross.Text = String.Format("{0:0.00}", daily);

                textBoxYearlyGross.Text = (textBoxAnnualSalary.Text);

                takeHome = (sal - (taxableAmount + ni));
                textBoxTakeHome.Text = takeHome.ToString();
        }

        public void textBoxTax_TextChanged(object sender, EventArgs e)
        {
            sal = Convert.ToDouble(textBoxAnnualSalary.Text);

            band myband = new band();
            textBoxTax.Text = ("" + taxableAmount);
        }
    }

}
