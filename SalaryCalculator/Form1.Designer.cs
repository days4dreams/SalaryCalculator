namespace SalaryCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAnnualSalary = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAnnualSalary = new System.Windows.Forms.Label();
            this.groupBoxUserDetails = new System.Windows.Forms.GroupBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.radioButtonAge3 = new System.Windows.Forms.RadioButton();
            this.radioButtonAge2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAge1 = new System.Windows.Forms.RadioButton();
            this.labelAgeRange = new System.Windows.Forms.Label();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.labelTakeHome = new System.Windows.Forms.Label();
            this.labelNI = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelDailyGross = new System.Windows.Forms.Label();
            this.labelWeeklyGross = new System.Windows.Forms.Label();
            this.labelMonthlyGross = new System.Windows.Forms.Label();
            this.labelYearlyGross = new System.Windows.Forms.Label();
            this.textBoxTakeHome = new System.Windows.Forms.TextBox();
            this.textBoxNI = new System.Windows.Forms.TextBox();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.textBoxDailyGross = new System.Windows.Forms.TextBox();
            this.textBoxWeeklyGross = new System.Windows.Forms.TextBox();
            this.textBoxMonthlyGross = new System.Windows.Forms.TextBox();
            this.textBoxYearlyGross = new System.Windows.Forms.TextBox();
            this.groupBoxUserDetails.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAnnualSalary
            // 
            this.textBoxAnnualSalary.Location = new System.Drawing.Point(86, 27);
            this.textBoxAnnualSalary.Name = "textBoxAnnualSalary";
            this.textBoxAnnualSalary.Size = new System.Drawing.Size(202, 20);
            this.textBoxAnnualSalary.TabIndex = 0;
            this.textBoxAnnualSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxAnnualSalary.TextChanged += new System.EventHandler(this.textBoxAnnualSalary_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(129, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "The Salary Calculator";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAnnualSalary
            // 
            this.labelAnnualSalary.AutoSize = true;
            this.labelAnnualSalary.Location = new System.Drawing.Point(8, 30);
            this.labelAnnualSalary.Name = "labelAnnualSalary";
            this.labelAnnualSalary.Size = new System.Drawing.Size(75, 13);
            this.labelAnnualSalary.TabIndex = 2;
            this.labelAnnualSalary.Text = "Annual Salary:";
            // 
            // groupBoxUserDetails
            // 
            this.groupBoxUserDetails.Controls.Add(this.buttonCalculate);
            this.groupBoxUserDetails.Controls.Add(this.radioButtonAge3);
            this.groupBoxUserDetails.Controls.Add(this.radioButtonAge2);
            this.groupBoxUserDetails.Controls.Add(this.radioButtonAge1);
            this.groupBoxUserDetails.Controls.Add(this.labelAgeRange);
            this.groupBoxUserDetails.Controls.Add(this.labelAnnualSalary);
            this.groupBoxUserDetails.Controls.Add(this.textBoxAnnualSalary);
            this.groupBoxUserDetails.Location = new System.Drawing.Point(12, 49);
            this.groupBoxUserDetails.Name = "groupBoxUserDetails";
            this.groupBoxUserDetails.Size = new System.Drawing.Size(302, 124);
            this.groupBoxUserDetails.TabIndex = 3;
            this.groupBoxUserDetails.TabStop = false;
            this.groupBoxUserDetails.Text = "Your Details";
            this.groupBoxUserDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(86, 88);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(202, 23);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // radioButtonAge3
            // 
            this.radioButtonAge3.AutoSize = true;
            this.radioButtonAge3.Location = new System.Drawing.Point(230, 59);
            this.radioButtonAge3.Name = "radioButtonAge3";
            this.radioButtonAge3.Size = new System.Drawing.Size(63, 17);
            this.radioButtonAge3.TabIndex = 6;
            this.radioButtonAge3.TabStop = true;
            this.radioButtonAge3.Text = "Over 65";
            this.radioButtonAge3.UseVisualStyleBackColor = true;
            // 
            // radioButtonAge2
            // 
            this.radioButtonAge2.AutoSize = true;
            this.radioButtonAge2.Location = new System.Drawing.Point(163, 59);
            this.radioButtonAge2.Name = "radioButtonAge2";
            this.radioButtonAge2.Size = new System.Drawing.Size(58, 17);
            this.radioButtonAge2.TabIndex = 5;
            this.radioButtonAge2.TabStop = true;
            this.radioButtonAge2.Text = "18 - 65";
            this.radioButtonAge2.UseVisualStyleBackColor = true;
            // 
            // radioButtonAge1
            // 
            this.radioButtonAge1.AutoSize = true;
            this.radioButtonAge1.Location = new System.Drawing.Point(86, 59);
            this.radioButtonAge1.Name = "radioButtonAge1";
            this.radioButtonAge1.Size = new System.Drawing.Size(69, 17);
            this.radioButtonAge1.TabIndex = 4;
            this.radioButtonAge1.TabStop = true;
            this.radioButtonAge1.Text = "Under 18";
            this.radioButtonAge1.UseVisualStyleBackColor = true;
            this.radioButtonAge1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelAgeRange
            // 
            this.labelAgeRange.AutoSize = true;
            this.labelAgeRange.Location = new System.Drawing.Point(8, 59);
            this.labelAgeRange.Name = "labelAgeRange";
            this.labelAgeRange.Size = new System.Drawing.Size(64, 13);
            this.labelAgeRange.TabIndex = 3;
            this.labelAgeRange.Text = "Age Range:";
            this.labelAgeRange.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.labelTakeHome);
            this.groupBoxOutput.Controls.Add(this.labelNI);
            this.groupBoxOutput.Controls.Add(this.labelTax);
            this.groupBoxOutput.Controls.Add(this.labelDailyGross);
            this.groupBoxOutput.Controls.Add(this.labelWeeklyGross);
            this.groupBoxOutput.Controls.Add(this.labelMonthlyGross);
            this.groupBoxOutput.Controls.Add(this.labelYearlyGross);
            this.groupBoxOutput.Controls.Add(this.textBoxTakeHome);
            this.groupBoxOutput.Controls.Add(this.textBoxNI);
            this.groupBoxOutput.Controls.Add(this.textBoxTax);
            this.groupBoxOutput.Controls.Add(this.textBoxDailyGross);
            this.groupBoxOutput.Controls.Add(this.textBoxWeeklyGross);
            this.groupBoxOutput.Controls.Add(this.textBoxMonthlyGross);
            this.groupBoxOutput.Controls.Add(this.textBoxYearlyGross);
            this.groupBoxOutput.Location = new System.Drawing.Point(12, 193);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(302, 228);
            this.groupBoxOutput.TabIndex = 4;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Your Salary";
            // 
            // labelTakeHome
            // 
            this.labelTakeHome.AutoSize = true;
            this.labelTakeHome.Location = new System.Drawing.Point(9, 198);
            this.labelTakeHome.Name = "labelTakeHome";
            this.labelTakeHome.Size = new System.Drawing.Size(102, 13);
            this.labelTakeHome.TabIndex = 13;
            this.labelTakeHome.Text = "Annual Take Home:";
            // 
            // labelNI
            // 
            this.labelNI.AutoSize = true;
            this.labelNI.Location = new System.Drawing.Point(9, 172);
            this.labelNI.Name = "labelNI";
            this.labelNI.Size = new System.Drawing.Size(81, 13);
            this.labelNI.TabIndex = 12;
            this.labelNI.Text = "Annual NI Paid:";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(8, 146);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(88, 13);
            this.labelTax.TabIndex = 11;
            this.labelTax.Text = "Annual Tax Paid:";
            this.labelTax.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelDailyGross
            // 
            this.labelDailyGross.AutoSize = true;
            this.labelDailyGross.Location = new System.Drawing.Point(8, 108);
            this.labelDailyGross.Name = "labelDailyGross";
            this.labelDailyGross.Size = new System.Drawing.Size(63, 13);
            this.labelDailyGross.TabIndex = 10;
            this.labelDailyGross.Text = "Daily Gross:";
            // 
            // labelWeeklyGross
            // 
            this.labelWeeklyGross.AutoSize = true;
            this.labelWeeklyGross.Location = new System.Drawing.Point(8, 82);
            this.labelWeeklyGross.Name = "labelWeeklyGross";
            this.labelWeeklyGross.Size = new System.Drawing.Size(76, 13);
            this.labelWeeklyGross.TabIndex = 9;
            this.labelWeeklyGross.Text = "Weekly Gross:";
            // 
            // labelMonthlyGross
            // 
            this.labelMonthlyGross.AutoSize = true;
            this.labelMonthlyGross.Location = new System.Drawing.Point(8, 56);
            this.labelMonthlyGross.Name = "labelMonthlyGross";
            this.labelMonthlyGross.Size = new System.Drawing.Size(77, 13);
            this.labelMonthlyGross.TabIndex = 8;
            this.labelMonthlyGross.Text = "Monthly Gross:";
            // 
            // labelYearlyGross
            // 
            this.labelYearlyGross.AutoSize = true;
            this.labelYearlyGross.Location = new System.Drawing.Point(8, 30);
            this.labelYearlyGross.Name = "labelYearlyGross";
            this.labelYearlyGross.Size = new System.Drawing.Size(69, 13);
            this.labelYearlyGross.TabIndex = 7;
            this.labelYearlyGross.Text = "Yearly Gross:";
            this.labelYearlyGross.Click += new System.EventHandler(this.labelYearlyGross_Click);
            // 
            // textBoxTakeHome
            // 
            this.textBoxTakeHome.Location = new System.Drawing.Point(129, 195);
            this.textBoxTakeHome.Name = "textBoxTakeHome";
            this.textBoxTakeHome.Size = new System.Drawing.Size(159, 20);
            this.textBoxTakeHome.TabIndex = 6;
            // 
            // textBoxNI
            // 
            this.textBoxNI.Location = new System.Drawing.Point(129, 169);
            this.textBoxNI.Name = "textBoxNI";
            this.textBoxNI.Size = new System.Drawing.Size(159, 20);
            this.textBoxNI.TabIndex = 5;
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(129, 143);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(159, 20);
            this.textBoxTax.TabIndex = 4;
            this.textBoxTax.TextChanged += new System.EventHandler(this.textBoxTax_TextChanged);
            // 
            // textBoxDailyGross
            // 
            this.textBoxDailyGross.Location = new System.Drawing.Point(129, 105);
            this.textBoxDailyGross.Name = "textBoxDailyGross";
            this.textBoxDailyGross.Size = new System.Drawing.Size(159, 20);
            this.textBoxDailyGross.TabIndex = 3;
            // 
            // textBoxWeeklyGross
            // 
            this.textBoxWeeklyGross.Location = new System.Drawing.Point(129, 79);
            this.textBoxWeeklyGross.Name = "textBoxWeeklyGross";
            this.textBoxWeeklyGross.Size = new System.Drawing.Size(159, 20);
            this.textBoxWeeklyGross.TabIndex = 2;
            // 
            // textBoxMonthlyGross
            // 
            this.textBoxMonthlyGross.Location = new System.Drawing.Point(129, 53);
            this.textBoxMonthlyGross.Name = "textBoxMonthlyGross";
            this.textBoxMonthlyGross.Size = new System.Drawing.Size(159, 20);
            this.textBoxMonthlyGross.TabIndex = 1;
            // 
            // textBoxYearlyGross
            // 
            this.textBoxYearlyGross.Location = new System.Drawing.Point(129, 27);
            this.textBoxYearlyGross.Name = "textBoxYearlyGross";
            this.textBoxYearlyGross.Size = new System.Drawing.Size(159, 20);
            this.textBoxYearlyGross.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 433);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxUserDetails);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxUserDetails.ResumeLayout(false);
            this.groupBoxUserDetails.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAnnualSalary;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAnnualSalary;
        private System.Windows.Forms.GroupBox groupBoxUserDetails;
        private System.Windows.Forms.Label labelAgeRange;
        private System.Windows.Forms.RadioButton radioButtonAge1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.RadioButton radioButtonAge3;
        private System.Windows.Forms.RadioButton radioButtonAge2;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label labelMonthlyGross;
        private System.Windows.Forms.Label labelYearlyGross;
        private System.Windows.Forms.TextBox textBoxTakeHome;
        private System.Windows.Forms.TextBox textBoxNI;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.TextBox textBoxDailyGross;
        private System.Windows.Forms.TextBox textBoxWeeklyGross;
        private System.Windows.Forms.TextBox textBoxMonthlyGross;
        private System.Windows.Forms.TextBox textBoxYearlyGross;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelDailyGross;
        private System.Windows.Forms.Label labelWeeklyGross;
        private System.Windows.Forms.Label labelTakeHome;
        private System.Windows.Forms.Label labelNI;
    }
}

