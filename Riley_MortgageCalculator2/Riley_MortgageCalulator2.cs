using System;
using System.Windows.Forms;

namespace Riley_MortgageCalculator2
{
    public partial class Form1 : Form
    {
        private double principal;
        private int numberOfPayments;
        private double monthlyInterestRate;

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

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            labelMonthlyPayment.Text = "";

            if (!TryGetPrincipal() || !TryGetNumberOfPayments() || !TryGetMonthlyInterestRate())
                return;

            double numerator = principal * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments);
            double denominator = Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1;
            double monthlyPayment = numerator / denominator;

            labelMonthlyPayment.Text = $"Monthly Payment: {monthlyPayment.ToString("C")}";
        }

        private bool TryGetPrincipal()
        {
            if (!double.TryParse(textBoxPrincipal.Text, out principal) || principal <= 0)
            {
                MessageBox.Show("Invalid principal amount. Please enter a valid positive number.");
                textBoxPrincipal.Clear();
                textBoxPrincipal.Focus();
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
            textBoxPrincipal.Clear();
            radioButton30Years.Checked = true;
            radioButton15Years.Checked = false;
            radioButtonOther.Checked = false;
            textBoxOtherYears.Clear();
            textBoxOtherYears.Visible = false;
            comboBoxInterestRate.SelectedIndex = 0;
            labelMonthlyPayment.Text = "";

            textBoxPrincipal.Focus();
        }

        private void radioButtonOther_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOtherYears.Visible = radioButtonOther.Checked;
            textBoxOtherYears.Enabled = radioButtonOther.Checked;
        }

        internal class form : Form
        {
        }
    }
}
