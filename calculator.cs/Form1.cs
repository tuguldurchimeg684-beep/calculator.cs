using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator.cs
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool isNewNumber = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isNewNumber)
            {
                txtDisplay.Text = "7";
                isNewNumber = false;
            }
            else
            {
                txtDisplay.Text += "7";
            }
        }
    }
    
}
