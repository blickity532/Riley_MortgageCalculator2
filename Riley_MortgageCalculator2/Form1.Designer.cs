namespace Riley_MortgageCalculator2
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
            this.Principle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TermsInYears = new System.Windows.Forms.Label();
            this.FifteenYear = new System.Windows.Forms.RadioButton();
            this.ThirtyYear = new System.Windows.Forms.RadioButton();
            this.Other = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Interest = new System.Windows.Forms.Label();
            this.CalculatePayment = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Principle
            // 
            this.Principle.AutoSize = true;
            this.Principle.Location = new System.Drawing.Point(57, 38);
            this.Principle.Name = "Principle";
            this.Principle.Size = new System.Drawing.Size(59, 16);
            this.Principle.TabIndex = 0;
            this.Principle.Text = "Principle";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // TermsInYears
            // 
            this.TermsInYears.AutoSize = true;
            this.TermsInYears.Location = new System.Drawing.Point(57, 80);
            this.TermsInYears.Name = "TermsInYears";
            this.TermsInYears.Size = new System.Drawing.Size(98, 16);
            this.TermsInYears.TabIndex = 2;
            this.TermsInYears.Text = "Terms in Years";
            // 
            // FifteenYear
            // 
            this.FifteenYear.AutoSize = true;
            this.FifteenYear.Location = new System.Drawing.Point(60, 118);
            this.FifteenYear.Name = "FifteenYear";
            this.FifteenYear.Size = new System.Drawing.Size(74, 20);
            this.FifteenYear.TabIndex = 3;
            this.FifteenYear.TabStop = true;
            this.FifteenYear.Text = "15 Year";
            this.FifteenYear.UseVisualStyleBackColor = true;
            this.FifteenYear.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ThirtyYear
            // 
            this.ThirtyYear.AutoSize = true;
            this.ThirtyYear.Location = new System.Drawing.Point(60, 162);
            this.ThirtyYear.Name = "ThirtyYear";
            this.ThirtyYear.Size = new System.Drawing.Size(74, 20);
            this.ThirtyYear.TabIndex = 4;
            this.ThirtyYear.TabStop = true;
            this.ThirtyYear.Text = "30 Year";
            this.ThirtyYear.UseVisualStyleBackColor = true;
            // 
            // Other
            // 
            this.Other.AutoSize = true;
            this.Other.Location = new System.Drawing.Point(60, 208);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(60, 20);
            this.Other.TabIndex = 5;
            this.Other.TabStop = true;
            this.Other.Text = "Other";
            this.Other.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3.1",
            "4.5",
            "other"});
            this.comboBox1.Location = new System.Drawing.Point(184, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // Interest
            // 
            this.Interest.AutoSize = true;
            this.Interest.Location = new System.Drawing.Point(60, 258);
            this.Interest.Name = "Interest";
            this.Interest.Size = new System.Drawing.Size(50, 16);
            this.Interest.TabIndex = 7;
            this.Interest.Text = "Interest";
            // 
            // CalculatePayment
            // 
            this.CalculatePayment.Location = new System.Drawing.Point(184, 335);
            this.CalculatePayment.Name = "CalculatePayment";
            this.CalculatePayment.Size = new System.Drawing.Size(201, 23);
            this.CalculatePayment.TabIndex = 8;
            this.CalculatePayment.Text = "Calculate Payment";
            this.CalculatePayment.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(184, 437);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(309, 437);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.CalculatePayment);
            this.Controls.Add(this.Interest);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.ThirtyYear);
            this.Controls.Add(this.FifteenYear);
            this.Controls.Add(this.TermsInYears);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Principle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Principle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TermsInYears;
        private System.Windows.Forms.RadioButton FifteenYear;
        private System.Windows.Forms.RadioButton ThirtyYear;
        private System.Windows.Forms.RadioButton Other;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Interest;
        private System.Windows.Forms.Button CalculatePayment;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Exit;
    }
}

