using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Get the currently selected index from each combo box
            int index1 = comboBox1.SelectedIndex;
            int index2 = comboBox2.SelectedIndex;

            //Decimal to hexadecimal
            if (index1 == 0 && index2 == 1)
            {
                string input = "";
                if (txtInput.Text != "")
                    input = txtInput.Text;
                string output = Convert.ToString(Convert.ToInt32(input, 10), 16);
                txtOutput.Text = output;
            }

            //Decimal to binary
            if (index1 == 0 && index2 == 2)
            {
                string input = "";
                if (txtInput.Text != "")
                    input = txtInput.Text;
                string output = Convert.ToString(Convert.ToInt32(input, 10), 2);
                txtOutput.Text = output;
            }

            //Hexadecimal to decimal
            if (index1 == 1 && index2 == 0)
            {
                string input = "";
                if (txtInput.Text != "")
                    input = txtInput.Text;
                string output = Convert.ToString(Convert.ToInt32(input, 16), 10);
                txtOutput.Text = output;
            }

            //Hexadecimal to binary
            if (index1 == 1 && index2 == 2)
            {
                string input = "";
                if (txtInput.Text != "")
                    input = txtInput.Text;
                string output = Convert.ToString(Convert.ToInt32(input, 16), 2);
                txtOutput.Text = output;
            }

            //Binary to decimal
            if (index1 == 2 && index2 == 0)
            {
                string input = "";
                if (txtInput.Text != "")
                    input = txtInput.Text;
                string output = Convert.ToString(Convert.ToInt32(input, 2), 10);
                txtOutput.Text = output;
            }

            //Binary to hexadecimal
            if (index1 == 2 && index2 == 1)
            {
                string input = "";
                if (txtInput.Text != "")
                    input = txtInput.Text;
                string output = Convert.ToString(Convert.ToInt32(input, 2), 16);
                txtOutput.Text = output;
            }

            //Redundant self-conversions
            if (index1 == index2)
                txtOutput.Text = txtInput.Text;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            //Swap the selected indexes of the combo boxes
            int i = comboBox1.SelectedIndex;
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
            comboBox2.SelectedIndex = i;

            //Swap the text in the text boxes
            string s = txtInput.Text;
            txtInput.Text = txtOutput.Text;
            txtOutput.Text = s;
        }
    }
}
