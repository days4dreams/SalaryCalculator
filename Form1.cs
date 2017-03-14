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
        public double ta { get; set; }
        public double monthly { get; set; }
        public double weekly { get; set; }
        public double daily { get; set; }
        public double ni { get; set; }
        public double th { get; set; }

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
                    ta = 9;
                    ni = 8;
                }
                else if (sal > 11001 && sal < 32000)
                {
                    ta = ((sal - 11000) * 0.2);
                    ni = ((sal - 8000) * 0.12);
                }
                else if (sal > 320001 && sal < 150000)
                {
                    ta = (((sal - 43000) * 0.4) + 6400);
                    ni = ((sal - 8000) * 0.12);
            }
                else if (sal > 150000)
                {
                    ta = (((sal - 150000) * 0.45) + 6400 + 47200);
                    ni = ((sal - 8000) * 0.12);
            }

                textBoxTax.Text = ("" + ta);
                textBoxNI.Text = ("" + ni);


                monthly = (sal / 12);
                textBoxMonthlyGross.Text = ("" + monthly);

                weekly = (sal / 52);
                textBoxWeeklyGross.Text = ("" + weekly);

                daily = (sal / 365);
                textBoxDailyGross.Text = ("" + daily);

            textBoxYearlyGross.Text = (textBoxAnnualSalary.Text);

                 th = (sal - (ta + ni));
                 textBoxTakeHome.Text = ("" + th);
        }

        public void textBoxTax_TextChanged(object sender, EventArgs e)
        {
            sal = Convert.ToDouble(textBoxAnnualSalary.Text);

            band myband = new band();
            textBoxTax.Text = ("" + ta);
        }
    }

}

