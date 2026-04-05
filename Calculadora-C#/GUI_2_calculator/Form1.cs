using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_2_calculator
{
    public partial class FormCalculadora : Form
    {
        int opcao = 0;
        string v1 = "";

        public FormCalculadora()
        { 
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txbtInterface.Text == "" && txbtInterface.Text != null)
            {
                txbtInterface.Text = "1";
            }
            else
            {
                txbtInterface.Text = txbtInterface.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txbtInterface.Text == "" && txbtInterface.Text != null)
            {
                txbtInterface.Text = "2";
            }
            else
            {
                txbtInterface.Text = txbtInterface.Text + "2";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbtInterface.Text = txbtInterface.Text + "0";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbtInterface.Text = txbtInterface.Text + "3";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            switch (opcao)
            {
                case 1:

                    txbtInterface.Text = (Convert.ToInt32(v1) - Convert.ToInt32(txbtInterface.Text)).ToString();
                    break;

                case 2:

                    txbtInterface.Text = (Convert.ToInt32(v1) + Convert.ToInt32(txbtInterface.Text)).ToString();
                    break;

                case 3:

                    txbtInterface.Text = (Convert.ToInt32(v1) * Convert.ToInt32(txbtInterface.Text)).ToString();
                    break;

                case 4:

                    txbtInterface.Text = (Convert.ToInt32(v1) / Convert.ToInt32(txbtInterface.Text)).ToString();
                    break;
            }
            }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            opcao = 3;
            v1 = txbtInterface.Text;
            txbtInterface.Clear();
        }
                       
        private void btnDividir_Click(object sender, EventArgs e)
        {
            opcao = 4;
            v1 = txbtInterface.Text;
            txbtInterface.Clear();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            opcao = 2;
            v1 = txbtInterface.Text;
            txbtInterface.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            opcao = 1;
            v1 = txbtInterface.Text;
            txbtInterface.Clear();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
             txbtInterface.Text = txbtInterface.Text + "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbtInterface.Text = txbtInterface.Text + "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbtInterface.Text = txbtInterface.Text + "4";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbtInterface.Text = txbtInterface.Text + "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbtInterface.Text = txbtInterface.Text + "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbtInterface.Text = txbtInterface.Text + "7";
        }
    }
}
