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
            
            //get useer input
            Int32 input1 = int.Parse(value1Txt.Text);
            int input2 = Convert.ToInt32(value2Txt.Text);

            //Calculation
            int result = input1 + input2;

            //output
            resultTxt.Text = result.ToString();
            

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear textboxes
            value1Txt.Text = ""; //set text to empty string
            value2Txt.Clear(); //use clear() method
            resultTxt.Clear();

            //set focus to first textbox
            value1Txt.Focus();
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
