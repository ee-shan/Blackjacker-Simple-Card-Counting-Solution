using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjacker___Simple_Card_Counting_Solution
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text) - 1;
            textBox1.Text = num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text) + 1;
            textBox1.Text = num.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
