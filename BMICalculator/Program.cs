using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * BMI Calculator
 * Description: COMP123 Assignment 4
 * Author: Joyeeta Nandi
 * Student ID: 300757798
 * Version: 2.4 Additional features and validation added
 * Last modified: July 24, 2019
  */
namespace BMICalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculatorForm());
        }
    }
}
