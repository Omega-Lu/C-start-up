using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Calculators : Form
    {
        public Calculators()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;
            txtAnswer.Text += mybutton.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;
            txtAnswer.Text += mybutton.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;
            txtAnswer.Text += mybutton.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;
            txtAnswer.Text += mybutton.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;
            txtAnswer.Text += mybutton.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;
            txtAnswer.Text += mybutton.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;
            txtAnswer.Text += mybutton.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;
            txtAnswer.Text += mybutton.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;
            txtAnswer.Text += mybutton.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;
            txtAnswer.Text += mybutton.Text;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;
            txtAnswer.Text += " " + operatorButton.Text + " ";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;
            txtAnswer.Text += " " + operatorButton.Text + " ";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;
            txtAnswer.Text += " " + operatorButton.Text + " ";
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;
            txtAnswer.Text += " " + operatorButton.Text + " ";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;
            txtAnswer.Text += " " + operatorButton.Text + " ";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                txtAnswer.Text = dt.Compute(txtAnswer.Text, "").ToString();

                if (txtAnswer.Text.Contains("."))
                {
                    if (txtAnswer.Text.Contains("."))
                    {
                        txtAnswer.Text = "Error";
                        label1.Text = "THIS CALCULATOR ONLY TAKES INTEGERS";
                        label1.Visible = true;
                    }
                }
            }
            catch (Exception)
            {
                txtAnswer.Text = "Error";
                label1.Text = "An Error has Occured";
                label1.ForeColor = Color.Red;
                label1.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAnswer.Text = "";
            label1.Visible = false;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;
            txtAnswer.Text += " " + operatorButton.Text + " ";
        }

    }
}
