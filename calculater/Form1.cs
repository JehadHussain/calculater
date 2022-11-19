using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculater
{
    public partial class Form1 : Form
    {
        double resultvalue = 0;
        string operationpreormed = "";
        bool isoerationpreformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (txtdisplayresult.Text == "0" || (isoerationpreformed))
                txtdisplayresult.Clear();
            isoerationpreformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtdisplayresult.Text.Contains("."))
                    txtdisplayresult.Text += button.Text;
            }
            else
            {
                txtdisplayresult.Text += button.Text;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationpreormed = button.Text;
            isoerationpreformed = true;
            resultvalue = double.Parse(txtdisplayresult.Text);
            lbl.Text = resultvalue + " " + operationpreormed;
        }

        private void btncu_Click(object sender, EventArgs e)
        {
            txtdisplayresult.Text = "0";
            resultvalue = 0;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtdisplayresult.Text = "0";
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            if (operationpreormed == "+")
            {
                txtdisplayresult.Text = (resultvalue + double.Parse(txtdisplayresult.Text)).ToString();

            }
            else if (operationpreormed == "-")
            {
                txtdisplayresult.Text = (resultvalue - double.Parse(txtdisplayresult.Text)).ToString();
            }
            else if (operationpreormed == "x")
            {
                txtdisplayresult.Text = (resultvalue * double.Parse(txtdisplayresult.Text)).ToString();
            }
            else if (operationpreormed == "/")
            {
                txtdisplayresult.Text = (resultvalue / double.Parse(txtdisplayresult.Text)).ToString();
            }
        }

        private void btndell_Click(object sender, EventArgs e)
        {
            if (txtdisplayresult.Text.Length > 0)
                txtdisplayresult.Text = txtdisplayresult.Text.Remove(txtdisplayresult.Text.Length - 1, 1);
            if (txtdisplayresult.Text == "")
                txtdisplayresult.Text = "0";
        }
    }
}
