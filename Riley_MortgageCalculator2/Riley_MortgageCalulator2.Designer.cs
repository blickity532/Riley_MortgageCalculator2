using System;
using System.Windows.Forms;

namespace Riley_MortgageCalculator2
{
    public partial class Form1 : Form
    {
        private double principal;
        private int numberOfPayments;
        private double monthlyInterestRate;

        private Label labelPrinciple;
        private TextBox textBoxPrinciple;
        private Label labelTermsInYears;
        private RadioButton radioButton15Years;
        private RadioButton radioButton30Years;
        private RadioButton radioButtonOther;
        private TextBox textBoxOtherYears;
        private ComboBox comboBoxInterestRate;
        private Label labelInterest;
        private Button buttonCalculate;
        private Button buttonReset;
        private Button buttonExit;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Riley : Mortgage Calculator";

            for (double rate = 3.0; rate <= 4.5; rate += 0.1)
            {
                comboBoxInterestRate.Items.Add(rate.ToString("F1"));
            }

            radioButton30Years.Checked = true;
            textBoxOtherYears.Visible = false;
            textBoxOtherYears.Enabled = false;
            comboBoxInterestRate.SelectedIndex = 0;
        }

        private void InitializeComponent()
        {
            this.labelPrinciple = new System.Windows.Forms.Label();
            this.textBoxPrinciple = new System.Windows.Forms.TextBox();
            this.labelTermsInYears = new System.Windows.Forms.Label();
            this.radioButton15Years = new System.Windows.Forms.RadioButton();
            this.radioButton30Years = new System.Windows.Forms.RadioButton();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.textBoxOtherYears = new System.Windows.Forms.TextBox();
            this.comboBoxInterestRate = new System.Windows.Forms.ComboBox();
            this.labelInterest = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.Principal1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPrinciple
            // 
            this.labelPrinciple.Location = new System.Drawing.Point(0, 0);
            this.labelPrinciple.Name = "labelPrinciple";
            this.labelPrinciple.Size = new System.Drawing.Size(100, 23);
            this.labelPrinciple.TabIndex = 0;
            // 
            // textBoxPrinciple
            // 
            this.textBoxPrinciple.Location = new System.Drawing.Point(0, 0);
            this.textBoxPrinciple.Name = "textBoxPrinciple";
            this.textBoxPrinciple.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrinciple.TabIndex = 0;
            // 
            // labelTermsInYears
            // 
            this.labelTermsInYears.Location = new System.Drawing.Point(0, 0);
            this.labelTermsInYears.Name = "labelTermsInYears";
            this.labelTermsInYears.Size = new System.Drawing.Size(100, 23);
            this.labelTermsInYears.TabIndex = 0;
            // 
            // radioButton15Years
            // 
            this.radioButton15Years.Location = new System.Drawing.Point(0, 0);
            this.radioButton15Years.Name = "radioButton15Years";
            this.radioButton15Years.Size = new System.Drawing.Size(104, 24);
            this.radioButton15Years.TabIndex = 0;
            // 
            // radioButton30Years
            // 
            this.radioButton30Years.Location = new System.Drawing.Point(0, 0);
            this.radioButton30Years.Name = "radioButton30Years";
            this.radioButton30Years.Size = new System.Drawing.Size(104, 24);
            this.radioButton30Years.TabIndex = 0;
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.Location = new System.Drawing.Point(0, 0);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(104, 24);
            this.radioButtonOther.TabIndex = 0;
            // 
            // textBoxOtherYears
            // 
            this.textBoxOtherYears.Location = new System.Drawing.Point(0, 0);
            this.textBoxOtherYears.Name = "textBoxOtherYears";
            this.textBoxOtherYears.Size = new System.Drawing.Size(100, 22);
            this.textBoxOtherYears.TabIndex = 0;
            // 
            // comboBoxInterestRate
            // 
            this.comboBoxInterestRate.Location = new System.Drawing.Point(0, 0);
            this.comboBoxInterestRate.Name = "comboBoxInterestRate";
            this.comboBoxInterestRate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxInterestRate.TabIndex = 0;
            // 
            // labelInterest
            // 
            this.labelInterest.Location = new System.Drawing.Point(0, 0);
            this.labelInterest.Name = "labelInterest";
            this.labelInterest.Size = new System.Drawing.Size(100, 23);
            this.labelInterest.TabIndex = 0;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(0, 0);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(0, 0);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(0, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            // 
            // Principal1
            // 
            this.Principal1.AutoSize = true;
            this.Principal1.Location = new System.Drawing.Point(36, 25);
            this.Principal1.Name = "Principal1";
            this.Principal1.Size = new System.Drawing.Size(59, 16);
            this.Principal1.TabIndex = 0;
            this.Principal1.Text = "Principal";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(371, 253);
            this.Controls.Add(this.Principal1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            labelInterest.Text = "";

            if (!TryGetPrincipal() || !TryGetNumberOfPayments() || !TryGetMonthlyInterestRate())
                return;

            double numerator = principal * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments);
            double denominator = Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1;
            double monthlyPayment = numerator / denominator;

            labelInterest.Text = $"Monthly Payment: {monthlyPayment.ToString("C")}";
        }

        private bool TryGetPrincipal()
        {
            if (!double.TryParse(textBoxPrinciple.Text, out principal) || principal <= 0)
            {
                MessageBox.Show("Invalid principal amount. Please enter a valid positive number.");
                textBoxPrinciple.Clear();
                textBoxPrinciple.Focus();
                return false;
            }
            return true;
        }

        private bool TryGetNumberOfPayments()
        {
            if (radioButton30Years.Checked)
            {
                numberOfPayments = 30 * 12;
            }
            else if (radioButton15Years.Checked)
            {
                numberOfPayments = 15 * 12;
            }
            else
            {
                if (!int.TryParse(textBoxOtherYears.Text, out numberOfPayments) || numberOfPayments <= 0)
                {
                    MessageBox.Show("Invalid number of years. Please enter a valid positive number.");
                    textBoxOtherYears.Clear();
                    textBoxOtherYears.Focus();
                    return false;
                }
                numberOfPayments *= 12;
            }
            return true;
        }

        private bool TryGetMonthlyInterestRate()
        {
            if (!double.TryParse(comboBoxInterestRate.SelectedItem.ToString(), out monthlyInterestRate) || monthlyInterestRate <= 0)
            {
                MessageBox.Show("Invalid interest rate. Please select a valid positive rate.");
                comboBoxInterestRate.SelectedIndex = 0;
                return false;
            }
            monthlyInterestRate /= 100 / 12;
            return true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxPrinciple.Clear();
            radioButton30Years.Checked = true;
            radioButton15Years.Checked = false;
            radioButtonOther.Checked = false;
            textBoxOtherYears.Clear();
            textBoxOtherYears.Visible = false;
            comboBoxInterestRate.SelectedIndex = 0;
            labelInterest.Text = "";

            textBoxPrinciple.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonOther_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOtherYears.Visible = radioButtonOther.Checked;
            textBoxOtherYears.Enabled = radioButtonOther.Checked;
        }

        private Label Principal1;
    }
}
