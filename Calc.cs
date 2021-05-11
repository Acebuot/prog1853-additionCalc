using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Luis <3 <3
namespace Calculator
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int input1;
            int input2;
            
            //get useer input
            if (int.TryParse(value1Txt.Text, out input1) && int.TryParse(value2Txt.Text, out input2))
            {
                //Calculation
                int result = input1 + input2;

                //output
                resultTxt.Text = result.ToString();

                //change text back to black (incase it was wrong)
                value1Txt.ForeColor = Color.Black;
                value2Txt.ForeColor = Color.Black;
            }
            else
            {
                //if any of the input can't be parsed, turn text to red
                double doubleVal1;
                double doubleVal2;
                if (!double.TryParse(value1Txt.Text, out doubleVal1))
                    value1Txt.ForeColor = Color.Red;
                if (!double.TryParse(value2Txt.Text, out doubleVal2))
                    value2Txt.ForeColor = Color.Red;
            }
            
            

            
            

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear textboxes
            value1Txt.Text = ""; //set text to empty string
            value2Txt.Clear(); //use clear() method
            resultTxt.Clear();

            //set focus to first textbox
            value1Txt.Focus();

            //change text back to black (incase it was wrong)
            value1Txt.ForeColor = Color.Black;
            value2Txt.ForeColor = Color.Black;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
            else
            {
                MessageBox.Show("You're a Pussy", "Alert!");
                this.Close();
            }

        }

    }//class
}//namespace
