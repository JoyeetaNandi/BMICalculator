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
 * Version: BMI Calculator Assignment 4
 * Last modified: July 26, 2019
  */
namespace BMICalculator
{
    static class Program
    {
        public static SplashForm splashForm;
        public static BMICalculatorForm bMICalculatorForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashForm = new SplashForm();
            bMICalculatorForm = new BMICalculatorForm();
            Application.Run(new SplashForm());
        }
    }
}
