using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageValues
{
    public partial class Form1 : Form
    {
        //global
        double totalNumbers;
        double sum;
        double average;
        double num;
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(numberInput.Text);

            if (num == 0)
            {
                average = sum / totalNumbers;
                answerOutput.Text = $"the average is {average}";
            }
            else
            {
                sum += num;
                totalNumbers++;
                answerOutput.Text = $"{num} was added to the sum";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            numberInput.Text = "";
            answerOutput.Text = "";
            totalNumbers = 0;
            sum = 0;
            average = 0;
            num = 0;
        }
    }
}
