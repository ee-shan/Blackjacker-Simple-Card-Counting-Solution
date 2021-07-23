using Blackjacker___Simple_Card_Counting_Solution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjacker___A_Card_Counting_Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text) + 1;
            textBox1.Text = num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text) - 1;
            textBox1.Text = num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
