using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * BMI Calculator
 * Description: COMP123 Assignment 4
 * Author: Joyeeta Nandi
 * Student ID: 300757798
 * Version: splash form
 * Last modified: July 26, 2019
  */
namespace BMICalculator
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.splashForm.Close();
            this.Hide();
            Program.bMICalculatorForm.Show();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
    }
}
