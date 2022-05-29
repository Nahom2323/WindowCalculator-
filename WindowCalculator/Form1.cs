using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowCalculator
{
    public partial class SmartCalculator : Form
    {
        Double result = 0;
        String operation = "";
        bool enter_value = false;
        String firstnum, secondnum;
        private object btnEquals;

        public SmartCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Numbers(object sender, EventArgs e)
        {
              Button b = (Button)sender;
            if ((txtDisplay.Text == "0")|| (enter_value))
                    txtDisplay.Text = "";
            enter_value = false;

            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        private void Numbers_only(object sender, EventArgs e)
        {
          
        }

        private void operators_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            if (result != 0)
            {
                btnEquals_Click.PerformClick();
                enter_value = true;
                operation = b.Text;
                lblshowOp.Text = result + " " + operation;
            }
            else
            {

                operation = b.Text;
                result = Double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblshowOp.Text = System.Convert.ToString(result) + "   " + operation;

            }
            firstnum = lblshowOp.Text;
        }

        private void btnEquals_Click_Click(object sender, EventArgs e)
        {
            secondnum = txtDisplay.Text;
            lblshowOp.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "x":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "÷":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(txtDisplay.Text);
            operation = "";

            //''''''''''''''''''''
            btnHistory.Visible = true;
            rtbDisplay.AppendText(firstnum + "  " + secondnum + " = " + "\n");
            rtbDisplay.AppendText("\n\t" + txtDisplay.Text + "\n\n");
            lblHISTORY.Text = "";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblshowOp.Text = "";
            
            
        }

        private void C_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
        }

        private void lblHISTORY_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            if(lblHISTORY.Text == "")
            {
                lblHISTORY.Text = " there's no history yet";
            }
            btnHistory.Visible = false;
            rtbDisplay.ScrollBars = 0;
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = "";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if(txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }
    }
}
