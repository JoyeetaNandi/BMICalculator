using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{   
    public partial class BMICalculatorForm : Form
    {
        public TextBox ActiveTextBox { get; set; }
        
        public float outputValue { get; set; }
        public string outputString { get; set; }
        public double displayResult { get; set; }
        public double result { get; set; }


        /// <summary>
        /// This is the contructor for the BMICalculatorForm
        /// </summary>
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is a shared event handler for the NumberButton Click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numberValue=0;
            bool numberResult = int.TryParse(tag, out numberValue);
            if (numberResult)
            {
                outputString += tag;
                ActiveTextBox.Text += tag;
            }
            else
            {
                switch (tag)
                {
                    case "back":
                        if (outputString.Length != 0)
                        {
                            outputString = outputString.Remove(outputString.Length - 1);
                            ActiveTextBox.Text = outputString;
                        }
                        else
                        {

                        }
                        break;
                    case "clear":
                        clearButton();
                        progressBar.Value = 0;
                        break;
                    case "calculateBMI":
                        CalculateBMI();
                        progressBar.Value = 0;
                        DisplayCondition();
                        break;
                }
            }   
            

        }
        private void clearButton()
        {
            ResultTextBox.Text = "";
            ResultTextBox.ForeColor = Color.DarkGray;
            outputString = "";

            ActiveTextBox = HeightTextBox;
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";

        }
        private void DisplayCondition()
        {
            progressBar.Maximum = 4;            
            if (displayResult < 18.5)
            {
                messageMultiLineTextBox.Text = "underweight";
                messageMultiLineTextBox.ForeColor = Color.BlueViolet;
                progressBar.Value = 1;
                progressBar.ForeColor = Color.BlueViolet;
            }
            else if (displayResult >= 18.5 && displayResult <= 24.9)
            {
                messageMultiLineTextBox.Text = "Normal";
                messageMultiLineTextBox.ForeColor = Color.Green;
                progressBar.Value = 2;
                progressBar.ForeColor = Color.Green;
            }
            else if (displayResult >= 25 && displayResult <= 29.9)
            {
                messageMultiLineTextBox.Text = "Over weight";
                messageMultiLineTextBox.ForeColor = Color.Yellow;
                progressBar.Value = 3;
                progressBar.ForeColor = Color.Yellow;
            }
            else if (displayResult >= 30)
            {
                messageMultiLineTextBox.Text = "Obese";
                messageMultiLineTextBox.ForeColor = Color.Red;
                progressBar.Value = 4;
                progressBar.ForeColor = Color.Red;
            }
        }


        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            ImperialRadioButton.Select();
            outputValue = 0;
            outputString = "";
            ActiveTextBox = HeightTextBox;
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MyHeightLabel.Text = "My Height(In)";
            
            MyWeightLabel.Text = "My Weight (lb)";
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MyHeightLabel.Text = "My Height(M)";
            MyWeightLabel.Text = "My Weight (Kg)";

        }        

        private void CalculateBMI()
        {
            int weight;
            int height;            
            displayResult = 0;
            int.TryParse(HeightTextBox.Text, out height);
            int.TryParse(WeightTextBox.Text, out weight);

            if (height != 0 && weight != 0)
            {
                if (ImperialRadioButton.Checked == true)
                {
                    displayResult = weight * 703 / (height * height);
                   
                    ResultTextBox.Text = displayResult.ToString();

                }
                else if (MetricRadioButton.Checked == true)
                {
                    displayResult = weight / (height*height);
                    
                    ResultTextBox.Text = displayResult.ToString();
                }

                
                else
                {
                    ResultTextBox.Text = "Enter all values";
                    ResultTextBox.ForeColor = Color.Red;
                }

            }
            else
            {
                ResultTextBox.Text = "Enter all values";
                ResultTextBox.ForeColor = Color.Red;
            }

        }
        private void ActiveTextBox_click(object sender, EventArgs e)
        {
          
            ActiveTextBox = sender as TextBox;
            outputValue = 0;
            outputString = "";
            //ActiveTextBox.BackColor = Color.Lime;
        }
       
    }
}

